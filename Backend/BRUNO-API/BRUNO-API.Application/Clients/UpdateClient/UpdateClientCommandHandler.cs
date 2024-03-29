using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Common.Exceptions;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.Clients.UpdateClient
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand>
    {
        private readonly IClientRepository _clientRepository;

        [IntentManaged(Mode.Merge)]
        public UpdateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.FindByIdAsync(request.Id, cancellationToken);
            if (client is null)
            {
                throw new NotFoundException($"Could not find Client '{request.Id}'");
            }

            client.FirstName = request.FirstName;
            client.LastName = request.LastName;
            client.Email = request.Email;
            client.Phone = request.Phone;
            client.Address = request.Address;
            client.City = request.City;
            client.Province = request.Province;
            client.LicenseNumber = request.LicenseNumber;
            client.PostalCode = request.PostalCode;
            client.DateJoined = request.DateJoined;
        }
    }
}