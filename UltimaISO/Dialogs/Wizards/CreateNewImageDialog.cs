using RavenDataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void CreateNewImageDialog_Load(object sender, EventArgs e)
        {
            this.Text = language.getString(Language.StringIds.newDiscImageWizHeader);
            lHeader.Text = language.getString(Language.StringIds.newDiscImageWizHeader);
            lDescription.Text = language.getString(Language.StringIds.newDiscImageWizDesc);
            btnFinish.Text = language.getString(Language.StringIds.commonFinishBtn);
            btnCancel.Text = language.getString(Language.StringIds.commonCancelBtn);
            gMainImageProps.Text = language.getString(Language.StringIds.cMainImageProperties);
            lFilename.Text = language.getString(Language.StringIds.cFilename);
            lImageType.Text = language.getString(Language.StringIds.cImageType);
            lImageName.Text = language.getString(Language.StringIds.cImageName);
            tImageName.Text = language.getString(Language.StringIds.defaultImageName);
        }
    }
}
