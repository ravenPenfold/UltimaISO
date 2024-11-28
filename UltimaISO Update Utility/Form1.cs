using IWshRuntimeLibrary;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System.IO.Compression;
using System.Net;
using UltimaISO.Dialogs;

namespace UltimaISO_Update_Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string outputArea;
        string ver = "0.1-beta1";

        private void errorDialog(Installer.InstallStage i, Exception e)
        {
            DialogResult r = MessageBox.Show("An error occurred while installing\nSetup Stage: " + i + "\nException Message: " + e.Message, "Installation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            if (r == DialogResult.OK) {
                Installer installer = new Installer("UltimaISO", "0.1-beta1", "x64", outputArea);
                installer.removeInstall();
                installer.cleanUp();
                Application.Exit();
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            lText.Text = "Please wait...";
            progressBar1.Style |= ProgressBarStyle.Marquee;
            progressBar1.Maximum = 5;

            Installer installer = new Installer("UltimaISO", "0.1-beta1", "x64", outputArea);
            // Init


            // outputArea = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "installFolder", Application.StartupPath.ToString() + "out\\").ToString();
            // outputArea = Application.StartupPath.ToString() + "out\\";


            // https://github.com/ravenPenfold/UltimaISO/releases/download/0.1-beta1/Local.Install.ZIP.zip

            lText.Text = "Downloading UltimaISO version '" + ver + "'...";
            progressBar1.Style = ProgressBarStyle.Marquee;

            ZipArchive z = null;

            try
            {
                z = new ZipArchive(System.IO.File.OpenRead(installer.downloadZip()));
            } catch (Exception ex)
            {
                errorDialog(Installer.InstallStage.downloadingZip, ex);
            }

            // 1 - Get installation location

            lText.Text = "Installing...";
            
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            // Copy files
            try
            {
                installer.installApp(z);
            }
            catch (Exception ex)
            {
                errorDialog(Installer.InstallStage.installingFromZip, ex);
            }

            // 2 - Update Registry
            lText.Text = "Updating Registry...";
            progressBar1.Style |= ProgressBarStyle.Blocks;
            progressBar1.Value++;
            try { 
                installer.updateRegistry();
            }
            catch (Exception ex)
            {
                errorDialog(Installer.InstallStage.updatingReg, ex);
            }


            // 3 - Add Setup
            lText.Text = "Creating Uninstaller...";
            progressBar1.Style |= ProgressBarStyle.Blocks;
            progressBar1.Value++;
            try { 
                installer.createUninstaller();
            }
            catch (Exception ex)
            {
                errorDialog(Installer.InstallStage.copyingUninstaller, ex);
            }

            // 4 - Add Shortcuts
            lText.Text = "Adding Shortcuts...";
            progressBar1.Style |= ProgressBarStyle.Blocks;
            progressBar1.Value++;
            try { 
                installer.createAppShortcut();
            }
            catch (Exception ex)
            {
                errorDialog(Installer.InstallStage.appShortcutCreation, ex);
            }
            try
            {
                installer.createUninstallShortcut();
            }
            catch (Exception ex)
            {
                errorDialog(Installer.InstallStage.uninstallShortcutCreation, ex);
            }

    lText.Text = "Cleaning up...";
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Value++;
            try { 
                installer.cleanUp();
            }
            catch (Exception ex)
            {
                errorDialog(Installer.InstallStage.cleanupInstaller, ex);
            }
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool update = false;
            if (Environment.GetCommandLineArgs().Length < 0)
            {

                foreach (string arg in Environment.GetCommandLineArgs())
                {
                    var args = arg.Split("=");

                    switch (args[0])
                    {
                        case "--root":
                            outputArea = args[1];
                            break;
                        case "--ver":
                            ver = args[1];
                            break;
                        case "--nodialogs":
                            update = true;
                            break;
                    }
                }
            }
            if (update == false)
            {
                RenameDialog rd = new RenameDialog();
                rd.ShowDialog();
                if (rd.finished == true)
                {
                    outputArea = rd.outFolder;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}

