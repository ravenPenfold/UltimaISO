using RavenDataTypes;
using RavenDataTypes.Formats;
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
        LanguageType language;
        public CreateNewImageDialog(LanguageType lang)
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
            this.Text = language.getString("newDiscImageWizHeader");
            lHeader.Text = language.getString("newDiscImageWizHeader");
            lDescription.Text = language.getString("newDiscImageWizDesc");
            btnFinish.Text = language.getString("commonFinishBtn");
            btnCancel.Text = language.getString("commonCancelBtn");
            gMainImageProps.Text = language.getString("cMainImageProperties");
            lFilename.Text = language.getString("cFilename");
            lImageType.Text = language.getString("cImageType");
            lImageName.Text = language.getString("cImageName");

            // Setup strings on the Combobox
            cImageType.Items.Add(language.getString("dTypeCd"));

            // Init Settings
            tImageName.Text = language.getString("defaultImageName");
            cImageType.SelectedIndex = 0;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Perform Validation
            if (tImageName.Text.Length == 0)
            {
                MessageBox.Show(language.getString("eNoImageName"), language.getString("eImageWizardErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                volumeId = tImageName.Text;
            }
            if (bFilename.Text.Length == 0)
            {
                MessageBox.Show(language.getString("eNoImageFile"), language.getString("eImageWizardErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                fileName = bFilename.Text;
            }
            if (cImageType.Text.Length == 0)
            {
                MessageBox.Show(language.getString("eNoImageType"), language.getString("eImageWizardErrorCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
