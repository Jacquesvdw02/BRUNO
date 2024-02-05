using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Domain.Entities;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.Clients.CreateClient
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Guid>
    {
        private readonly IClientRepository _clientRepository;

        [IntentManaged(Mode.Merge)]
        public CreateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Client(
                id: Guid.NewGuid(),
                firstName: request.FirstName,
                lastName: request.LastName,
                email: request.Email,
                phone: request.Phone,
                address: request.Address,
                city: request.City,
                province: request.Province,
                licenseNumber: request.LicenseNumber,
                postalCode: request.PostalCode,
                dateJoined: request.DateJoined);

            _clientRepository.Add(client);
            await _clientRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return client.Id;
        }
    }
}