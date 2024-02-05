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
        public Client(Guid id,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string city,
            string province,
            string licenseNumber,
            string postalCode,
            DateTime dateJoined)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Address = address;
            City = city;
            Province = province;
            LicenseNumber = licenseNumber;
            PostalCode = postalCode;
            DateJoined = dateJoined;
        }

        public Client()
        {
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string LicenseNumber { get; set; }

        public string PostalCode { get; set; }

        public DateTime DateJoined { get; set; }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}