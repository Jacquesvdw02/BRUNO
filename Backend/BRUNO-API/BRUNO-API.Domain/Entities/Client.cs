using System;
using System.Collections.Generic;
using BRUNOAPI.Domain.Common;
//using BRUNOAPI.Domain.Events;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("Intent.Entities.DomainEntity", Version = "2.0")]

namespace BRUNOAPI.Domain.Entities
{
    public class Client : IHasDomainEvent
    {
        public Client(Guid id, string clientName, string phone, string email, string address, string licenseNumber)
        {
            Id = id;
            ClientName = clientName;
            Phone = phone;
            Email = email;
            Address = address;
            LicenseNumber = licenseNumber;
        }

        public Client()
        {
            ClientName = null!;
            Phone = null!;
            Email = null!;
            Address = null!;
            LicenseNumber = null!;
        }

        public Guid Id { get; set; }

        public string ClientName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string LicenseNumber { get; set; }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}