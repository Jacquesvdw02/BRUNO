using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.AutoMapper.MappingExtensions", Version = "1.0")]

namespace BRUNOAPI.Application.Cars
{
    public static class CheckServiceDtoMappingExtensions
    {
        public static CheckServiceDto MapToCheckServiceDto(this Car projectFrom, IMapper mapper)
            => mapper.Map<CheckServiceDto>(projectFrom);

        public static List<CheckServiceDto> MapToCheckServiceDtoList(this IEnumerable<Car> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToCheckServiceDto(mapper)).ToList();
    }
}