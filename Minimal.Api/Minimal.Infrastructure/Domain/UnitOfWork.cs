using Minimal.Domain.SeedWork;

namespace Minimal.Infrastructure.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SocialDbContext _socialDbContext;

        public UnitOfWork(SocialDbContext socialDbContext)
        {
            _socialDbContext = socialDbContext;
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken)
        {
            return await _socialDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
