using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Entities.Repositories.Api.EntityRepositoryInterface", Version = "1.0")]

namespace BRUNOAPI.Domain.Repositories
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public interface IServiceHistoryRepository : IEFRepository<ServiceHistory, ServiceHistory>
    {
        [IntentManaged(Mode.Fully)]
        Task<ServiceHistory?> FindByIdAsync(Guid id, CancellationToken cancellationToken = default);
        [IntentManaged(Mode.Fully)]
        Task<List<ServiceHistory>> FindByIdsAsync(Guid[] ids, CancellationToken cancellationToken = default);
    }
}