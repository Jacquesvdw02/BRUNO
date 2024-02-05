using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Entities;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.CreateCar
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Guid>
    {
        private readonly ICarRepository _carRepository;

        [IntentManaged(Mode.Merge)]
        public CreateCarCommandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<Guid> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var entity = new Car
            {
                Colour = request.Colour,
                Make = request.Make,
                Model = request.Model,
                Registration = request.Registration,
                DailyRate = request.DailyRate,
                RentedOut = request.RentedOut,
                Mileage = request.Mileage,
                ServiceMileage = request.ServiceMileage
            };

            _carRepository.Add(entity);
            await _carRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}