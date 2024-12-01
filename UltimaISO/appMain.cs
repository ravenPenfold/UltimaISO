using DiscUtils.Iso9660;
using RavenBrowser;
using RavenDataTypes;
using UltimaISO.Dialogs;

namespace UltimaISO
{
    public partial class appMain : Form
    {
        string version;

        Language language;
        string fileName;
        MiscTypes.DiscFormat discFormat;
        string volumeId;

        // Runtime
        string path = "";
        CDReader cd;

        // FileLists
        List<string> inFiles = new List<string>();
        List<string> outFiles = new List<string>();

        DiscImageCD cD;

        // Functions used during Runtime
        private void loadIso()
        {
            cd = new CDReader(File.OpenRead(fileName), true);
            path = "";
            cD = new DiscImageCD(fileName);
            updateScreen(cd, "\\");
        }

        public appMain(Language lang)
        {
            InitializeComponent();
            language = lang;
        }

        public appMain(Language lang, string fn)
        {
            InitializeComponent();
            language = lang;
            fileName = fn;
        }

        private void appMain_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "buildinfo.dat");
            version = sr.ReadToEnd(); // Reads Build ID
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                switch (args[1])
                {
                    case "-d":
                        debugToolStripMenuItem.Visible = true;
                        debugToolStripMenuItem.Text = "Build Timestamp: " + version;
                        break;
                }
            }



            this.Text = language.getString(Language.StringIds.appTitle);
            fileCtxMenuToolStripMenuItem.Text = language.getString(Language.StringIds.fileCtxMenu);
            newImageBtnToolStripMenuItem.Text = language.getString(Language.StringIds.newImageBtn);
            openImageBtnToolStripMenuItem.Text = language.getString(Language.StringIds.openImageBtn);
            saveImageBtnToolStripMenuItem.Text = language.getString(Language.StringIds.saveImageBtn);
            saveImageAsBtnToolStripMenuItem.Text = language.getString(Language.StringIds.saveImageAsBtn);
            imagePropertiesBtnToolStripMenuItem.Text = language.getString(Language.StringIds.imagePropertiesBtn);
            exitBtnToolStripMenuItem.Text = language.getString(Language.StringIds.exitBtn);
            openDiscImageisoToolStripMenuItem.Text = language.getString(Language.StringIds.openIsoImage);
        }

        private void exitBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newImageBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogs.Wizards.CreateNewImageDialog createNewImageDialog = new Dialogs.Wizards.CreateNewImageDialog(language);

            createNewImageDialog.ShowDialog();

            if (createNewImageDialog.createImage == true)
            {
                fileName = createNewImageDialog.fileName;
                volumeId = createNewImageDialog.volumeId;
                discFormat = createNewImageDialog.type;

                CDBuilder b = new CDBuilder();
                b.UseJoliet = true;
                b.VolumeIdentifier = volumeId;
                b.Build(fileName);

                loadIso();
            }
        }


        public void updateScreen(CDReader reader, string nPath)
        {
            // Status Setup
            pBar.Maximum = 3;
            pBar.Value = 0;
            pBar.Visible = true;
            lStatus.Text = language.getString(Language.StringIds.sbUpdatePath);
            listView1.Clear(); // Clear ListView

            // Update Dirs & Path Text
            path = cD.updateDir(nPath, path);
            tCurrentDir.Text = path;

            // Update Directories
            pBar.Value++;
            lStatus.Text = language.getString(Language.StringIds.sbLoadDirectories);
            foreach (string d in cD.getDirectories(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 0);
            }

            // Update File List
            pBar.Value++;
            lStatus.Text = language.getString(Language.StringIds.sbLoadFiles);
            foreach (string d in cD.getFiles(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 1);
            }

            pBar.Visible = false;
            lStatus.Text = language.getString(Language.StringIds.sbFinished);
        }

        public void updateScreen(CDReader reader)
        {
            // Status Setup
            pBar.Maximum = 3;
            pBar.Value = 0;
            pBar.Visible = true;
            lStatus.Text = language.getString(Language.StringIds.sbUpdatePath);
            listView1.Clear(); // Clear ListView
            tCurrentDir.Text = path;

            // Update Directories
            pBar.Value++;
            lStatus.Text = language.getString(Language.StringIds.sbUpdatePath);
            foreach (string d in cD.getDirectories(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 0);
            }
            foreach (string d in cD.getFiles(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 1);
            }
        }

        private void openDiscImageisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openIso.ShowDialog();

            if (r == DialogResult.OK)
            {
                fileName = openIso.FileName;
                loadIso();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].ImageIndex == 0)
            {
                updateScreen(cd, listView1.SelectedItems[0].Text);
            }
        }

        private void bUpOneFolder_Click(object sender, EventArgs e)
        {
            updateScreen(cd, "..");
        }

        private void tCurrentDir_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                path = tCurrentDir.Text;
                updateScreen(cd);
            }
        }

        private void aboutUltimaISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }


        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugDialog debugDialog = new DebugDialog(language, version);
            debugDialog.Show();
        }
    }

}
