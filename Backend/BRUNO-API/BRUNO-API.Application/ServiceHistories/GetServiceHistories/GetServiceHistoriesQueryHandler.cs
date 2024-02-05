using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryHandler", Version = "1.0")]

namespace BRUNOAPI.Application.ServiceHistories.GetServiceHistories
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class GetServiceHistoriesQueryHandler : IRequestHandler<GetServiceHistoriesQuery, List<ServiceHistoryDto>>
    {
        private readonly IServiceHistoryRepository _serviceHistoryRepository;
        private readonly IMapper _mapper;

        [IntentManaged(Mode.Merge)]
        public GetServiceHistoriesQueryHandler(IServiceHistoryRepository serviceHistoryRepository, IMapper mapper)
        {
            _serviceHistoryRepository = serviceHistoryRepository;
            _mapper = mapper;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Fully)]
        public async Task<List<ServiceHistoryDto>> Handle(
            GetServiceHistoriesQuery request,
            CancellationToken cancellationToken)
        {
            var serviceHistories = await _serviceHistoryRepository.FindAllAsync(cancellationToken);
            return serviceHistories.MapToServiceHistoryDtoList(_mapper);
        }
    }
}