﻿namespace Minimal.Domain.SeedWork
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
