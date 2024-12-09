using DiscUtils.Iso9660;
using static RavenBrowser.Enums;

namespace RavenBrowser
{
    public class DiscImageCD
    {
        // Definitions
        private CDBuilder build;
        private CDReader reader;
        private string imagePath;
        
        public DiscImageCD(string p)
        {
            /// <summary>Create constructor for DiscImageCD</summary>
            build = new CDBuilder();
            // 
            imagePath = p;
        }

        
        public List<string> getDirectories(string path)
        {
            /// <summary>Returns a list of Directories in a certain path</summary>
            reader = new CDReader(File.OpenRead(imagePath), true);
            List<string> dirs = new List<string>();

            foreach (string d in reader.GetDirectories(path))
            {
                string n = d.Split("\\").Last();
                dirs.Add(n);
            }

            return dirs;
        }

        public List<string> getFiles(string path)
        {
            /// <summary>Returns a list of Files in a certain path</summary>
            reader = new CDReader(File.OpenRead(imagePath), true);
            List<string> files = new List<string>();
            foreach (string d in reader.GetFiles(path))
            {
                string n = d.Split("\\").Last();
                n = n.Split(";").First();
                files.Add(n);
            }
            return files;
        }

        public string updateDir(string path, string currentPath)
        {
            /// <summary>
            /// Parses the directory request
            /// 
            /// If path is '\'  - then it'll go to the root
            /// If path is '..' - then it'll go back 1 directory
            /// </summary>
            string s = "";
            switch(path)
            {
                case "\\":
                    s = "\\";
                    break;
                case "..":
                    var split = currentPath.Split("\\");
                    s = "";

                    for (int i = 0; i < split.Count() - 2; i++)
                    {
                        s = s + split[i] + "\\";
                    }
                    break;
                default:
                    s = currentPath + path + "\\";
                    break;
            }
            return s;
        }

        public void AddFile(string path, string inFile)
        {
            reader.Dispose();
            build = new CDBuilder();
            build.UseJoliet = true;
            build.AddFile(path + inFile.Split("\\").Last(), inFile);
            build.Build(imagePath + ".tmp");
            reader = new CDReader(File.OpenRead(imagePath), true);
        }


    }
}
