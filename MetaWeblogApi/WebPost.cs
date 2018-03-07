using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MetaWeblogApi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WebPost
    {
        public string Title;
        public string Content;
        public string PostID;
        public DateTime PostDateTime;
        public string Permalink;
        public string Tag;
        public string[] categories;
        public string link;
        public object postid;
        public string userid;
        public object mt_allow_comments;
        public object mt_allow_pings;
        public object mt_convert_breaks;
        public string mt_text_more;
        public string mt_excerpt;
    }

 

 

}
