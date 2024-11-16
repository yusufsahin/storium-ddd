using FluentValidation;
using Storium.Application.DTOs;

namespace Storium.Application.Validations.ValueObjects
{
    public class MoneyDtoValidator : AbstractValidator<MoneyDto>
    {
        public MoneyDtoValidator()
        {
            RuleFor(m => m.Amount).GreaterThanOrEqualTo(0).WithMessage("Amount must be non-negative.");
            RuleFor(m => m.Currency)
                .NotEmpty().WithMessage("Currency is required.")
                .Length(3).WithMessage("Currency must be a 3-letter ISO 4217 code.");
        }
    }
}