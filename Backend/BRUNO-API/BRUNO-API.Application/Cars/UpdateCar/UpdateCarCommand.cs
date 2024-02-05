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
    }
}