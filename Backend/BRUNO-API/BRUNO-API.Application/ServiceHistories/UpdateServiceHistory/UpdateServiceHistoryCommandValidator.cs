using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories.UpdateServiceHistory
{
    public class UpdateServiceHistoryCommandValidator : AbstractValidator<UpdateServiceHistoryCommand>
    {
        [IntentManaged(Mode.Merge)]
        public UpdateServiceHistoryCommandValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}