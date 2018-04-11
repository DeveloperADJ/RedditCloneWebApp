using RedditCloneWebApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditCloneWebApp.Models
{
    public class PostRepository : IPostRepository
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public void Create(string title, string url)
        {
            postContext.Add(new Post { Title = title, Url = url});
            postContext.SaveChanges();
        }

        public void Delete()
        {
        }

        public List<Post> Read()
        {
            return postContext.Posts.ToList();
        }

        public void Update()
        {
        }
    }
}
