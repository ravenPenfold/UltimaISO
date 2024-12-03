// See https://aka.ms/new-console-template for more information
using RavenDataTypes.Formats;

Console.WriteLine("Creating Language Data from Resources");

DirectoryInfo di = new DirectoryInfo("lang");
LanguageType lt = new LanguageType();

foreach(FileInfo fi in di.GetFiles())
{
    if(fi.FullName.EndsWith(".txt"))
    {
        lt.makeStringDatabase(fi.FullName);
        lt.writeDatabase("res\\lang\\" + fi.Name.Replace(".txt",".rlx"));
    }
}