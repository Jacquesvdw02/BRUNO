using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.QueryValidator", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories.GetServiceHistories
{
    public class GetServiceHistoriesQueryValidator : AbstractValidator<GetServiceHistoriesQuery>
    {
        [IntentManaged(Mode.Merge)]
        public GetServiceHistoriesQueryValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}