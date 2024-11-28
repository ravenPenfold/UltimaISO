using IWshRuntimeLibrary;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace UltimaISO_Update_Utility
{
    

    public class Installer
    {

        public enum InstallStage
        {
            notInstalling = 0x00,
            downloadingZip = 0x01,
            installingFromZip = 0x02,
            updatingReg = 0x03,
            copyingUninstaller = 0x04,
            appShortcutCreation = 0x05,
            uninstallShortcutCreation = 0x06,
            cleanupInstaller = 0x07
        }

        public string name;
        public string version;
        public string architecture;
        public string outputFolder;
        public Installer(string repo, string ver, string arch, string outFolder)
        {
            repo = name;
            version = ver;
            architecture = arch;
            outputFolder = outFolder;
        }

        public string downloadZip()
        {
            string fileName = SpecialDirectories.Temp + name + ".zip";
            WebClient wc = new WebClient();
            wc.DownloadFile("https://github.com/ravenPenfold/UltimaISO/releases/download/" + version + "/UltimaISO-Windows-x64.zip", fileName);

            return fileName;
        }

        public void installApp(ZipArchive z)
        {
            Directory.Delete(outputFolder, true);
            Directory.CreateDirectory(outputFolder);
            z.ExtractToDirectory(outputFolder);
        }

        public void updateRegistry()
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "version", version);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RavenPenfold\\UltimaISO", "installFolder", outputFolder);
        }

        public void createAppShortcut()
        {
            string startmenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + "\\" + name;
            if (!Directory.Exists(startmenuPath))
                Directory.CreateDirectory(startmenuPath);

            string shortcutName = startmenuPath + "\\" + name + ".lnk";

            WshShell shell = new WshShell();

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutName);

            shortcut.Description = "Open " + name;
            shortcut.TargetPath = outputFolder + "\\" + name + ".exe";
            shortcut.Save();
        }

        public void createUninstaller()
        {
            System.IO.File.Copy(Application.ExecutablePath, outputFolder + "\\setup.exe");
        }

        public void createUninstallShortcut()
        {
            string startmenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + "\\" + name;
            if (!Directory.Exists(startmenuPath))
                Directory.CreateDirectory(startmenuPath);

            string shortcutName = startmenuPath + "\\Remove or Fix " + name + ".lnk";

            WshShell shell = new WshShell();

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutName);

            shortcut.Description = "Open " + name;
            shortcut.TargetPath = outputFolder + "\\setup.exe";
            shortcut.Arguments = "--modify";
            shortcut.Save();
        }

        public void cleanUp()
        {
            System.IO.File.Delete(SpecialDirectories.Temp + "UltimaISO.zip");
        }

        public void removeInstall()
        {
            if(Directory.Exists(outputFolder))
            {
                Directory.Delete(outputFolder, true);
            }
        }
    }
}
