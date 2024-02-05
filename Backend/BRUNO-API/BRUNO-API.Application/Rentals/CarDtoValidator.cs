using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.FluentValidation.Dtos.DTOValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals
{
    public class CarDtoValidator : AbstractValidator<CarDto>
    {
        [IntentManaged(Mode.Merge)]
        public CarDtoValidator()
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