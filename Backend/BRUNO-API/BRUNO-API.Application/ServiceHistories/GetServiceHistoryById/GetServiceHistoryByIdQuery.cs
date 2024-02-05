using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryModels", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories.GetServiceHistoryById
{
    public class GetServiceHistoryByIdQuery : IRequest<ServiceHistoryDto>, IQuery
    {
        public GetServiceHistoryByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}