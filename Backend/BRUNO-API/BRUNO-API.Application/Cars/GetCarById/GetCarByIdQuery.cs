using System;
using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.QueryModels", Version = "1.0")]

namespace BRUNOAPI.Application.Cars.GetCarById
{
    public class GetCarByIdQuery : IRequest<CarDto>, IQuery
    {
        public GetCarByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}