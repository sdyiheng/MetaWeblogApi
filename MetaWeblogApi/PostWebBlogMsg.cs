using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaWeblogApi
{
    public class PostWebBlogMsg
    {
        public readonly long MapID;
        public readonly string Title;
        public readonly WebBlogConfig BlogConfig;
        public readonly BlogContentType ContentType;
        public readonly string[] Categories;

        public PostWebBlogMsg(long mapid, string title, WebBlogConfig config, BlogContentType contentType, string[] _categories)
        {
            this.MapID = mapid;
            this.Title = title;
            this.BlogConfig = config;
            this.ContentType = contentType;
            this.Categories = _categories;
        }
        
    }
}
