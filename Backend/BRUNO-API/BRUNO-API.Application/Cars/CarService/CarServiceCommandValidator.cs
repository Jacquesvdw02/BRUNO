using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.CarService
{
    public class CarServiceCommandValidator : AbstractValidator<CarServiceCommand>
    {
        [IntentManaged(Mode.Merge)]
        public CarServiceCommandValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
            RuleFor(v => v.Car)
                .NotNull();
        }
    }
}