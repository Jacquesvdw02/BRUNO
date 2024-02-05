using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.EntityFrameworkCore.EntityTypeConfiguration", Version = "1.0")]

namespace BRUNOAPI.Infrastructure.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ClientName)
                .IsRequired();

            builder.Property(x => x.Phone)
                .IsRequired();

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Address)
                .IsRequired();

            builder.Property(x => x.LicenseNumber)
                .IsRequired();

            builder.OwnsMany(x => x.Rentals, ConfigureRentals);

            builder.Ignore(e => e.DomainEvents);
        }

        public void ConfigureRentals(OwnedNavigationBuilder<Client, Rental> builder)
        {
            builder.WithOwner()
                .HasForeignKey(x => x.ClientId);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CarId)
                .IsRequired();

            builder.Property(x => x.ClientId)
                .IsRequired();

            builder.Property(x => x.ToDate)
                .IsRequired();

            builder.Property(x => x.FromDate)
                .IsRequired();
        }
    }
}