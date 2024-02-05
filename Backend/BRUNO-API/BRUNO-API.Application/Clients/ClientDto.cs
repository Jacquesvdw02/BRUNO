using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.Clients
{
    public class ClientDto : IMapFrom<Client>
    {
        public ClientDto()
        {
            FirstName = null!;
            LastName = null!;
            Email = null!;
            Phone = null!;
            Address = null!;
            City = null!;
            Province = null!;
            LicenseNumber = null!;
            PostalCode = null!;
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

        public static ClientDto Create(
            Guid id,
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
            return new ClientDto
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phone,
                Address = address,
                City = city,
                Province = province,
                LicenseNumber = licenseNumber,
                PostalCode = postalCode,
                DateJoined = dateJoined
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Client, ClientDto>();
        }
    }
}