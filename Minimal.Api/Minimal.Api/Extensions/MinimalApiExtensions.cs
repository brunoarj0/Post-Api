using Microsoft.EntityFrameworkCore;
using Minimal.Application.Abstractions;
using Minimal.Application.Posts.Commands;
using Minimal.Infrastructure;
using Minimal.Infrastructure.Repositories;

namespace Minimal.Api.Extensions
{
    public static class MinimalApiExtensions
    {
        public static void RegisterServices(this WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<SocialDbContext>(opt => opt.UseSqlServer(cs));
            builder.Services.AddScoped<IPostRepository, PostRepository>();
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreatePost>());
            builder.Services.AddControllers();
        }
    }
}
