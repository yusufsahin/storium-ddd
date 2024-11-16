using System;
using MediatR;

namespace Storium.Application.Commands.Orders
{
    public class DeleteOrderCommand : IRequest
    {
        public Guid OrderId { get; set; }
    }
}