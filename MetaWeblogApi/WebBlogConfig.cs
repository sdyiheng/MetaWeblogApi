using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;
using System.Diagnostics;

namespace MetaWeblogApi
{
    [Serializable]
    public class WebBlogConfig
    {
        public WebBlogConfig()
        {
            URL = "";
            UserName = string.Empty;
            Password = string.Empty;
            BlogAddress = string.Empty;
            BlogName = string.Empty;
            BlogID = string.Empty;
        }

        public string URL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string BlogAddress { get; set; }
        public string BlogName { get; set; }
        public string BlogID { get; set; }

        public override string ToString()
        {
            return this.BlogName;
        }
    }




}
