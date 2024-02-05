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
                },
                client: new Client
                {
                    FirstName = request.Client.FirstName,
                    LastName = request.Client.LastName,
                    Email = request.Client.Email,
                    Phone = request.Client.Phone,
                    Address = request.Client.Address,
                    City = request.Client.City,
                    Province = request.Client.Province,
                    LicenseNumber = request.Client.LicenseNumber,
                    PostalCode = request.Client.PostalCode,
                    DateJoined = request.Client.DateJoined
                });

            _rentalRepository.Add(rental);
            await _rentalRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return rental.Id;
        }
    }
}