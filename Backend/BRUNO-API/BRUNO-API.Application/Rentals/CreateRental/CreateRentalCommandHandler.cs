using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Entities;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals.CreateRental
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class CreateRentalCommandHandler : IRequestHandler<CreateRentalCommand, Guid>
    {
        private readonly IRentalRepository _rentalRepository;

        [IntentManaged(Mode.Merge)]
        public CreateRentalCommandHandler(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<Guid> Handle(CreateRentalCommand request, CancellationToken cancellationToken)
        {
            var rental = new Rental(
                id: Guid.NewGuid(),
                toDate: request.ToDate,
                fromDate: request.FromDate,
                carId: request.CarId,
                clientId: request.ClientId,
                car: new Car
                {
                    Colour = request.Car.Colour,
                    Make = request.Car.Make,
                    Model = request.Car.Model,
                    Registration = request.Car.Registration,
                    DailyRate = request.Car.DailyRate,
                    RentedOut = request.Car.RentedOut,
                    Mileage = request.Car.Mileage,
                    ServiceMileage = request.Car.ServiceMileage
                },
                client: new Client
                {
                    ClientName = request.Client.ClientName,
                    Phone = request.Client.Phone,
                    Email = request.Client.Email,
                    Address = request.Client.Address,
                    LicenseNumber = request.Client.LicenseNumber
                });

            _rentalRepository.Add(rental);
            await _rentalRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return rental.Id;
        }
    }
}