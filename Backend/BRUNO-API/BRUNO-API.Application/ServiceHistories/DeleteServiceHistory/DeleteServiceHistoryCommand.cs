using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories.DeleteServiceHistory
{
    public class DeleteServiceHistoryCommand : IRequest, ICommand
    {
        public DeleteServiceHistoryCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}