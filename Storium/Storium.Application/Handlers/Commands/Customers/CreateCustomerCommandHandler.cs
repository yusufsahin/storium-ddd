using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Storium.Application.Commands.Customers;
using Storium.Domain.Entities;
using Storium.Domain.ValueObjects;
using Storium.Infrastructure.Repositories.Interfaces;

namespace Storium.Application.Handlers.Commands.Customers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(
                request.FirstName,
                request.LastName,
                request.Email,
                new Address(request.Address.Street, request.Address.City, request.Address.State, request.Address.PostalCode,request.Address.Country)
            );

            await _customerRepository.AddAsync(customer);
            return customer.CustomerId;
        }
    }
}