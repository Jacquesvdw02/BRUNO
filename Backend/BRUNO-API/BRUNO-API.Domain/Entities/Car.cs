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
            string colour,
            string make,
            string model,
            string registration,
            double dailyRate,
            bool rentedOut,
            int mileage,
            int serviceMileage)
        {
            Id = id;
            Colour = colour;
            Make = make;
            Model = model;
            Registration = registration;
            DailyRate = dailyRate;
            RentedOut = rentedOut;
            Mileage = mileage;
            ServiceMileage = serviceMileage;
            //ServiceInterval = serviceInterval;
            ServiceMileage = serviceMileage;
            //DomainEvents.Add(new CreateCarEvent(this));
        }

        public Car()
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

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}