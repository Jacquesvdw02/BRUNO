using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals.DeleteRental
{
    public class DeleteRentalCommandValidator : AbstractValidator<DeleteRentalCommand>
    {
        [IntentManaged(Mode.Merge)]
        public DeleteRentalCommandValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}