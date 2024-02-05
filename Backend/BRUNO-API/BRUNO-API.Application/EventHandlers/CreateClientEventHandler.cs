using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Application.Common.Models;
using BRUNOAPI.Domain.Events;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.MediatR.DomainEvents.DefaultDomainEventHandler", Version = "1.0")]

namespace BRUNOAPI.Application.EventHandlers
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class CreateClientEventHandler : INotificationHandler<DomainEventNotification<CreateClientEvent>>
    {
        [IntentManaged(Mode.Merge)]
        public CreateClientEventHandler()
        {
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public async Task Handle(
            DomainEventNotification<CreateClientEvent> notification,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Implement your handler logic here...");
        }
    }
}