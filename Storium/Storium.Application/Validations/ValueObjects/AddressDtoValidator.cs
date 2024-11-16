using FluentValidation;
using Storium.Application.DTOs;

namespace Storium.Application.Validations.ValueObjects
{
    public class AddressDtoValidator : AbstractValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            RuleFor(a => a.Street).NotEmpty().WithMessage("Street is required.")
                                   .MaximumLength(100).WithMessage("Street cannot exceed 100 characters.");
            RuleFor(a => a.City).NotEmpty().WithMessage("City is required.")
                                 .MaximumLength(50).WithMessage("City cannot exceed 50 characters.");
            RuleFor(a => a.State).MaximumLength(50).WithMessage("State cannot exceed 50 characters.");
            RuleFor(a => a.PostalCode).NotEmpty().WithMessage("PostalCode is required.")
                                      .Matches(@"^\d{5}(-\d{4})?$").WithMessage("Invalid PostalCode format.");
            RuleFor(a => a.Country).NotEmpty().WithMessage("Country is required.")
                                    .MaximumLength(50).WithMessage("Country cannot exceed 50 characters.");
        }
    }
}