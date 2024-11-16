using System;
using System.Collections.Generic;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Orders
{
    public class GetOrdersByCustomerQuery : IRequest<IEnumerable<OrderDto>>
    {
        public Guid CustomerId { get; set; }
    }
}