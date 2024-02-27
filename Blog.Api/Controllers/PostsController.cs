using Blog.Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Post>> GetPosts([FromQuery] int page, [FromQuery] int itemsPerPage)
        {
            return new List<Post>
            {
                new Post
                {
                    Title = "Second Post",
                    DatePosted = DateTime.Now,
                    Html = "test"
                },
                new Post
                {
                    Title = "First Post",
                    DatePosted = DateTime.Now,
                    Html = "another test"
                }
            };
        }
    }
}
