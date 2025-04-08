using Microsoft.AspNetCore.Mvc;
using MiniBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniBlog.Controllers
{
    public class PostsController : Controller
    {
        private static List<Post> _posts = new List<Post>
        {
            new Post { Id = 1, Title = "Первый пост", Content = "Это мой первый пост!", DatePosted = DateTime.Now }
        };

        // Метод для отображения списка постов
        public IActionResult Index()
        {
            return View(_posts);
        }

        // Метод для отображения деталей поста
        public IActionResult Details(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
                return NotFound();

            return View(post);
        }

        // Метод для создания нового поста (GET)
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Метод для создания нового поста (POST)
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                post.Id = _posts.Max(p => p.Id) + 1;
                post.DatePosted = DateTime.Now;
                _posts.Add(post);
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }
    }
}
