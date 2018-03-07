using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MetaWeblogApi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Category
    {
        public string categoryId;
        public string categoryName;
    }

 

}
