using System;
using System.Collections.Generic;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Cars.CreateCar
{
    public class CreateCarCommand : IRequest<Guid>, ICommand
    {
        public CreateCarCommand(Guid id,
            string colour,
            string make,
            string model,
            string registration,
            double dailyRate,
            bool rentedOut,
            List<RentalDto> rentals)
        {
            Id = id;
            Colour = colour;
            Make = make;
            Model = model;
            Registration = registration;
            DailyRate = dailyRate;
            RentedOut = rentedOut;
            Rentals = rentals;
        }

        public Guid Id { get; set; }
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public double DailyRate { get; set; }
        public bool RentedOut { get; set; }
        public List<RentalDto> Rentals { get; set; }
    }
}