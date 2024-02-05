using System;
using System.Collections.Generic;
using BRUNOAPI.Domain.Common;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.DomainEvents.DomainEvent", Version = "1.0")]

namespace BRUNOAPI.Domain.Events
{
    public class CreateClientEvent : DomainEvent
    {
        public CreateClientEvent(Client newClient)
        {
            NewClient = newClient;
        }

        public Client NewClient { get; }
    }
}