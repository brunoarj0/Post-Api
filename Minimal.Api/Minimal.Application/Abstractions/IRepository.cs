using Minimal.Domain.Models;

namespace Minimal.Application.Abstractions
{
    public interface IRepository
    {
        void AddPost(Post post);
        void DeletePost(int id);
        Post UpdatePost(int id, Post post);
        List<Post> GetPosts();
        Post GetPostById(int id);
    }
}
