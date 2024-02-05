using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals
{
    public class ClientDto : IMapFrom<Client>
    {
        public ClientDto()
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

        public static ClientDto Create(
            Guid id,
            string clientName,
            string phone,
            string email,
            string address,
            string licenseNumber)
        {
            return new ClientDto
            {
                Id = id,
                ClientName = clientName,
                Phone = phone,
                Email = email,
                Address = address,
                LicenseNumber = licenseNumber
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Client, ClientDto>();
        }
    }
}