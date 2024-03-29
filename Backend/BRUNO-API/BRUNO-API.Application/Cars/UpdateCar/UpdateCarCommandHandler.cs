using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Common.Exceptions;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.UpdateCar
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        private readonly ICarRepository _carRepository;

        [IntentManaged(Mode.Merge)]
        public UpdateCarCommandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var car = await _carRepository.FindByIdAsync(request.Id, cancellationToken);
            if (car is null)
            {
                throw new NotFoundException($"Could not find Car '{request.Id}'");
            }

            car.Make = request.Make;
            car.Model = request.Model;
            car.Year = request.Year;
            car.Colour = request.Colour;
            car.Transmission = request.Transmission;
            car.FuelType = request.FuelType;
            car.EngineSize = request.EngineSize;
            car.BodyStyle = request.BodyStyle;
            car.Drivetrain = request.Drivetrain;
            car.DatePurchased = request.DatePurchased;
            car.Registration = request.Registration;
            car.DailyRate = request.DailyRate;
            car.RentedOut = request.RentedOut;
            car.Mileage = request.Mileage;
            car.ServiceMileage = request.ServiceMileage;
        }
    }
}