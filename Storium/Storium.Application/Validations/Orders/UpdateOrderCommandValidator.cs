using FluentValidation;
using Storium.Application.Commands.Orders;

namespace Storium.Application.Validations.Orders
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(o => o.OrderId).NotEmpty().WithMessage("OrderId is required.");
            RuleFor(o => o.OrderDate).NotEmpty().WithMessage("OrderDate is required.");
        }
    }
}