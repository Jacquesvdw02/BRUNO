using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryModels", Version = "1.0")]

namespace BRUNOAPI.Application.Clients.GetClientById
{
    public class GetClientByIdQuery : IRequest<ClientDto>, IQuery
    {
        public GetClientByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}