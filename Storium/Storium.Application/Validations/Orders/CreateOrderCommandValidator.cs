using FluentValidation;
using Storium.Application.Commands.Orders;

namespace Storium.Application.Validations.Orders
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(o => o.CustomerId).NotEmpty().WithMessage("CustomerId is required.");
            RuleFor(o => o.OrderDate).NotEmpty().WithMessage("OrderDate is required.");
            RuleForEach(o => o.OrderItems).ChildRules(items =>
            {
                items.RuleFor(i => i.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than zero.");
                items.RuleFor(i => i.UnitPrice.Amount).GreaterThan(0).WithMessage("Unit price must be greater than zero.");
            });
        }
    }
}