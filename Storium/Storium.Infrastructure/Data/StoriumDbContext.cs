using Microsoft.EntityFrameworkCore;
using Storium.Domain.Entities;

namespace Storium.Infrastructure.Data
{
    public class StoriumDbContext : DbContext
    {
        public StoriumDbContext(DbContextOptions<StoriumDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoriumDbContext).Assembly);
        }
    }
}
