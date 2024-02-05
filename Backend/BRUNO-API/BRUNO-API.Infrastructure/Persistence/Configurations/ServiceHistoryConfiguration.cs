using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.EntityFrameworkCore.EntityTypeConfiguration", Version = "1.0")]

namespace BRUNOAPI.Infrastructure.Persistence.Configurations
{
    public class ServiceHistoryConfiguration : IEntityTypeConfiguration<ServiceHistory>
    {
        public void Configure(EntityTypeBuilder<ServiceHistory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PreviousServiceMilage)
                .IsRequired();

            builder.Property(x => x.PreviousServiceDate)
                .IsRequired();

            builder.Property(x => x.CarId)
                .IsRequired();

            builder.HasOne(x => x.Car)
                .WithMany()
                .HasForeignKey(x => x.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Ignore(e => e.DomainEvents);
        }
    }
}