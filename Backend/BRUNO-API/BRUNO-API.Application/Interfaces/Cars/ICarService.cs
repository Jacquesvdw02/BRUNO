using System;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Application.Cars;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.Contracts.ServiceContract", Version = "1.0")]

namespace BRUNOAPI.Application.Interfaces.Cars
{
    public interface ICarService : IDisposable
    {
        Task<bool> CheckServiceRequired(CheckServiceDto car, CancellationToken cancellationToken = default);
    }
}