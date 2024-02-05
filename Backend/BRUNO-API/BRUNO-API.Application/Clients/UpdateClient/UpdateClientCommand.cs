using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Clients.UpdateClient
{
    public class UpdateClientCommand : IRequest, ICommand
    {
        public UpdateClientCommand(Guid id,
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
            Email = email;
            Phone = phone;
            Address = address;
            City = city;
            Province = province;
            LicenseNumber = licenseNumber;
            PostalCode = postalCode;
            DateJoined = dateJoined;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string LicenseNumber { get; set; }
        public string PostalCode { get; set; }
        public DateTime DateJoined { get; set; }
    }
}