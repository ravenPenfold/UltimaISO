using RavenDataTypes;
using System.Security.Cryptography.X509Certificates;
using UltimaISO.Dialogs;

namespace UltimaISO
{
    public partial class appMain : Form
    {
        Language language;
        public appMain(Language lang)
        {
            InitializeComponent();
            language = lang;
        }

        public appMain(Language lang, string fileName)
        {
            InitializeComponent();
            language = lang;
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
        }
    }
}
