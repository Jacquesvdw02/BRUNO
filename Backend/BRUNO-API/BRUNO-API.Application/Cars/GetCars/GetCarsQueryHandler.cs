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

namespace BRUNOAPI.Application.Cars.GetCars
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, List<CarDto>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        [IntentManaged(Mode.Merge)]
        public GetCarsQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<List<CarDto>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
            var cars = await _carRepository.FindAllAsync(cancellationToken);
            return cars.MapToCarDtoList(_mapper);
        }
    }
}