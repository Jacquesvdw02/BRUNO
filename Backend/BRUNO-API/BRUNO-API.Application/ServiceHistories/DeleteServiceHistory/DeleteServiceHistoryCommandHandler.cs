using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Common.Exceptions;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories.DeleteServiceHistory
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class DeleteServiceHistoryCommandHandler : IRequestHandler<DeleteServiceHistoryCommand>
    {
        private readonly IServiceHistoryRepository _serviceHistoryRepository;

        [IntentManaged(Mode.Merge)]
        public DeleteServiceHistoryCommandHandler(IServiceHistoryRepository serviceHistoryRepository)
        {
            _serviceHistoryRepository = serviceHistoryRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task Handle(DeleteServiceHistoryCommand request, CancellationToken cancellationToken)
        {
            var serviceHistory = await _serviceHistoryRepository.FindByIdAsync(request.Id, cancellationToken);
            if (serviceHistory is null)
            {
                throw new NotFoundException($"Could not find ServiceHistory '{request.Id}'");
            }

            _serviceHistoryRepository.Remove(serviceHistory);
        }
    }
}