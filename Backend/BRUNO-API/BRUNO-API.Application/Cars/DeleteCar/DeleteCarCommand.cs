using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Cars.DeleteCar
{
    public class DeleteCarCommand : IRequest, ICommand
    {
        public DeleteCarCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}