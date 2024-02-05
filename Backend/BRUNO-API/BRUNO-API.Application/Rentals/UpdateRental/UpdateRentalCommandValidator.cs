using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals.UpdateRental
{
    public class UpdateRentalCommandValidator : AbstractValidator<UpdateRentalCommand>
    {
        [IntentManaged(Mode.Merge)]
        public UpdateRentalCommandValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}