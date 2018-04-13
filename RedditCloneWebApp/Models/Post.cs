using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditCloneWebApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int Upvotes { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<Comment> Comments { get; set; }
        //public string Username { get; set; }
    }
}
