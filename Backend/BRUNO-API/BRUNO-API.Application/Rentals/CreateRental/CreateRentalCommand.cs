using System;
using BRUNOAPI.Application.Cars;
using BRUNOAPI.Application.Clients;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals.CreateRental
{
    public class CreateRentalCommand : IRequest<Guid>, ICommand
    {
        public CreateRentalCommand(Guid id,
            DateTime toDate,
            DateTime fromDate,
            Guid carId,
            Guid clientId,
            CarDto car,
            Clients.ClientDto client)
        {
            Id = id;
            ToDate = toDate;
            FromDate = fromDate;
            CarId = carId;
            ClientId = clientId;
            Car = car;
            Client = client;
        }

        public Guid Id { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        public Guid CarId { get; set; }
        public Guid ClientId { get; set; }
        public CarDto Car { get; set; }
        public Clients.ClientDto Client { get; set; }
    }
}