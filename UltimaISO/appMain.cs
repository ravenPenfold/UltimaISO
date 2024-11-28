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

        // FileLists
        List<string> inFiles = new List<string>();
        List<string> outFiles = new List<string>();

        // Functions used during Runtime
        private void loadIso()
        {
            inFiles.Clear();
            outFiles.Clear();
        }

        private void loadIso(string fileName)
        {
            CDBuilder cdb = new CDBuilder();
            inFiles.Clear();
            outFiles.Clear();

            using (FileStream s = File.Open(fileName, FileMode.Open))
            {
                CDReader cd = new CDReader(s, true);

                foreach (string d in cd.GetDirectories("/"))
                {

                }
            }
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

            if(createNewImageDialog.createImage == true)
            {
                fileName = createNewImageDialog.fileName;
                volumeId = createNewImageDialog.volumeId;
                discFormat = createNewImageDialog.type;
            }

            
        }
    }
}
