using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.CreateCar
{
    public class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
    {
        [IntentManaged(Mode.Merge)]
        public CreateCarCommandValidator()
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

            RuleFor(v => v.Rentals)
                .NotNull();
        }
    }
}