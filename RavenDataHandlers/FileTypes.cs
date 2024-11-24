namespace RavenDataTypes
{
    public class FileTypes
    {
        public struct RavenLanguage        // *.rlx
        {
            public UInt32 type;
            public Int32 noLanguages;
            public List<string> strings;

            public RavenLanguage(string fileName) // <summary>Reads a RLX File</summary>
            {
                BinaryReader r = new BinaryReader(File.OpenRead(fileName));
                type = r.ReadUInt32();
                if (type == 0x524c5844)
                {
                    noLanguages = r.ReadInt32();
                    strings = new List<string>();

                    for (int i = 0; i < noLanguages; i++)
                    {
                        strings.Add(r.ReadString());
                    }
                }
                r.Close();
            }

            public RavenLanguage(BinaryReader r) // <summary>Reads a RLX File</summary>
            {
                type = r.ReadUInt32();
                if (type == 0x524c5844)
                {
                    noLanguages = r.ReadInt32();
                    strings = new List<string>();

                    for (int i = 0; i < noLanguages; i++)
                    {
                        strings.Add(r.ReadString());
                    }
                }
            }

            public RavenLanguage() // <summary>Creates a RLX File Structure</summary>
            {
                type = 0x524c5844;
                if (type == 0x524c5844)
                {
                    noLanguages = 1;
                    strings = new List<string>();

                    for (int i = 0; i < noLanguages; i++)
                    {
                        strings.Add("Hello world");
                    }
                }
            }
        }
    }
}
