using System;
using System.Collections.Generic;
using BRUNOAPI.Domain.Common;
using BRUNOAPI.Domain.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.DomainEvents.DomainEvent", Version = "1.0")]

namespace BRUNOAPI.Domain.Events
{
    public class CreateRentalEvent : DomainEvent
    {
        public CreateRentalEvent(Rental newRental)
        {
            NewRental = newRental;
        }

        public Rental NewRental { get; }
    }
}