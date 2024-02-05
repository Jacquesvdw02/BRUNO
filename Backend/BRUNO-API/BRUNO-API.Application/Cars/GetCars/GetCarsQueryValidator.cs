using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.QueryValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.GetCars
{
    public class GetCarsQueryValidator : AbstractValidator<GetCarsQuery>
    {
        [IntentManaged(Mode.Merge)]
        public GetCarsQueryValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}