using FluentValidation;
using Storium.Application.Commands.Products;

namespace Storium.Application.Validations.Products
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Product name is required.");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greater than zero.");
            RuleFor(p => p.Currency).NotEmpty().WithMessage("Currency is required.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("CategoryId is required.");
        }
    }
}