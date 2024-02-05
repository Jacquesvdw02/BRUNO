using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.AutoMapper.MappingExtensions", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals
{
    public static class RentalDtoMappingExtensions
    {
        public static RentalDto MapToRentalDto(this Rental projectFrom, IMapper mapper)
            => mapper.Map<RentalDto>(projectFrom);

        public static List<RentalDto> MapToRentalDtoList(this IEnumerable<Rental> projectFrom, IMapper mapper)
            => projectFrom.Select(x => x.MapToRentalDto(mapper)).ToList();
    }
}