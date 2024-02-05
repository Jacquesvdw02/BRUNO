using System;
using System.Collections.Generic;
using BRUNOAPI.Domain.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("Intent.Entities.DomainEntity", Version = "2.0")]

namespace BRUNOAPI.Domain.Entities
{
    public class ServiceHistory : IHasDomainEvent
    {
        public ServiceHistory(Guid id, int previousServiceMilage, DateTime previousServiceDate, Guid carId, Car car)
        {
            Id = id;
            PreviousServiceMilage = previousServiceMilage;
            PreviousServiceDate = previousServiceDate;
            CarId = carId;
            Car = car;
        }

        /// <summary>
        /// Required by Entity Framework.
        /// </summary>
        protected ServiceHistory()
        {
            Car = null!;
        }

        public Guid Id { get; set; }

        public int PreviousServiceMilage { get; set; }

        public DateTime PreviousServiceDate { get; set; }

        public Guid CarId { get; set; }

        public virtual Car Car { get; set; }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}