using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.FluentValidation.Dtos.DTOValidator", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories
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
            RuleFor(v => v.Make)
                .NotNull();

            RuleFor(v => v.Model)
                .NotNull();

            RuleFor(v => v.Colour)
                .NotNull();

            RuleFor(v => v.Transmission)
                .NotNull();

            RuleFor(v => v.FuelType)
                .NotNull();

            RuleFor(v => v.BodyStyle)
                .NotNull();

            RuleFor(v => v.Drivetrain)
                .NotNull();

            RuleFor(v => v.Registration)
                .NotNull();
        }
    }
}