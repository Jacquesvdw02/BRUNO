using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.FluentValidation.Dtos.DTOValidator", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories
{
    public class CarDTOValidator : AbstractValidator<CarDTO>
    {
        [IntentManaged(Mode.Merge)]
        public CarDTOValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
            RuleFor(v => v.Colour)
                .NotNull();

            RuleFor(v => v.Make)
                .NotNull();

            RuleFor(v => v.Model)
                .NotNull();

            RuleFor(v => v.Registration)
                .NotNull();
        }
    }
}