using BRUNOAPI.Application.Common.Interfaces;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BRUNOAPI.Application.Cars.CarService
{
    public class CarServiceCommand : IRequest<bool>, ICommand
    {
        public CarServiceCommand(CheckServiceDto car)
        {
            Car = car;
        }

        public CheckServiceDto Car { get; set; }
    }
}