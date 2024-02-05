using System;
using System.Collections.Generic;
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
            var car = new Car(
                id: request.Id,
                colour: request.Colour,
                make: request.Make,
                model: request.Model,
                registration: request.Registration,
                dailyRate: request.DailyRate,
                rentedOut: request.RentedOut,
                rentals: new List<Rental>());
            //.Select(x => new Rental
            //(
            //    ToDate: x.ToDate,
            //    FromDate: x.FromDate
            //))

            _carRepository.Add(car);
            await _carRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return car.Id;
        }
    }
}