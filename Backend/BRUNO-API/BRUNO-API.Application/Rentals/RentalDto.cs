using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals
{
    public class RentalDto : IMapFrom<Rental>
    {
        public RentalDto()
        {
        }

        public Guid Id { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        public Guid CarId { get; set; }
        public Guid ClientId { get; set; }

        public static RentalDto Create(Guid id, DateTime toDate, DateTime fromDate, Guid carId, Guid clientId)
        {
            return new RentalDto
            {
                Id = id,
                ToDate = toDate,
                FromDate = fromDate,
                CarId = carId,
                ClientId = clientId
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Rental, RentalDto>();
        }
    }
}