using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.QueryValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals.GetRentals
{
    public class GetRentalsQueryValidator : AbstractValidator<GetRentalsQuery>
    {
        [IntentManaged(Mode.Merge)]
        public GetRentalsQueryValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}