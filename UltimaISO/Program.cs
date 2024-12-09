using RavenDataTypes;
using RavenDataTypes.Formats;
using UltimaISO.Dialogs;

namespace UltimaISO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                StandardHeader header = new StandardHeader();
                LanguageType language = header.loadLanguage(Application.StartupPath.ToString() + "res\\lang\\en_GB.rlx"); // Load Languages
                Application.Run(new appMain(language));
            }
            catch (Exception ex)
            {
                Application.Run(new ErrorDialog(ex));
            }

            
        }
    }
}