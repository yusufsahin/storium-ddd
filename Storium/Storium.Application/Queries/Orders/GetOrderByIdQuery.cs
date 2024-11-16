using System;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Orders
{
    public class GetOrderByIdQuery : IRequest<OrderDto>
    {
        public Guid OrderId { get; set; }
    }
}