using System.Collections.Generic;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryModels", Version = "1.0")]

namespace BRUNOAPI.Application.Cars.GetCars
{
    public class GetCarsQuery : IRequest<List<CarDto>>, IQuery
    {
        public GetCarsQuery()
        {
        }
    }
}