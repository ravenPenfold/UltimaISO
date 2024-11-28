using Microsoft.VisualBasic.FileIO;
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
    public partial class RenameDialog : Form
    {
        public RenameDialog()
        {
            InitializeComponent();
        }

        public string outFolder = SpecialDirectories.ProgramFiles.ToString() + "\\UltimaISO";
        public bool finished = false;
        string ver = "0.1-beta1";

        private void bAccept_Click(object sender, EventArgs e)
        {
            outFolder = tFilename.Text;
            finished = true;
            Directory.CreateDirectory(outFolder);
            this.Close();

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = outFolder;
            DialogResult r = folderBrowserDialog1.ShowDialog();

            if (r == DialogResult.OK)
            {
                tFilename.Text = folderBrowserDialog1.SelectedPath;
                outFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void RenameDialog_Load(object sender, EventArgs e)
        {
            tFilename.Text = outFolder;
        }
    }
}
