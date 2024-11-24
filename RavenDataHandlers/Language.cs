using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenDataTypes
{
    public class Language
    {
        public enum StringIds
        {
            languageName = 0,
            appTitle = 1,
            fileCtxMenu = 2,
            newImageBtn = 3,
            openImageBtn = 4,
            saveImageBtn = 5,
            saveImageAsBtn = 6,
            imagePropertiesBtn = 7,
            exitBtn = 8,
            newDiscImageWizHeader = 9,
            newDiscImageWizDesc = 10,
            commonCancelBtn = 11,
            commonFinishBtn = 12,
            cMainImageProperties = 13,
            cFilename = 14,
            cImageType = 15,
            cImageName = 16,
            defaultImageName = 17
        }

        FileTypes.RavenLanguage lang;
        
        public string getStringUse(int id)
        {
            try
            {
                StringIds sId = (StringIds)id;
                return sId.ToString();
            } catch (Exception e) {
                return "Unused";
            }
        }

        public string getString(StringIds id)
        {
            try
            {
                return lang.strings.ElementAt((int)id);
            }
            catch (Exception e)
            {
                return id.ToString();
            }
        }

        public string getString(int id)
        {
            try
            {
                return lang.strings.ElementAt(id);
            }
            catch (Exception e)
            {
                return id.ToString();
            }
        }

        public void addString(string str)
        {
            lang.strings.Add(str);
            lang.noLanguages++;
        }

        public void writeStringsToFile(string fileName)
        {
            BinaryWriter w = new BinaryWriter(File.Open(fileName, FileMode.Create));

            w.Write(lang.type);
            w.Write(lang.noLanguages);

            foreach (string s in lang.strings)
            {
                w.Write(s);
            }
            w.Close();
        }

        public int getNoStrings()
        {
            return lang.noLanguages;
        }

        public void updateString(int id, string str)
        {
            lang.strings[id] = str;
        }

        public void removeString(int id)
        {
            lang.strings.RemoveAt(id);
            lang.noLanguages++;
        }

        public Language(string fileName) {
            lang = new FileTypes.RavenLanguage(fileName);
        }

        public Language(BinaryReader reader)
        {
            lang = new FileTypes.RavenLanguage(reader);
        }

        public Language()
        {
            lang = new FileTypes.RavenLanguage();
        }
    }
}
