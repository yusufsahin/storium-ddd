using Microsoft.Extensions.DependencyInjection;
using Storium.Infrastructure.Repositories;
using Storium.Infrastructure.Repositories.Interfaces;
using Storium.Infrastructure.Services;

namespace Storium.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Register Repositories
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            // Register Services
            services.AddScoped<MigrationService>();

            return services;
        }
    }
}
