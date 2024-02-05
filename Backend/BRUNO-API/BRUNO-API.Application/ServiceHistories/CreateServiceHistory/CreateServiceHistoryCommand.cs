using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories.CreateServiceHistory
{
    public class CreateServiceHistoryCommand : IRequest<Guid>, ICommand
    {
        public CreateServiceHistoryCommand(Guid id,
            int previousServiceMilage,
            DateTime previousServiceDate,
            Guid carId,
            CarDTO car)
        {
            Id = id;
            PreviousServiceMilage = previousServiceMilage;
            PreviousServiceDate = previousServiceDate;
            CarId = carId;
            Car = car;
        }

        public Guid Id { get; set; }
        public int PreviousServiceMilage { get; set; }
        public DateTime PreviousServiceDate { get; set; }
        public Guid CarId { get; set; }
        public CarDTO Car { get; set; }
    }
}