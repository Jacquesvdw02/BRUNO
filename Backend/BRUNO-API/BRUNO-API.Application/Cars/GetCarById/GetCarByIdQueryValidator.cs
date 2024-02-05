using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.QueryValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Cars.GetCarById
{
    public class GetCarByIdQueryValidator : AbstractValidator<GetCarByIdQuery>
    {
        [IntentManaged(Mode.Merge)]
        public GetCarByIdQueryValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}