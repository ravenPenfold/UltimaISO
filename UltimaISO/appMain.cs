using DiscUtils.Iso9660;
using RavenBrowser;
using RavenDataTypes;
using RavenDataTypes.Formats;
using UltimaISO.Dialogs;

namespace UltimaISO
{
    public partial class appMain : Form
    {
        string version;

        LanguageType language;
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

        public appMain(LanguageType lang)
        {
            InitializeComponent();
            language = lang;
        }

        public appMain(LanguageType lang, string fn)
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
                        debugToolStripMenuItem.Text = language.getString("commonBuild") + version;
                        break;
                }
            }



            this.Text = language.getString("appTitle");
            fileCtxMenuToolStripMenuItem.Text = language.getString("fileCtxMenu");
            newImageBtnToolStripMenuItem.Text = language.getString("newImageBtn");
            openImageBtnToolStripMenuItem.Text = language.getString("openImageBtn");
            saveImageBtnToolStripMenuItem.Text = language.getString("saveImageBtn");
            saveImageAsBtnToolStripMenuItem.Text = language.getString("saveImageAsBtn");
            imagePropertiesBtnToolStripMenuItem.Text = language.getString("imagePropertiesBtn");
            exitBtnToolStripMenuItem.Text = language.getString("exitBtn");
            openDiscImageisoToolStripMenuItem.Text = language.getString("openIsoImage");

            editCtxMenuToolStripMenuItem.Text = language.getString("editCtxMenu");
            addFileBtnToolStripMenuItem.Text = language.getString("addFileBtn");
            delFileBtnToolStripMenuItem.Text = language.getString("delFileBtn");

            helpToolStripMenuItem.Text = language.getString("helpCtxMenu");
            aboutUltimaISOToolStripMenuItem.Text = language.getString("aboutDialogHeader");
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
            lStatus.Text = language.getString("sbUpdatePath");
            listView1.Clear(); // Clear ListView

            // Update Dirs & Path Text
            path = cD.updateDir(nPath, path);
            tCurrentDir.Text = path;

            // Update Directories
            pBar.Value++;
            lStatus.Text = language.getString("sbLoadDirectories");
            foreach (string d in cD.getDirectories(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 0);
            }

            // Update File List
            pBar.Value++;
            lStatus.Text = language.getString("sbLoadFiles");
            foreach (string d in cD.getFiles(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 1);
            }

            pBar.Visible = false;
            lStatus.Text = language.getString("sbFinished");
        }

        public void updateScreen(CDReader reader)
        {
            // Status Setup
            pBar.Maximum = 3;
            pBar.Value = 0;
            pBar.Visible = true;
            lStatus.Text = language.getString("sbUpdatePath");
            listView1.Clear(); // Clear ListView
            tCurrentDir.Text = path;

            // Update Directories
            pBar.Value++;
            lStatus.Text = language.getString("sbUpdatePath");
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
            AboutDialog aboutDialog = new AboutDialog(language, version);
            aboutDialog.ShowDialog();
        }


        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugDialog debugDialog = new DebugDialog(language, version);
            debugDialog.Show();
        }

        private void addFileBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }

}
