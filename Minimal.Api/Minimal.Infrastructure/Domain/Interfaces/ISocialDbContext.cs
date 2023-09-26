using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Minimal.Domain.Models;

namespace Minimal.Infrastructure.Domain.Interfaces
{
    public interface ISocialDbContext
    {
        DbSet<Post> Posts { get; }

        IEnumerable<EntityEntry<T>> EntriesChanged<T>() where T : class;
    }
}
