using MiniBlog.ViewModels;
using System.Collections.Generic;

namespace MiniBlog.Services
{

    public class PostService : IPostService
    {
        private readonly List<PostViewModel> _posts = new List<PostViewModel>();

        public void CreatePost(PostViewModel post)
        {
            // Логика добавления поста
            _posts.Add(post);
        }

        public void DeletePost(int postId)
        {

            if (postId >= 0 && postId < _posts.Count)
            {
                _posts.RemoveAt(postId);
            }
        }

        public IEnumerable<PostViewModel> GetAllPosts()
        {
            return _posts.ToList();
        }
    }
}