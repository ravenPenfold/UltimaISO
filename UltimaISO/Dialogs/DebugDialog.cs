using RavenDataTypes;
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
    public partial class DebugDialog : Form
    {
        LanguageType lang;
        string version;
        public DebugDialog(LanguageType language, string ver)
        {
            InitializeComponent();
            lang = language;
            version = ver;
        }

        private void stringNo_ValueChanged(object sender, EventArgs e)
        {
            lString.Text = lang.getString((UInt32)stringNo.Value);
            lStrId.Text = lang.getId((UInt32)stringNo.Value);
        }

        private void dialogRun_Click(object sender, EventArgs e)
        {
            ;
            switch (dialogList.SelectedIndex)
            {
                case 0:
                    AboutDialog aboutWin = new AboutDialog(lang, version);
                    aboutWin.Show();
                    break;

                case 1:
                    RenameDialog rename = new RenameDialog();
                    rename.Show();
                    break;

                case 2:
                    Wizards.CreateNewImageDialog newDiscImage = new Wizards.CreateNewImageDialog(lang);
                    newDiscImage.Show();
                    break;

            }
        }

        private void DebugDialog_Load(object sender, EventArgs e)
        {
            dialogList.SelectedIndex = 0;
            lString.Text = lang.getString(0);

            label1.Text = "Build ID: " + version;
            label1.Text += "\n" + "Runtime: " + Environment.Version.ToString();
            label1.Text += "\n" + "Windows Ver: " + Environment.OSVersion.ToString();

            stringNo.Maximum = lang.entryInfo.noEntries - 1;
        }


        private void sAsEditable_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bCvtStrToRlx_Click(object sender, EventArgs e)
        {
            LanguageType lt = new LanguageType();

            DialogResult r = oEditable.ShowDialog();
            if (r == DialogResult.OK)
            {
                DialogResult r2 = sAsCompiled.ShowDialog();
                if (r2 == DialogResult.OK)
                {
                    lt.makeStringDatabase(oEditable.FileName);
                    lt.writeDatabase(sAsCompiled.FileName);
                }
            }
        }
    }
}
