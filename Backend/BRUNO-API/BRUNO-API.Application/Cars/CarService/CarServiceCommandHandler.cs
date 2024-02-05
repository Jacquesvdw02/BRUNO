using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Application.Interfaces.Cars;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandHandler", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.CarService
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class CarServiceCommandHandler : IRequestHandler<CarServiceCommand, bool>
    {
        private readonly ICarService _carService;
        [IntentManaged(Mode.Merge)]
        public CarServiceCommandHandler(ICarService carService)
        {
            _carService = carService;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public async Task<bool> Handle(CarServiceCommand request, CancellationToken cancellationToken)
        {
            return await _carService.CheckServiceRequired(request.Car, cancellationToken);
        }
    }
}