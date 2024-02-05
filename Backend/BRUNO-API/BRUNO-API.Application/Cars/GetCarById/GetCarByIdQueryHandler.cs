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

namespace BRUNOAPI.Application.Cars.GetCarById
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, CarDto>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        [IntentManaged(Mode.Merge)]
        public GetCarByIdQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<CarDto> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var car = await _carRepository.FindByIdAsync(request.Id, cancellationToken);
            if (car is null)
            {
                throw new NotFoundException($"Could not find Car '{request.Id}'");
            }
            return car.MapToCarDto(_mapper);
        }
    }
}