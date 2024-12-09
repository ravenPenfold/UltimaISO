using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimaISO.Dialogs
{
    public partial class ErrorDialog : Form
    {   Exception exception;
        public ErrorDialog(Exception e)
        {
            InitializeComponent();
            exception = e;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void vLogFile_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", Application.UserAppDataPath.ToString() + "logs\\active_log-" + DateTime.Now.ToString() + ".log");
        }

        private void ErrorDialog_Load(object sender, EventArgs e)
        {
            errorCode.Text = "Error Code: " + exception.Message;
            errorLine.Text = "Error in Object: " + exception.Source;
        }
    }
}
