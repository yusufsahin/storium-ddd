using FluentValidation;
using Storium.Application.Commands.Categories;

namespace Storium.Application.Validations.Categories
{
    public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryCommandValidator()
        {
            RuleFor(c => c.CategoryId).NotEmpty().WithMessage("CategoryId is required.");
            RuleFor(c => c.Name).NotEmpty().WithMessage("Category name is required.");
        }
    }
}