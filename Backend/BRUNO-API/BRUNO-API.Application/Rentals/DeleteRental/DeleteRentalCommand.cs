using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals.DeleteRental
{
    public class DeleteRentalCommand : IRequest, ICommand
    {
        public DeleteRentalCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}