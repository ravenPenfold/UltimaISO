using DiscUtils.Iso9660;
using RavenBrowser;
using RavenDataTypes;
using RavenDataTypes.Formats;
using System.Media;
using System.Reflection;
using UltimaISO.Dialogs;

namespace UltimaISO
{
    public partial class appMain : Form
    {
        string version;

        LanguageType l;
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
            // cd = new CDReader(File.OpenRead(fileName), true);
            path = "";
            cD = new DiscImageCD(fileName);
            updateScreen("\\");
        }

        public appMain(LanguageType lang)
        {
            InitializeComponent();
            l = lang;
        }

        public appMain(LanguageType lang, string fn)
        {
            InitializeComponent();
            l = lang;
            fileName = fn;
        }

        private void appMain_Load(object sender, EventArgs e)
        { 

            version = Assembly.GetExecutingAssembly().GetName().Version.ToString(); ; // Reads Version

            

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                foreach (string arg in args)
                {
                    switch (arg)
                    {
                        case "-d":
                            lBuild.Visible = true;
                            lBuild.Text = l.getString("debugMode") + l.getString("commonBuild") + version;
                            break;

                        case "-ss":
                            l = new LanguageType();
                            l.entryData.strings = new List<string>();
                            l.entryInfo.stringNames = new List<string>();
                            break;
                    }
                }
            }

            // Load in Strings
            this.Text = l.getString("appTitle");
            bNewImage.Text = l.getString("btnNewImage");
            bOpenImage.Text = l.getString("btnOpenImage");
            bSaveImage.Text = l.getString("btnSaveImage");
            bSaveImageAs.Text = l.getString("btnSaveImageAs");
            bImageProperties.Text = l.getString("btnImageProperties");
        }


        public void updateScreen(string nPath)
        {
            // Status Setup
            listView1.Clear(); // Clear ListView

            // Update Dirs & Path Text
            path = cD.updateDir(nPath, path);

            // Update Directories
            foreach (string d in cD.getDirectories(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 0);
            }

            // Update File List
            foreach (string d in cD.getFiles(path))
            {
                string n = d.Split("\\").Last();
                listView1.Items.Add(n, 1);
            }
        }

        public void updateScreen()
        {
            // Status Setup
            listView1.Clear(); // Clear ListView
            // tCurrentDir.Text = path;

            // Update Directories
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].ImageIndex == 0)
            {
                updateScreen(listView1.SelectedItems[0].Text);
            }
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            if (pMenu.Visible == true)
            {
                pMenu.Visible = false;
            }
            else
            {
                pMenu.Visible = true;
            }
        }

        private void bMenu_MouseHover(object sender, EventArgs e)
        {
            tTip.SetToolTip(bMenu, l.getString("btnMenuMain"));
        }

        private void bNewImage_MouseHover(object sender, EventArgs e)
        {
            tTip.SetToolTip(bNewImage, l.getString("bdNewImage"));
        }

        private void bNewImage_Click(object sender, EventArgs e)
        {
            Dialogs.Wizards.CreateNewImageDialog createNewImageDialog = new Dialogs.Wizards.CreateNewImageDialog(l);

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

        private void bOpenImage_MouseHover(object sender, EventArgs e)
        {
            tTip.SetToolTip(bOpenImage, l.getString("bdOpenImage"));
        }

        private void bOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = l.getString("dTypeCd") + "|*.iso";

            DialogResult r = d.ShowDialog();
            if (r == DialogResult.OK)
            {
                cD = new DiscImageCD(d.FileNames.First());
                updateScreen("\\");
            }
        }

        private void lBuild_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DebugDialog(l, version).Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bAbout_Click_1(object sender, EventArgs e)
        {
            new AboutDialog(l, version).ShowDialog();
        }

        /* private void tCurrentDir_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                path = tCurrentDir.Text;
                updateScreen(cd);
            }
        } */
    }

}
