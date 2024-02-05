using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals
{
    public class CarDto : IMapFrom<Car>
    {
        public CarDto()
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
        public int ServiceMileage { get; set; }

        public static CarDto Create(
            Guid id,
            string colour,
            string make,
            string model,
            string registration,
            double dailyRate,
            bool rentedOut,
            int mileage,
            int serviceMileage)
        {
            return new CarDto
            {
                Id = id,
                Colour = colour,
                Make = make,
                Model = model,
                Registration = registration,
                DailyRate = dailyRate,
                RentedOut = rentedOut,
                Mileage = mileage,
                ServiceMileage = serviceMileage
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarDto>();
        }
    }
}