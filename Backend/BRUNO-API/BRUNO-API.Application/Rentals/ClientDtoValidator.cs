using FluentValidation;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.FluentValidation.Dtos.DTOValidator", Version = "2.0")]

namespace BRUNOAPI.Application.Rentals
{
    public class ClientDtoValidator : AbstractValidator<ClientDto>
    {
        [IntentManaged(Mode.Merge)]
        public ClientDtoValidator()
        {
            ConfigureValidationRules();
        }

        private void ConfigureValidationRules()
        {
            RuleFor(v => v.FirstName)
                .NotNull();

            RuleFor(v => v.LastName)
                .NotNull();

            RuleFor(v => v.Email)
                .NotNull();

            RuleFor(v => v.Phone)
                .NotNull();

            RuleFor(v => v.Address)
                .NotNull();

            RuleFor(v => v.City)
                .NotNull();

            RuleFor(v => v.Province)
                .NotNull();

            RuleFor(v => v.LicenseNumber)
                .NotNull();

            RuleFor(v => v.PostalCode)
                .NotNull();
        }
    }
}