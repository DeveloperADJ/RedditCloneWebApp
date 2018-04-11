using RedditCloneWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditCloneWebApp.Repositories
{
    public interface IPostRepository
    {
        void Create(string title, string url);
        List<Post> Read();
        void Update();
        void Delete();
        void Upvote(int id);
        void Downvote(int id);
    }
}
