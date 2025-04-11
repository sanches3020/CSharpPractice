using Microsoft.AspNetCore.Mvc;
using MiniBlog.Models;
using System.Linq;

namespace MiniBlog.Controllers
{
    public class PostsController : Controller
    {
        private static List<Post> _posts = new List<Post>
        {
            new Post { Id = 1, Title = "Первый пост", Content = "Это мой первый пост!", DatePosted = DateTime.Now }
        };

        public IActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            return View(_posts);
        }

        public IActionResult Details(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
                return NotFound();

            return View(post);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                post.Id = _posts.Any() ? _posts.Max(p => p.Id) + 1 : 1;
                post.DatePosted = DateTime.Now;
                _posts.Add(post);

                TempData["Message"] = "Пост успешно опубликован!";
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
                return NotFound();

            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
            var existingPost = _posts.FirstOrDefault(p => p.Id == post.Id);
            if (existingPost == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                existingPost.Title = post.Title;
                existingPost.Content = post.Content;

                TempData["Message"] = "Пост успешно обновлен!";
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        public IActionResult Delete(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
                return NotFound();

            _posts.Remove(post);
            TempData["Message"] = "Пост успешно удален!";
            return RedirectToAction(nameof(Index));
        }
    }
}
