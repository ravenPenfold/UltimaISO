using RavenDataTypes.Formats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimaISO.Dialogs
{
    public partial class AboutDialog : Form
    {
        LanguageType lt = new LanguageType();
        string ver;
        public AboutDialog(LanguageType l, string version)
        {
            InitializeComponent();
            lt = l;
            ver = version;
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            this.Text = lt.getString("aboutDialogHeader");

            lTitle.Text = lt.getString("versionNo");
            lVersionInfo.Text = lt.getString("commonBuild") + ver;
            bOk.Text = lt.getString("commonOk");
            lAcknowledgements.Text = lt.getString("creditsTag");
            lLicenseTag.Text = lt.getString("licenseTag");
            lCopyright.Text = lt.getString("copyright");
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
