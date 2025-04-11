using MiniBlog.ViewModels;
using System.Collections.Generic;

namespace MiniBlog.Services
{
    public interface IPostService
    {
        void CreatePost(PostViewModel post);
        void DeletePost(int postId);
        IEnumerable<PostViewModel> GetAllPosts();
    }
}
