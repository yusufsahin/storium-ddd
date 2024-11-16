using FluentValidation;
using Storium.Application.Commands.Customers;

namespace Storium.Application.Validations.Customers
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(c => c.Email).EmailAddress().WithMessage("Invalid email address.");
            RuleFor(c => c.Address).NotNull().WithMessage("Address is required.");
        }
    }
}