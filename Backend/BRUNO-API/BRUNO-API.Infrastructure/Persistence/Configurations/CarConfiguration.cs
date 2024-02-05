using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.EntityFrameworkCore.EntityTypeConfiguration", Version = "1.0")]

namespace BRUNOAPI.Infrastructure.Persistence.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Colour)
                .IsRequired();

            builder.Property(x => x.Make)
                .IsRequired();

            builder.Property(x => x.Model)
                .IsRequired();

            builder.Property(x => x.Registration)
                .IsRequired();

            builder.Property(x => x.DailyRate)
                .IsRequired();

            builder.Property(x => x.RentedOut)
                .IsRequired();

            builder.OwnsMany(x => x.Rentals, ConfigureRentals);

            builder.Ignore(e => e.DomainEvents);
        }

        public void ConfigureRentals(OwnedNavigationBuilder<Car, Rental> builder)
        {
            builder.WithOwner()
                .HasForeignKey(x => x.CarId);

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