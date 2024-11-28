using DiscUtils.Iso9660;
using Microsoft.Win32;
using RavenDataTypes;
using System.Security.Cryptography.X509Certificates;
using UltimaISO.Dialogs;

namespace UltimaISO
{
    public partial class appMain : Form
    {
        Language language;
        string fileName;
        MiscTypes.DiscFormat discFormat;
        string volumeId;

        // Runtime
        string path;
        CDReader cd;

        // FileLists
        List<string> inFiles = new List<string>();
        List<string> outFiles = new List<string>();

        // Functions used during Runtime
        private void loadIso()
        {
            cd = new CDReader(File.OpenRead(fileName), true);
            path = cd.Root.FullName;
            updateScreen(cd);
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
            this.Text = language.getString(Language.StringIds.appTitle);
            fileCtxMenuToolStripMenuItem.Text = language.getString(Language.StringIds.fileCtxMenu);
            newImageBtnToolStripMenuItem.Text = language.getString(Language.StringIds.newImageBtn);
            openImageBtnToolStripMenuItem.Text = language.getString(Language.StringIds.openImageBtn);
            saveImageBtnToolStripMenuItem.Text = language.getString(Language.StringIds.saveImageBtn);
            saveImageAsBtnToolStripMenuItem.Text = language.getString(Language.StringIds.saveImageAsBtn);
            imagePropertiesBtnToolStripMenuItem.Text = language.getString(Language.StringIds.imagePropertiesBtn);
            exitBtnToolStripMenuItem.Text = language.getString(Language.StringIds.exitBtn);
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

        public string updateDir(bool goBack, string add)
        {
            string s = path;

            if (goBack == true)
            {
                s = "";
                var pathSplit = path.Split("\\");

                for (int i = 0; i < pathSplit.Length - 1; i++)
                {
                    s = s + pathSplit[i] + "\\";
                }
                return s;
            }
            else
            {
                s = s + "\\" + add;
                return s;
            }
        }

        public void updateScreen(CDReader reader)
        {
            listView1.Clear();

            if (reader.DirectoryExists(path) == true)
            {
                foreach (string d in reader.GetDirectories(path))
                {
                    string n = d.Split("\\").Last();
                    listView1.Items.Add(n, 0);
                }
                foreach (string d in reader.GetFiles(path))
                {
                    string n = d.Split("\\").Last();
                    listView1.Items.Add(n, 1);
                }
            }

            tCurrentDir.Text = path;
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
                path = updateDir(false, listView1.SelectedItems[0].Text);
                updateScreen(cd);
            }
        }

        private void bUpOneFolder_Click(object sender, EventArgs e)
        {
            path = updateDir(true, "");
            updateScreen(cd);
        }
    }

}
