using MediatR;
using Microsoft.AspNetCore.Mvc;
using Minimal.Application.Posts.Commands;
using Minimal.Application.Posts.Queries;
using Minimal.Domain.Models;

namespace Minimal.Api.Controllers
{
    [Route("")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("/api/posts/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetPostById(int id)
        {
            var getPost = new GetPostById { PostId = id };
            var post = await _mediator.Send(getPost);
            return Ok(post);
        }

        [Route("/api/posts")]
        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] Post post)
        {
            var createPost = new CreatePost { PostContent = post.Content };
            var createdPost = await _mediator.Send(createPost);
            return CreatedAtAction(nameof(GetPostById), new { id = createdPost.Id }, createPost);
        }

        [Route("/api/posts")]
        [HttpGet]
        public async Task<IActionResult> GetAllPost()
        {
            var getCommand = new GetAllPosts();
            var posts = await _mediator.Send(getCommand);
            return Ok(posts);
        }

        [Route("/api/posts/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdatePost(Post post, int id)
        {
            var updatePost = new UpdatePost { PostId = id, PostContent = post.Content };
            var updatedPost = await _mediator.Send(updatePost);
            return Ok(updatedPost);
        }

        [Route("/api/posts/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeletePost(int id)
        {
            var deletePost = new DeletePost { PotsId = id };
            await _mediator.Send(deletePost);
            return NoContent();
        }

        [Route("/api/posts/upload")]
        [HttpPost]
        public async Task<IActionResult> UploadPost(IFormFile file)
        {
            var uploadFile = file;
            await _mediator.Send(uploadFile);
            return Ok(uploadFile);
        }
    }
}
