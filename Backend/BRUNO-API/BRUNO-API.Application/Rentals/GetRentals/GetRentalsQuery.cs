using System.Collections.Generic;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryModels", Version = "1.0")]

namespace BRUNOAPI.Application.Rentals.GetRentals
{
    public class GetRentalsQuery : IRequest<List<RentalDto>>, IQuery
    {
        public GetRentalsQuery()
        {
        }
    }
}