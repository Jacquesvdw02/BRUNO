using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.AutoMapper.MappingExtensions", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories
{
    public static class CarDTOMappingExtensions
    {
        public static CarDTO MapToCarDTO(this Car projectFrom, IMapper mapper)
            => mapper.Map<CarDTO>(projectFrom);

        public static List<CarDTO> MapToCarDTOList(this IEnumerable<Car> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToCarDTO(mapper)).ToList();
    }
}