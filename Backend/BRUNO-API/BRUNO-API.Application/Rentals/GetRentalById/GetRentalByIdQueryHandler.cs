using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BRUNOAPI.Domain.Common.Exceptions;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryHandler", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals.GetRentalById
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class GetRentalByIdQueryHandler : IRequestHandler<GetRentalByIdQuery, RentalDto>
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IMapper _mapper;

        [IntentManaged(Mode.Merge)]
        public GetRentalByIdQueryHandler(IRentalRepository rentalRepository, IMapper mapper)
        {
            _rentalRepository = rentalRepository;
            _mapper = mapper;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<RentalDto> Handle(GetRentalByIdQuery request, CancellationToken cancellationToken)
        {
            var rental = await _rentalRepository.FindByIdAsync(request.Id, cancellationToken);
            if (rental is null)
            {
                throw new NotFoundException($"Could not find Rental '{request.Id}'");
            }
            return rental.MapToRentalDto(_mapper);
        }
    }
}