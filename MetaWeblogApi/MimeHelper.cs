using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MetaWeblogApi
{
    public static class MimeHelper
    {
        static MimeHelper()
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MetaWeblogApi.mime.txt"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    string line = string.Empty;
                    int index = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        index = line.IndexOf(':');
                        if (index > 0)
                        {
                            mimeDic.Add(line.Substring(0, index), line.Substring(index + 1));
                        }
                    }
                }
            }
        }

        private static Dictionary<string, string> mimeDic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public static string GetMIMEByExt(string ext)
        {
            if (mimeDic.ContainsKey(ext))
                return mimeDic[ext];
            else
                return "application/octet-stream";
        }
    }
}
