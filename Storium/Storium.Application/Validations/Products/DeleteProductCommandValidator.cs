using FluentValidation;
using Storium.Application.Commands.Products;

namespace Storium.Application.Validations.Products
{
    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("ProductId is required.");
        }
    }
}