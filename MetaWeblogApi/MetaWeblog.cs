using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookComputing.XmlRpc;
using System.IO;
using MetaWeblogApi;

namespace MetaWeblogApi
{
    public class MetaWeblog:IBlogAPI 
    {
        public  static MetaWeblog Instance = new MetaWeblog();

        // Fields
        private IMetaWeblog mIMetaWeblog;

        private MetaWeblog()
        {
            this.mIMetaWeblog = XmlRpcProxyGen.Create<IMetaWeblog>();
            Instance = this;
        }

        public string Url
        {
            get
            {
                return this.mIMetaWeblog.Url;
            }
            set
            {
                this.mIMetaWeblog.Url = value;
            }
        }

        public CategoryInfo[] GetCategories(string blogid, string username, string password)
        {
            try
            {
                CategoryInfo[] infoArray = this.mIMetaWeblog.getCategories(blogid, username, password);
                int length = infoArray.Length;
                CategoryInfo[] infoArray2 = new CategoryInfo[infoArray.Length];
                for (int i = 0; i < length; i++)
                {
                    infoArray2[i].categoryid = infoArray[i].categoryid;
                    infoArray2[i].description = infoArray[i].description;
                    infoArray2[i].htmlUrl = infoArray[i].htmlUrl;
                    infoArray2[i].rssUrl = infoArray[i].rssUrl;
                    infoArray2[i].title = infoArray[i].title;
                }
                return infoArray2;
            }
            catch
            {
                return null;
            }
        }

        public BlogInfo[] GetUsersBlogs(string appKey, string username, string password)
        {
            try
            {
                BlogInfo[] infoArray = this.mIMetaWeblog.getUsersBlogs(appKey, username, password);
                int length = infoArray.Length;
                BlogInfo[] infoArray2 = new BlogInfo[infoArray.Length];
                for (int i = 0; i < length; i++)
                {
                    infoArray2[i].blogid = infoArray[i].blogid;
                    infoArray2[i].blogName = infoArray[i].blogName;
                    infoArray2[i].url = infoArray[i].url;
                }
                return infoArray2;
            }
            catch
            {
                return null;
            }
        }

        public string NewMediaObject(string blogid, string username, string password, string filepath)
        {
            try
            {
                FileData file = new FileData
                {
                    name = DateTime.Now.ToString("yyyyMMddhhmmss") + "_" + Path.GetFileName(filepath),
                    //bits = System.Text.ASCIIEncoding.ASCII.GetBytes(Convert.ToBase64String(File.ReadAllBytes(filepath))),
                    bits = File.ReadAllBytes(filepath),
                    type = MimeHelper.GetMIMEByExt(Path.GetExtension(filepath))
                };

                return this.mIMetaWeblog.newMediaObject(blogid, username, password, file).url;
            }
            catch
            {
                return filepath;
            }
        }

        public string NewPost(string blogid, string username, string password, WebPost post, bool publish)
        {
            try
            {
                Post post2 = new Post
                {
                    title = post.Title,
                    dateCreated = post.PostDateTime,
                    description = post.Content,
                    postid = post.PostID,
                    permalink = post.Permalink,
                    categories = post.categories,
                    userid = post.userid,
                    mt_text_more = post.mt_text_more,
                    link = post.link,
                    mt_excerpt = post.mt_excerpt,
                    mt_allow_pings = post.mt_allow_pings,
                    mt_allow_comments = post.mt_allow_comments,
                    mt_convert_breaks = post.mt_convert_breaks
                };
                this.mIMetaWeblog.newPost(blogid, username, password, post2, publish);
                return "ok";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


    }
}
