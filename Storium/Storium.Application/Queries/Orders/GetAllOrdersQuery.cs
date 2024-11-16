using System.Collections.Generic;
using MediatR;

using Storium.Application.DTOs;
namespace Storium.Application.Queries.Orders
{
    public class GetAllOrdersQuery : IRequest<IEnumerable<OrderDto>>
    {
    }
}