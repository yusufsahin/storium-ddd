using FluentValidation;
using Storium.Application.Commands.Customers;
using Storium.Infrastructure.Repositories.Interfaces;

namespace Storium.Application.Validations
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator(ICustomerRepository customerRepository)
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(c => c.Email)
                .EmailAddress().WithMessage("Invalid email format.")
                .MustAsync(async (email, _) => !await customerRepository.ExistsByEmailAsync(email))
                .WithMessage("Email already exists.");
            RuleFor(c => c.Address).NotNull().WithMessage("Address is required.");
        }
    }
}
