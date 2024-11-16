using System;
using MediatR;

namespace Storium.Application.Commands.Orders
{
    public class CancelOrderCommand : IRequest
    {
        public Guid OrderId { get; set; }
    }
}