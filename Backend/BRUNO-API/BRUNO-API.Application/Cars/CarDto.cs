using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.Cars
{
    public class CarDto : IMapFrom<Car>
    {
        public CarDto()
        {
            Make = null!;
            Model = null!;
            Colour = null!;
            Transmission = null!;
            FuelType = null!;
            BodyStyle = null!;
            Drivetrain = null!;
            Registration = null!;
        }

        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public double EngineSize { get; set; }
        public string BodyStyle { get; set; }
        public string Drivetrain { get; set; }
        public DateTime DatePurchased { get; set; }
        public string Registration { get; set; }
        public double DailyRate { get; set; }
        public bool RentedOut { get; set; }
        public int Mileage { get; set; }
        public int ServiceMileage { get; set; }

        public static CarDto Create(
            Guid id,
            string make,
            string model,
            int year,
            string colour,
            string transmission,
            string fuelType,
            double engineSize,
            string bodyStyle,
            string drivetrain,
            DateTime datePurchased,
            string registration,
            double dailyRate,
            bool rentedOut,
            int mileage,
            int serviceMileage)
        {
            return new CarDto
            {
                Id = id,
                Make = make,
                Model = model,
                Year = year,
                Colour = colour,
                Transmission = transmission,
                FuelType = fuelType,
                EngineSize = engineSize,
                BodyStyle = bodyStyle,
                Drivetrain = drivetrain,
                DatePurchased = datePurchased,
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