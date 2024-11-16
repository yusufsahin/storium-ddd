
using System;
using System.Threading.Tasks;
using Storium.Application.Commands.Orders;
using Storium.Domain.Entities;
using Storium.Domain.Enums;
using Storium.Domain.ValueObjects;
using Storium.Infrastructure.Repositories.Interfaces;

namespace Storium.Application.Services
{
    public class OrderApplicationService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderApplicationService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public async Task<Guid> CreateOrderAsync(CreateOrderCommand command)
        {
            var order = new Order
            {
                CustomerId = command.CustomerId,
                OrderDate = command.OrderDate,
                Status = OrderStatus.Pending
            };

            foreach (var item in command.OrderItems)
            {
                var product = await _productRepository.GetByIdAsync(item.ProductId);
                if (product == null)
                {
                    throw new InvalidOperationException($"Product with ID {item.ProductId} not found.");
                }

                order.OrderItems.Add(new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = new Money(product.Price.Amount, product.Price.Currency)
                });
            }

            await _orderRepository.AddAsync(order);
            return order.OrderId;
        }
    }
}
