using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BRUNOAPI.Application.Cars;
using BRUNOAPI.Application.Interfaces.Cars;
using BRUNOAPI.Domain.Entities;
using BRUNOAPI.Domain.Repositories;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.ServiceImplementations.ServiceImplementation", Version = "1.0")]

namespace BRUNOAPI.Application.Implementation.Cars
{
    [IntentManaged(Mode.Merge)]
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IServiceHistoryRepository _serviceHistoryRepository;
        [IntentManaged(Mode.Merge)]
        public CarService(ICarRepository carRepository, IServiceHistoryRepository serviceHistory)
        {
            _carRepository = carRepository;
            _serviceHistoryRepository = serviceHistory;
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public async Task<bool> CheckServiceRequired(CheckServiceDto car, CancellationToken cancellationToken = default)
        {
            var SelectedCar = await _carRepository.FindByIdAsync(car.Id);
            var LastMileage = await _serviceHistoryRepository.FindAsync(x => x.CarId == SelectedCar.Id);
            if (LastMileage != null)
            {
                if (SelectedCar.Mileage >= SelectedCar.ServiceMileage + LastMileage.PreviousServiceMilage)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            if (LastMileage == null)
            {
                if (SelectedCar.Mileage <= SelectedCar.ServiceMileage)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
            return false;
        }

        public void Dispose()
        {
        }
    }
}