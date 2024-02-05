using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.AutoMapper.MappingExtensions", Version = "1.0")]

namespace BRUNOAPI.Application.Cars
{
    public static class CarDtoMappingExtensions
    {
        public static CarDto MapToCarDto(this Car projectFrom, IMapper mapper)
            => mapper.Map<CarDto>(projectFrom);

        public static List<CarDto> MapToCarDtoList(this IEnumerable<Car> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToCarDto(mapper)).ToList();
    }
}