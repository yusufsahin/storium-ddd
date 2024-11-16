using System;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Orders
{
    public class GetOrderDetailsQuery : IRequest<OrderDto>
    {
        public Guid OrderId { get; set; }
    }
}