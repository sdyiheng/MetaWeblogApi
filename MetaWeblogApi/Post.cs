using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using CookComputing.XmlRpc;

namespace MetaWeblogApi
{
    [StructLayout(LayoutKind.Sequential), XmlRpcMissingMapping(MappingAction.Ignore)]
    public struct Post
    {
        [XmlRpcMember(Description = "Required when posting."), XmlRpcMissingMapping(MappingAction.Error)]
        public DateTime dateCreated;
        [XmlRpcMissingMapping(MappingAction.Error), XmlRpcMember(Description = "Required when posting.")]
        public string description;
        [XmlRpcMember(Description = "Required when posting."), XmlRpcMissingMapping(MappingAction.Error)]
        public string title;
        public string[] categories;
        public Enclosure enclosure;
        public string link;
        public string permalink;
        [XmlRpcMember(Description = "Not required when posting. Depending on server may be either string or integer. Use Convert.ToInt32(postid) to treat as integer or Convert.ToString(postid) to treat as string")]
        public object postid;
        public Source source;
        public string userid;
        public object mt_allow_comments;
        public object mt_allow_pings;
        public object mt_convert_breaks;
        public string mt_text_more;
        public string mt_excerpt;
    }

 

}
