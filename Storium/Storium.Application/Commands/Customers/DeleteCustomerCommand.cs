using System;
using MediatR;

namespace Storium.Application.Commands.Customers
{
    public class DeleteCustomerCommand : IRequest
    {
        public Guid CustomerId { get; set; }
    }
}