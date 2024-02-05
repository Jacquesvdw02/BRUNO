using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.Cars
{
    public class CheckServiceDto : IMapFrom<Car>
    {
        public CheckServiceDto()
        {
        }

        public Guid Id { get; set; }
        public int Mileage { get; set; }
        public int ServiceMileage { get; set; }

        public static CheckServiceDto Create(Guid id, int mileage, int serviceMileage)
        {
            return new CheckServiceDto
            {
                Id = id,
                Mileage = mileage,
                ServiceMileage = serviceMileage
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CheckServiceDto>();
        }
    }
}