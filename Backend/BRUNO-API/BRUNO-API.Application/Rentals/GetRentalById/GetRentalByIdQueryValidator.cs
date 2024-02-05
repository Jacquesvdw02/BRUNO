using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.QueryValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals.GetRentalById
{
    public class GetRentalByIdQueryValidator : AbstractValidator<GetRentalByIdQuery>
    {
        [IntentManaged(Mode.Merge)]
        public GetRentalByIdQueryValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}