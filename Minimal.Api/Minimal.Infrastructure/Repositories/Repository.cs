using Minimal.Application.Abstractions;
using Minimal.Domain.Models;

namespace Minimal.Infrastructure.Repositories
{
    public class Repository : IRepository
    {
        List<Post> list = new List<Post>();

        public void AddPost(Post post)
        {
            list.Add(post);
        }

        public void DeletePost(int id)
        {
            list.RemoveAll(i => i.Id == id);
        }

        public Post UpdatePost(int id, Post post)
        {
            Post existingPost = list.FirstOrDefault(p => p.Id == id)!;

            if (existingPost != null)
            {
                existingPost.Content = post.Content;

                return existingPost;
            }
            else
            {
                throw new ArgumentException("O post não existe");
            }
        }

        public List<Post> GetPosts() => list;

        public Post GetPostById(int id) => list.FirstOrDefault(p => p.Id == id)!;
    }
}
