using System.Collections.Generic;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Orders
{
    public class GetOrdersByStatusQuery : IRequest<IEnumerable<OrderDto>>
    {
        public string Status { get; set; } // Pending, Paid, etc.
    }
}