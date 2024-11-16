using Storium.Domain.Entities;

namespace Storium.Infrastructure.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(Guid id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<Order>> GetOrdersByCustomerAsync(Guid customerId); // New Method

    }
}