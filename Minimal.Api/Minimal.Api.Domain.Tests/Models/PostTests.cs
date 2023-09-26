using FluentAssertions;
using Minimal.Domain.Models;
using Xunit;

namespace Minimal.Api.Domain.Tests.Models
{
    public class PostTests
    {
        [Fact]
        public void Post_ShoulCreateCorrectly()
        {
            // Arrange
            const string content = "content";

            // Act
            var post = new Post
            {
                Content = content
            };

            //Assert
            post.Content.Should().Be(content);
        }
    }
}
