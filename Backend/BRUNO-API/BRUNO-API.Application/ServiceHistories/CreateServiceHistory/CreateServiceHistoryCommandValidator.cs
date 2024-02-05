using BRUNOAPI.Application.Common.Validation;
using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.FluentValidation.CommandValidator", Version = "2.0")]

namespace BRUNOAPI.Application.ServiceHistories.CreateServiceHistory
{
    public class CreateServiceHistoryCommandValidator : AbstractValidator<CreateServiceHistoryCommand>
    {
        [IntentManaged(Mode.Merge)]
        public CreateServiceHistoryCommandValidator(IValidatorProvider provider)
        {
            ConfigureValidationRules(provider);
        }

        private void ConfigureValidationRules(IValidatorProvider provider)
        {
            RuleFor(v => v.Car)
                .NotNull()
                .SetValidator(provider.GetValidator<CarDto>()!);
        }
    }
}