using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.QueryValidator", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories.GetServiceHistoryById
{
    public class GetServiceHistoryByIdQueryValidator : AbstractValidator<GetServiceHistoryByIdQuery>
    {
        [IntentManaged(Mode.Merge)]
        public GetServiceHistoryByIdQueryValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}