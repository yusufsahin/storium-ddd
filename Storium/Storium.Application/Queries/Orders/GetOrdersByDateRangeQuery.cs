using System;
using System.Collections.Generic;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Orders
{
    public class GetOrdersByDateRangeQuery : IRequest<IEnumerable<OrderDto>>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}