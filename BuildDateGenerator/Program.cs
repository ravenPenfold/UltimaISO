// See https://aka.ms/new-console-template for more information
string BuildDate = DateTime.Now.Year.ToString();
string[] arg = Environment.GetCommandLineArgs();
string location;

try
{
    location = arg[1];
} catch (Exception e)
{
    location = "buildinfo.dat";
}
/* if (DateTime.Now.Month < 10)
{
    BuildDate += "0" + DateTime.Now.Month.ToString();
}
else
{
    BuildDate += BuildDate += DateTime.Now.Month.ToString();
}
if (DateTime.Now.Day < 10)
{
    BuildDate += "0" + DateTime.Now.Day.ToString();
} else
{
    BuildDate += BuildDate += DateTime.Now.Day.ToString();
}
BuildDate += DateTime.Now.Day.ToString();
BuildDate += ".";
BuildDate += DateTime.Now.Hour.ToString();
if (DateTime.Now.Minute < 10)
{
    BuildDate += "0" + DateTime.Now.Minute.ToString();
}
else
{
    BuildDate += BuildDate += DateTime.Now.Minute.ToString();
}
*/
StreamReader sr = new StreamReader(location);
string line = sr.ReadToEnd();
BuildDate = (Int32.Parse(line)+1).ToString();
sr.Close();
StreamWriter sw = new StreamWriter(location);
sw.Write(BuildDate);
sw.Close();
Console.WriteLine("Wrote Build Date/Time " + BuildDate + " to " + arg[1]);
