using FluentValidation;
using Storium.Application.Commands.Categories;

namespace Storium.Application.Validations.Categories
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Category name is required.");
        }
    }
}