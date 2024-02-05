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

            builder.Property(x => x.FirstName)
                .IsRequired();

            builder.Property(x => x.LastName)
                .IsRequired();

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Phone)
                .IsRequired();

            builder.Property(x => x.Address)
                .IsRequired();

            builder.Property(x => x.City)
                .IsRequired();

            builder.Property(x => x.Province)
                .IsRequired();

            builder.Property(x => x.LicenseNumber)
                .IsRequired();

            builder.Property(x => x.PostalCode)
                .IsRequired();

            builder.Property(x => x.DateJoined)
                .IsRequired();

            builder.Ignore(e => e.DomainEvents);
        }
    }
}