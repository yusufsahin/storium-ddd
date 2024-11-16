using System;
using MediatR;
using Storium.Application.DTOs;

namespace Storium.Application.Queries.Customers
{
    public class GetCustomerByIdQuery : IRequest<CustomerDto>
    {
        public Guid CustomerId { get; set; }
    }
}