using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories
{
    public class CarDTO : IMapFrom<Car>
    {
        public CarDTO()
        {
            Colour = null!;
            Make = null!;
            Model = null!;
            Registration = null!;
        }

        public Guid Id { get; set; }
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public double DailyRate { get; set; }
        public bool RentedOut { get; set; }
        public int Mileage { get; set; }
        public int ServiceInterval { get; set; }

        public static CarDTO Create(
            Guid id,
            string colour,
            string make,
            string model,
            string registration,
            double dailyRate,
            bool rentedOut,
            int mileage,
            int serviceInterval)
        {
            return new CarDTO
            {
                Id = id,
                Colour = colour,
                Make = make,
                Model = model,
                Registration = registration,
                DailyRate = dailyRate,
                RentedOut = rentedOut,
                Mileage = mileage,
                ServiceInterval = serviceInterval
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarDTO>()
                .ForMember(d => d.ServiceInterval, opt => opt.MapFrom(src => src.ServiceMileage));
        }
    }
}