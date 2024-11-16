using System;
using System.Threading.Tasks;
using Storium.Application.Commands.Customers;
using Storium.Domain.Entities;
using Storium.Domain.ValueObjects;
using Storium.Infrastructure.Repositories.Interfaces;

namespace Storium.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> CreateCustomerAsync(CreateCustomerCommand command)
        {
            var address = new Address(
                command.Address.Street,
                command.Address.City,
                command.Address.State,
                command.Address.PostalCode,
                command.Address.Country);

            var customer = new Customer(
                command.FirstName,
                command.LastName,
                command.Email,
                address);

            await _repository.AddAsync(customer);
            return customer.CustomerId;
        }
    }
}