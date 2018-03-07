using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MetaWeblogApi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FileData
    {
        public byte[] bits;
        public string name;
        public string type;
    }

 

 

}
