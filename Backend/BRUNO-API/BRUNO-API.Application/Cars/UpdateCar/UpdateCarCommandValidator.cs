using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.UpdateCar
{
    public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
    {
        [IntentManaged(Mode.Merge)]
        public UpdateCarCommandValidator()
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