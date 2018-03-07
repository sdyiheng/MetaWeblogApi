using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaWeblogApi
{
    public interface IBlogAPI 
    {
        // Methods
        CategoryInfo[] GetCategories(string blogid, string username, string password);
        BlogInfo[] GetUsersBlogs(string appKey, string username, string password);
        string NewMediaObject(string blogid, string username, string password, string filepath);
        string NewPost(string blogid, string username, string password, WebPost post, bool publish);

        // Properties
        string Url { get; set; }
    }

 

}
