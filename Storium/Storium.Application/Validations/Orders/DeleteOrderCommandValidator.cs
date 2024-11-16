using FluentValidation;
using Storium.Application.Commands.Orders;

namespace Storium.Application.Validations.Orders
{
    public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidator()
        {
            RuleFor(o => o.OrderId).NotEmpty().WithMessage("OrderId is required.");
        }
    }
}