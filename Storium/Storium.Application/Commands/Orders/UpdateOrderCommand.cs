using System;
using MediatR;

namespace Storium.Application.Commands.Orders
{
    public class UpdateOrderCommand : IRequest
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}