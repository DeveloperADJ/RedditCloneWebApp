using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditCloneWebApp.Repositories;

namespace RedditCloneWebApp.Controllers
{
    public class HomeController : Controller
    {
        IPostRepository postRepository;

        public HomeController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View(postRepository.Read().OrderByDescending(x=>x.Upvotes));
        }

        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            postRepository.Delete(id);
            return RedirectToAction("Index");
        }

        [Route("Upvote")]
        public IActionResult Upvote(int id)
        {
            postRepository.Upvote(id);
            return RedirectToAction("Index");
        }

        [Route("Downvote")]
        public IActionResult Downvote(int id)
        {
            postRepository.Downvote(id);
            return RedirectToAction("Index");
        }

        [Route("CreatePost")]
        public IActionResult CreatePost(string Title, string Url)
        {
            postRepository.Create(Title, Url);
            return RedirectToAction("Index");
        }

        [Route("Submit")]
        public IActionResult Submit()
        {
            return View();
        }
    }
}