using RavenDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimaISO.Dialogs.Wizards
{
    public partial class CreateNewImageDialog : Form
    {
        Language language;
        public CreateNewImageDialog(Language lang)
        {
            InitializeComponent();
            language = lang;
        }

        public string fileName;
        public MiscTypes.DiscFormat type;
        public string volumeId;
        public bool createImage = false;

        private void CreateNewImageDialog_Load(object sender, EventArgs e)
        {

            // Setup Strings
            this.Text = language.getString(Language.StringIds.newDiscImageWizHeader);
            lHeader.Text = language.getString(Language.StringIds.newDiscImageWizHeader);
            lDescription.Text = language.getString(Language.StringIds.newDiscImageWizDesc);
            btnFinish.Text = language.getString(Language.StringIds.commonFinishBtn);
            btnCancel.Text = language.getString(Language.StringIds.commonCancelBtn);
            gMainImageProps.Text = language.getString(Language.StringIds.cMainImageProperties);
            lFilename.Text = language.getString(Language.StringIds.cFilename);
            lImageType.Text = language.getString(Language.StringIds.cImageType);
            lImageName.Text = language.getString(Language.StringIds.cImageName);

            // Setup strings on the Combobox
            cImageType.Items.Add(language.getString(Language.StringIds.dTypeCd));

            // Init Settings
            tImageName.Text = language.getString(Language.StringIds.defaultImageName);
            cImageType.SelectedIndex = 0;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Perform Validation
            if (tImageName.Text.Length == 0)
            {
                MessageBox.Show(language.getString(Language.StringIds.eNoImageName), language.getString(Language.StringIds.eImageWizardErrorCaption), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                volumeId = tImageName.Text;
            }
            if (bFilename.Text.Length == 0)
            {
                MessageBox.Show(language.getString(Language.StringIds.eNoImageFile), language.getString(Language.StringIds.eImageWizardErrorCaption), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                fileName = bFilename.Text;
            }
            if (cImageType.Text.Length == 0)
            {
                MessageBox.Show(language.getString(Language.StringIds.eNoImageType), language.getString(Language.StringIds.eImageWizardErrorCaption), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                type = (MiscTypes.DiscFormat)cImageType.SelectedIndex;
            }
            createImage = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bFilename_Click(object sender, EventArgs e)
        {
            switch ((MiscTypes.DiscFormat)cImageType.SelectedIndex)
            {
                case MiscTypes.DiscFormat.Cd:
                    openFileDialog1.Filter = "ISO Image|*.iso|All Files|*.*";
                    break;
            }
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                bFilename.Text = openFileDialog1.FileName;
            }
        }
    }
}
