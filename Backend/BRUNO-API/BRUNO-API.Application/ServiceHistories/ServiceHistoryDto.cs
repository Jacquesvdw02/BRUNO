using System;
using AutoMapper;
using BRUNOAPI.Application.Common.Mappings;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Dtos.DtoModel", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories
{
    public class ServiceHistoryDto : IMapFrom<ServiceHistory>
    {
        public ServiceHistoryDto()
        {
        }

        public Guid Id { get; set; }
        public int PreviousServiceMilage { get; set; }
        public DateTime PreviousServiceDate { get; set; }
        public Guid CarId { get; set; }

        public static ServiceHistoryDto Create(Guid id, int previousServiceMilage, DateTime previousServiceDate, Guid carId)
        {
            return new ServiceHistoryDto
            {
                Id = id,
                PreviousServiceMilage = previousServiceMilage,
                PreviousServiceDate = previousServiceDate,
                CarId = carId
            };
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ServiceHistory, ServiceHistoryDto>();
        }
    }
}