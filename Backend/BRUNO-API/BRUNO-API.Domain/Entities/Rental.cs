using System;
using System.Collections.Generic;
using BRUNOAPI.Domain.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("Intent.Entities.DomainEntity", Version = "2.0")]

namespace BRUNOAPI.Domain.Entities
{
    public class Rental : IHasDomainEvent
    {

        public Rental()
        {
        }

        public Rental(Guid id, DateTime toDate, DateTime fromDate, Guid carId, Guid clientId, Car car, Client client)
        {
            Id = id;
            CarId = carId;
            ClientId = clientId;
            Car = car;
            Client = client;
            ToDate = toDate;
            FromDate = fromDate;
        }

        public Guid Id { get; set; }

        public Guid CarId { get; set; }

        public Guid ClientId { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();

        public DateTime ToDate { get; set; }

        public DateTime FromDate { get; set; }
    }
}