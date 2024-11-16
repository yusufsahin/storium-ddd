using FluentValidation;
using Storium.Application.Commands.Products;

namespace Storium.Application.Validations.Products
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("ProductId is required.");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Product name is required.");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greater than zero.");
            RuleFor(p => p.Currency).NotEmpty().WithMessage("Currency is required.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("CategoryId is required.");
        }
    }
}