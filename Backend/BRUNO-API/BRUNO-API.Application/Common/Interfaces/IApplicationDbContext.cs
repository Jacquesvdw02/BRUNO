using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.EntityFrameworkCore.DbContextInterface", Version = "1.0")]

namespace BRUNOAPI.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Car> Cars { get; }
        DbSet<Client> Clients { get; }
        DbSet<Rental> Rentals { get; }
        DbSet<ServiceHistory> ServiceHistories { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}