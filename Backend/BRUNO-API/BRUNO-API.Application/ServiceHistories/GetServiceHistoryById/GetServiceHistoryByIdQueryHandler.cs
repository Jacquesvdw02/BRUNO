using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BRUNOAPI.Domain.Common.Exceptions;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryHandler", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories.GetServiceHistoryById
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class GetServiceHistoryByIdQueryHandler : IRequestHandler<GetServiceHistoryByIdQuery, ServiceHistoryDto>
    {
        private readonly IServiceHistoryRepository _serviceHistoryRepository;
        private readonly IMapper _mapper;

        [IntentManaged(Mode.Merge)]
        public GetServiceHistoryByIdQueryHandler(IServiceHistoryRepository serviceHistoryRepository, IMapper mapper)
        {
            _serviceHistoryRepository = serviceHistoryRepository;
            _mapper = mapper;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<ServiceHistoryDto> Handle(
            GetServiceHistoryByIdQuery request,
            CancellationToken cancellationToken)
        {
            var serviceHistory = await _serviceHistoryRepository.FindByIdAsync(request.Id, cancellationToken);
            if (serviceHistory is null)
            {
                throw new NotFoundException($"Could not find ServiceHistory '{request.Id}'");
            }
            return serviceHistory.MapToServiceHistoryDto(_mapper);
        }
    }
}