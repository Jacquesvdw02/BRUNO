using BRUNOAPI.Application.Cars;
using BRUNOAPI.Application.Clients;
using BRUNOAPI.Application.Common.Validation;
using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals.CreateRental
{
    public class CreateRentalCommandValidator : AbstractValidator<CreateRentalCommand>
    {
        [IntentManaged(Mode.Merge)]
        public CreateRentalCommandValidator(IValidatorProvider provider)
        {
            ConfigureValidationRules(provider);
        }

        private void ConfigureValidationRules(IValidatorProvider provider)
        {
            RuleFor(v => v.Car)
                .NotNull()
                .SetValidator(provider.GetValidator<CarDto>()!);

            RuleFor(v => v.Client)
                .NotNull()
                .SetValidator(provider.GetValidator<Clients.ClientDto>()!);
        }
    }
}