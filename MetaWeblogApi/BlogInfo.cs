using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MetaWeblogApi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BlogInfo
    {
        public string blogid;
        public string url;
        public string blogName;
    }

 

}
