using System;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Commands.Customers
{
    public class UpdateCustomerCommand : IRequest
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public AddressDto Address { get; set; }
    }
}