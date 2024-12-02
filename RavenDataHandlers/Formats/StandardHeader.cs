using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RavenDataTypes.Formats.LanguageType;

namespace RavenDataTypes.Formats
{
    public class StandardHeader
    {
        public enum FormatTypes
        {
            LanguageType = 0x0000,
            dummy = 0xFFFF
        }
        public struct FileType
        {
            public UInt32 id; // 0x524c5832
            public UInt32 fileSize;
            public UInt16 fileFormat;
            public UInt16 noChunks;
            public UInt32 reserved;
        }

        public FileType finfo = new FileType();

        public LanguageType loadLanguage(string fileName)
        {
            // Starts the new LanguageType and inits a BinaryReader class as 'br'
            var ltype = new LanguageType();
            finfo = new FileType();
            BinaryReader br = new BinaryReader(File.OpenRead(fileName));

            // Read the File Header
            finfo.id = br.ReadUInt32(); finfo.fileSize = br.ReadUInt32(); finfo.fileFormat = br.ReadUInt16(); 
            finfo.noChunks = br.ReadUInt16(); finfo.reserved = br.ReadUInt32();

            // Perform Validation on Header
            if (finfo.id != 0x32584c52)
            {
                throw new Exception("Invalid RLX2 File");
            } 
            if (finfo.fileFormat != (UInt16)FormatTypes.LanguageType)
            {
                throw new Exception("Invalid RLX2 Language File");
            }

            ltype.entryInfo.stringNames = new List<string>();
            ltype.entryData.strings = new List<string>();

            // Now we're ready to read the chunks
            for (UInt16 i = 0; i < finfo.noChunks; i++)
            {
                UInt32 tId = br.ReadUInt32();

                switch(tId)
                {
                    // Read each chunk
                    case 0x4f464e49:        // INFO Chunk
                        ltype.entryInfo.id = tId;
                        ltype.entryInfo.size = br.ReadUInt32();
                        ltype.entryInfo.reserved = br.ReadUInt32();
                        ltype.entryInfo.noEntries = br.ReadUInt32();
                        for(UInt32 j = 0;  j < ltype.entryInfo.noEntries; j++)
                        {
                            ltype.entryInfo.stringNames.Add(br.ReadString());
                        }
                        break;

                    case 0x41544144:        // DATA Chunk
                        ltype.entryData.id = tId;
                        ltype.entryData.size = br.ReadUInt32();
                        ltype.entryData.reserved = br.ReadUInt32();
                        ltype.entryData.noEntries = br.ReadUInt32();
                        for (UInt32 j = 0; j < ltype.entryInfo.noEntries; j++)
                        {
                            ltype.entryData.strings.Add(br.ReadString());
                        }
                        break;
                }
            }

            return ltype;
        }
    }
}
