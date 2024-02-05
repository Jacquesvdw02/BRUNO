using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.Cars
{
    public class RentalDto : IMapFrom<Rental>
    {
        public RentalDto()
        {
        }

        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }

        public static RentalDto Create(Guid id, Guid carId, Guid clientId, DateTime toDate, DateTime fromDate)
        {
            return new RentalDto
            {
                Id = id,
                CarId = carId,
                ClientId = clientId,
                ToDate = toDate,
                FromDate = fromDate
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Rental, RentalDto>();
        }
    }
}