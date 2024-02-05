using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Entities;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories.CreateServiceHistory
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class CreateServiceHistoryCommandHandler : IRequestHandler<CreateServiceHistoryCommand, Guid>
    {
        private readonly IServiceHistoryRepository _serviceHistoryRepository;

        [IntentManaged(Mode.Merge)]
        public CreateServiceHistoryCommandHandler(IServiceHistoryRepository serviceHistoryRepository)
        {
            _serviceHistoryRepository = serviceHistoryRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<Guid> Handle(CreateServiceHistoryCommand request, CancellationToken cancellationToken)
        {
            var serviceHistory = new ServiceHistory(
                id: Guid.NewGuid(),
                previousServiceMilage: request.PreviousServiceMilage,
                previousServiceDate: request.PreviousServiceDate,
                carId: request.CarId,
                car: new Car
                {
                    Colour = request.Car.Colour,
                    Make = request.Car.Make,
                    Model = request.Car.Model,
                    Registration = request.Car.Registration,
                    DailyRate = request.Car.DailyRate,
                    RentedOut = request.Car.RentedOut,
                    Mileage = request.Car.Mileage,
                    ServiceInterval = request.Car.ServiceInterval
                });

            _serviceHistoryRepository.Add(serviceHistory);
            await _serviceHistoryRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return serviceHistory.Id;
        }
    }
}