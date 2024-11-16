using FluentValidation;
using Storium.Application.Commands.Categories;

namespace Storium.Application.Validations.Categories
{
    public class DeleteCategoryCommandValidator : AbstractValidator<DeleteCategoryCommand>
    {
        public DeleteCategoryCommandValidator()
        {
            RuleFor(c => c.CategoryId).NotEmpty().WithMessage("CategoryId is required.");
        }
    }
}