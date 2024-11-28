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
        private void Form1_Shown(object sender, EventArgs e)
        {
            lText.Text = "Please wait...";
            progressBar1.Style |= ProgressBarStyle.Marquee;
            progressBar1.Maximum = 2;
            // Init
            string ver = "0.1-beta1";

            // outputArea = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "installFolder", Application.StartupPath.ToString() + "out\\").ToString();
            // outputArea = Application.StartupPath.ToString() + "out\\";


            // https://github.com/ravenPenfold/UltimaISO/releases/download/0.1-beta1/Local.Install.ZIP.zip

            lText.Text = "Downloading UltimaISO version '" + ver + "'...";
            progressBar1.Style = ProgressBarStyle.Marquee;

            WebClient wc = new WebClient();
            wc.DownloadFile("https://github.com/ravenPenfold/UltimaISO/releases/download/" + ver + "/Local.Install.ZIP.zip", SpecialDirectories.Temp + "UltimaISO.zip");
            

            // Get installation location

            lText.Text = "Installing...";
            ZipArchive z = new ZipArchive(File.OpenRead(SpecialDirectories.Temp + "UltimaISO.zip"));
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            // Copy files
            Directory.Delete(outputArea, true);
            Directory.CreateDirectory(outputArea);
            z.ExtractToDirectory(outputArea);

            lText.Text = "Updating Registry...";
            progressBar1.Style |= ProgressBarStyle.Blocks;
            progressBar1.Value++;

            Application.Exit();
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "version", ver);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "installFolder", outputArea);

            lText.Text = "Cleaning up...";
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Value++;

            File.Delete(SpecialDirectories.Temp + "UltimaISO.zip");

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length < 0)
            {
                switch(Environment.GetCommandLineArgs()[1])
                {
                    case "/l":
                        outputArea = Environment.GetCommandLineArgs()[2];
                        break;
                    default:
                        Console.WriteLine("UltimaISO_Update_Utility.exe <infolder>");
                        break;
                }
            } else
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
