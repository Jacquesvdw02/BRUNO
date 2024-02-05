using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals.UpdateRental
{
    public class UpdateRentalCommand : IRequest, ICommand
    {
        public UpdateRentalCommand(Guid id, DateTime toDate, DateTime fromDate, Guid carId, Guid clientId)
        {
            Id = id;
            ToDate = toDate;
            FromDate = fromDate;
            CarId = carId;
            ClientId = clientId;
        }

        public Guid Id { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        public Guid CarId { get; set; }
        public Guid ClientId { get; set; }
    }
}