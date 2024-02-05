using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Cars.UpdateCar
{
    public class UpdateCarCommand : IRequest, ICommand
    {
        public UpdateCarCommand(Guid id,
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
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
            Transmission = transmission;
            FuelType = fuelType;
            EngineSize = engineSize;
            BodyStyle = bodyStyle;
            Drivetrain = drivetrain;
            DatePurchased = datePurchased;
            Registration = registration;
            DailyRate = dailyRate;
            RentedOut = rentedOut;
            Mileage = mileage;
            ServiceMileage = serviceMileage;
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
    }
}