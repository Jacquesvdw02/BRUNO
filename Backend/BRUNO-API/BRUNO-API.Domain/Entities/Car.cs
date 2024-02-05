using System;
using System.Collections.Generic;
using BRUNOAPI.Domain.Common;
//using BRUNOAPI.Domain.Events;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("Intent.Entities.DomainEntity", Version = "2.0")]

namespace BRUNOAPI.Domain.Entities
{
    public class Car : IHasDomainEvent
    {
        public Car(Guid id,
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
            Colour = colour;
            Transmission = transmission;
            FuelType = fuelType;
            EngineSize = engineSize;
            BodyStyle = bodyStyle;
            Drivetrain = drivetrain;
            DatePurchased = datePurchased;
            Make = make;
            Model = model;
            Year = year;
            Registration = registration;
            DailyRate = dailyRate;
            RentedOut = rentedOut;
            Mileage = mileage;
            ServiceMileage = serviceMileage;
        }

        public Car()
        {
        }

        public Guid Id { get; set; }

        public string Colour { get; set; }

        public string Transmission { get; set; }

        public string FuelType { get; set; }

        public double EngineSize { get; set; }

        public string BodyStyle { get; set; }

        public string Drivetrain { get; set; }

        public DateTime DatePurchased { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Registration { get; set; }

        public double DailyRate { get; set; }

        public bool RentedOut { get; set; }

        public int Mileage { get; set; }

        public int ServiceMileage { get; set; }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}