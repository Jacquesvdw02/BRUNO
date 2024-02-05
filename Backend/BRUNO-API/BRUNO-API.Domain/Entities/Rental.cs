using System;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("Intent.Entities.DomainEntity", Version = "2.0")]

namespace BRUNOAPI.Domain.Entities
{
    public class Rental
    {
        public Rental(Guid id, Guid carId, Guid clientId, DateTime toDate, DateTime fromDate)
        {
            Id = id;
            CarId = carId;
            ClientId = clientId;
            ToDate = toDate;
            FromDate = fromDate;
        }

        /// <summary>
        /// Required by Entity Framework.
        /// </summary>
        protected Rental()
        {
        }

        public Guid Id { get; set; }

        public Guid CarId { get; set; }

        public Guid ClientId { get; set; }

        public DateTime ToDate { get; set; }

        public DateTime FromDate { get; set; }
    }
}