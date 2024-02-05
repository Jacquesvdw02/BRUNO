using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Common.Exceptions;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals.UpdateRental
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class UpdateRentalCommandHandler : IRequestHandler<UpdateRentalCommand>
    {
        private readonly IRentalRepository _rentalRepository;

        [IntentManaged(Mode.Merge)]
        public UpdateRentalCommandHandler(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task Handle(UpdateRentalCommand request, CancellationToken cancellationToken)
        {
            var rental = await _rentalRepository.FindByIdAsync(request.Id, cancellationToken);
            if (rental is null)
            {
                throw new NotFoundException($"Could not find Rental '{request.Id}'");
            }

            rental.ToDate = request.ToDate;
            rental.FromDate = request.FromDate;
            rental.CarId = request.CarId;
            rental.ClientId = request.ClientId;
        }
    }
}