using System;
using System.Collections.Generic;
using MediatR;
using Storium.Domain.ValueObjects;

namespace Storium.Application.Commands.Orders
{
    public class CreateOrderCommand : IRequest<Guid>, IBaseRequest
    {
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }

    public class OrderItemDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Money UnitPrice { get; set; }
    }
}