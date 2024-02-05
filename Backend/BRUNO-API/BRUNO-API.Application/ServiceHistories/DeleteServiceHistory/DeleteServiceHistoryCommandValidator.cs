using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories.DeleteServiceHistory
{
    public class DeleteServiceHistoryCommandValidator : AbstractValidator<DeleteServiceHistoryCommand>
    {
        [IntentManaged(Mode.Merge)]
        public DeleteServiceHistoryCommandValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}