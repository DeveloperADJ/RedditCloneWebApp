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
            postContext.Add(new Post { Title = title, Url = url, TimeStamp = DateTime.Now
        });
            postContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Post post = postContext.Posts.FirstOrDefault(x => x.Id == id);
            postContext.Remove(post);
            postContext.SaveChanges();
        }

        public List<Post> Read ()
        {
            return postContext.Posts.ToList();
        }

        public void Update()
        {
        }

        public void Upvote(int id)
        {
            Post post = postContext.Posts.FirstOrDefault(x => x.Id == id);
            post.Upvotes++;
            postContext.SaveChanges();
        }

        public void Downvote(int id)
        {
            Post post = postContext.Posts.FirstOrDefault(x => x.Id == id);
            post.Upvotes--;
            postContext.SaveChanges();
        }
    }
}
