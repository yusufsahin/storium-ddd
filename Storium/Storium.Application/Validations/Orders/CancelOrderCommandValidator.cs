using FluentValidation;
using Storium.Application.Commands.Orders;

namespace Storium.Application.Validations.Orders
{
    public class CancelOrderCommandValidator : AbstractValidator<CancelOrderCommand>
    {
        public CancelOrderCommandValidator()
        {
            RuleFor(o => o.OrderId).NotEmpty().WithMessage("OrderId is required.");
        }
    }
}