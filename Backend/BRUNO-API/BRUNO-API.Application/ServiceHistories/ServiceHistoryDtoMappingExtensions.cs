using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.AutoMapper.MappingExtensions", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories
{
    public static class ServiceHistoryDtoMappingExtensions
    {
        public static ServiceHistoryDto MapToServiceHistoryDto(this ServiceHistory projectFrom, IMapper mapper)
            => mapper.Map<ServiceHistoryDto>(projectFrom);

        public static List<ServiceHistoryDto> MapToServiceHistoryDtoList(this IEnumerable<ServiceHistory> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToServiceHistoryDto(mapper)).ToList();
    }
}