using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Storium.Application.DTOs;
using Storium.Application.Queries.Orders;
using Storium.Infrastructure.Repositories.Interfaces;

namespace Storium.Application.Handlers.Queries.Orders
{
    public class GetOrderDetailsQueryHandler : IRequestHandler<GetOrderDetailsQuery, OrderDto>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderDetailsQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<OrderDto> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.OrderId);

            var orderDto = new OrderDto
            {
                OrderId = order.OrderId,
                CustomerId = order.CustomerId,
                OrderDate = order.OrderDate,
                Status = order.Status.ToString(), // Convert enum to string
                TotalAmount = order.OrderItems.Sum(item => item.UnitPrice.Amount * item.Quantity), // Calculate total amount
                OrderItems = order.OrderItems.Select(item => new OrderItemDto
                {
                    OrderItemId = item.OrderItemId,
                    ProductId = item.ProductId,
                    ProductName = item.Product.Name,
                    Quantity = item.Quantity,
                    UnitPrice = new MoneyDto
                    {
                        Amount = item.UnitPrice.Amount,
                        Currency = item.UnitPrice.Currency.ToString() // Convert enum to string
                    },
                    TotalPrice = new MoneyDto
                    {
                        Amount = item.UnitPrice.Amount * item.Quantity,
                        Currency = item.UnitPrice.Currency.ToString() // Convert enum to string
                    }
                }).ToList()
            };

            return orderDto;
        }
    }
}
