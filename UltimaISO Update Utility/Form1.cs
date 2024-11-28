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
        private void Form1_Shown(object sender, EventArgs e)
        {
            lText.Text = "Please wait...";
            progressBar1.Style |= ProgressBarStyle.Marquee;
            progressBar1.Maximum = 3;
            // Init


            // outputArea = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "installFolder", Application.StartupPath.ToString() + "out\\").ToString();
            // outputArea = Application.StartupPath.ToString() + "out\\";


            // https://github.com/ravenPenfold/UltimaISO/releases/download/0.1-beta1/Local.Install.ZIP.zip

            lText.Text = "Downloading UltimaISO version '" + ver + "'...";
            progressBar1.Style = ProgressBarStyle.Marquee;

            WebClient wc = new WebClient();
            wc.DownloadFile("https://github.com/ravenPenfold/UltimaISO/releases/download/" + ver + "/UltimaISO-Windows-x64.zip", SpecialDirectories.Temp + "UltimaISO.zip");


            // Get installation location

            lText.Text = "Installing...";
            ZipArchive z = new ZipArchive(System.IO.File.OpenRead(SpecialDirectories.Temp + "UltimaISO.zip"));
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            // Copy files
            Directory.Delete(outputArea, true);
            Directory.CreateDirectory(outputArea);
            z.ExtractToDirectory(outputArea);

            // Update Registry
            lText.Text = "Updating Registry...";
            progressBar1.Style |= ProgressBarStyle.Blocks;
            progressBar1.Value++;

            Application.Exit();
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "version", ver);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "installFolder", outputArea);

            // Add Shortcuts
            lText.Text = "Adding Shortcuts...";
            progressBar1.Style |= ProgressBarStyle.Blocks;
            progressBar1.Value++;
            string startmenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + "\\UltimaISO";
            if (!Directory.Exists(startmenuPath))
                Directory.CreateDirectory(startmenuPath);

            string shortcutName = startmenuPath + "\\UltimaISO.lnk";

            WshShell shell = new WshShell();

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutName);

            shortcut.Description = "Open UltimaISO";
            shortcut.TargetPath = outputArea + "\\UltimaISO.exe";
            shortcut.Save();

            lText.Text = "Cleaning up...";
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Value++;

            System.IO.File.Delete(SpecialDirectories.Temp + "UltimaISO.zip");

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

