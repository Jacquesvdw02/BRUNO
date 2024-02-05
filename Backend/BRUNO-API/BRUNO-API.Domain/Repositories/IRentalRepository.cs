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
    public interface IRentalRepository : IEFRepository<Rental, Rental>
    {
        [IntentManaged(Mode.Fully)]
        Task<Rental?> FindByIdAsync(Guid id, CancellationToken cancellationToken = default);
        [IntentManaged(Mode.Fully)]
        Task<List<Rental>> FindByIdsAsync(Guid[] ids, CancellationToken cancellationToken = default);
    }
}