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
                    Make = request.Car.Make,
                    Model = request.Car.Model,
                    Year = request.Car.Year,
                    Colour = request.Car.Colour,
                    Transmission = request.Car.Transmission,
                    FuelType = request.Car.FuelType,
                    EngineSize = request.Car.EngineSize,
                    BodyStyle = request.Car.BodyStyle,
                    Drivetrain = request.Car.Drivetrain,
                    DatePurchased = request.Car.DatePurchased,
                    Registration = request.Car.Registration,
                    DailyRate = request.Car.DailyRate,
                    RentedOut = request.Car.RentedOut,
                    Mileage = request.Car.Mileage,
                    ServiceMileage = request.Car.ServiceMileage
                });

            _serviceHistoryRepository.Add(serviceHistory);
            await _serviceHistoryRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return serviceHistory.Id;
        }
    }
}