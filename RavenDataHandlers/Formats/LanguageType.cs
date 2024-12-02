using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace RavenDataTypes.Formats
{
    public class LanguageType
    {
        public struct EntryInfo
        {
            public UInt32 id; // 0x494e464f
            public UInt32 size;
            public UInt32 reserved;
            public UInt32 noEntries;
            public List<string> stringNames;
        }

        public EntryInfo entryInfo;

        public struct EntryData {
            public UInt32 id; // 0x44415441
            public UInt32 size;
            public UInt32 reserved;
            public UInt32 noEntries;
            public List<string> strings;
        }

        public EntryData entryData;

        public LanguageType() {
            entryData = new EntryData();
            entryInfo = new EntryInfo();
        }

        public string getString(UInt32 id)
        {
            try
            {
                return entryData.strings.ElementAt((int)id);
            } 
            catch (ArgumentOutOfRangeException e)
            {
                return "Dummy string";
            }
        }

        public string getString(string id)
        {
            try
            {
                return entryData.strings.ElementAt(entryInfo.stringNames.IndexOf(id));
            } catch (ArgumentOutOfRangeException e) {
                return "Dummy string";
            }
        }

        public string getId(UInt32 id)
        {
            try
            {
                return entryInfo.stringNames.ElementAt((int)id);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return "unknownId";
            }
        }

        public void makeStringDatabase(string input)
        {
            string[] lines = File.ReadAllLines(input);

            UInt32 i = 0;

            entryInfo.stringNames = new List<string>();
            entryData.strings = new List<string>();

            foreach (string line in lines)
            {
                if (line.StartsWith(";") != true)
                {
                    if (line.Contains("="))
                    {
                        i++;
                        var splitLine = line.Split("=");
                        entryInfo.stringNames.Add(splitLine[0].Replace(" ", ""));
                        entryData.strings.Add(splitLine[1].Remove(0,1));
                        entryInfo.noEntries = i;
                    }
                }
            }
        }

        public void outputEditable(string output)
        {
            StreamWriter w = new StreamWriter(File.Open(output, FileMode.Create));

            foreach(string s in entryInfo.stringNames)
            {
                w.WriteLine(s + " = " + getString(s));
            }

            w.Close();
        }

        public void writeDatabase(string output)
        {
            BinaryWriter w = new BinaryWriter(File.Open(output, FileMode.Create));

            StandardHeader sh = new StandardHeader();

            // Setup Header
            sh.finfo.id = 0x32584c52;
            sh.finfo.fileFormat = (UInt16)Formats.StandardHeader.FormatTypes.LanguageType;
            sh.finfo.noChunks = 2;
            sh.finfo.fileSize = 16;
            sh.finfo.reserved = 0;

            entryInfo.size = 16;
            foreach(string s in entryInfo.stringNames)
            {
                entryInfo.size += (UInt32)s.Length + 1;
            }
            entryInfo.id = 0x4f464e49;
            entryInfo.reserved = 0;
            sh.finfo.fileSize += entryInfo.size;

            entryData.size = 16;
            foreach (string s in entryData.strings)
            {
                entryData.size += (UInt32)s.Length + 1;
            }
            entryData.id = 0x41544144;
            entryData.reserved = 0;
            sh.finfo.fileSize += entryData.size;

            // Now we write
            w.Write(sh.finfo.id); w.Write(sh.finfo.fileSize); w.Write(sh.finfo.fileFormat); w.Write(sh.finfo.noChunks); w.Write(sh.finfo.reserved); // Main Chunk
            
            w.Write(entryInfo.id); w.Write(entryInfo.size); w.Write(entryInfo.reserved); w.Write(entryInfo.noEntries); // Info Chunk Heading
            foreach(string s in entryInfo.stringNames)
            {
                w.Write(s);
            }

            w.Write(entryData.id); w.Write(entryData.size); w.Write(entryData.reserved); w.Write(entryData.noEntries); // Data Chunk Heading
            foreach (string s in entryData.strings)
            {
                w.Write(s);
            }

            // Finish
            w.Close();
        }
    }
}
