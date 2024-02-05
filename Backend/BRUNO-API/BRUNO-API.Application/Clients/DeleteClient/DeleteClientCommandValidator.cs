using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Clients.DeleteClient
{
    public class DeleteClientCommandValidator : AbstractValidator<DeleteClientCommand>
    {
        [IntentManaged(Mode.Merge)]
        public DeleteClientCommandValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
        }
    }
}