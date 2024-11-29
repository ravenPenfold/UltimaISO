using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenBrowser
{
    public class Enums
    {
        public enum DirectoryTransferMode
        { 
            goBack = 0x01,
            goForward = 0x00,
            goRoot = 0xFF
        }
    }
}
