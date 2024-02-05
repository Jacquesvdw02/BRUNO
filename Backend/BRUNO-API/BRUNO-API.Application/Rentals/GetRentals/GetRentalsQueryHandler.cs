using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryHandler", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals.GetRentals
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class GetRentalsQueryHandler : IRequestHandler<GetRentalsQuery, List<RentalDto>>
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IMapper _mapper;

        [IntentManaged(Mode.Merge)]
        public GetRentalsQueryHandler(IRentalRepository rentalRepository, IMapper mapper)
        {
            _rentalRepository = rentalRepository;
            _mapper = mapper;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<List<RentalDto>> Handle(GetRentalsQuery request, CancellationToken cancellationToken)
        {
            var rentals = await _rentalRepository.FindAllAsync(cancellationToken);
            return rentals.MapToRentalDtoList(_mapper);
        }
    }
}