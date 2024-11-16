using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storium.Domain.Entities;

namespace Storium.Infrastructure.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);

            builder.OwnsOne(c => c.Address, address =>
            {
                address.Property(a => a.Street).HasMaxLength(100).IsRequired();
                address.Property(a => a.City).HasMaxLength(50).IsRequired();
                address.Property(a => a.State).HasMaxLength(50).IsRequired();
                address.Property(a => a.PostalCode).HasMaxLength(20).IsRequired();
                address.Property(a => a.Country).HasMaxLength(50).IsRequired();
            });
        }
    }
}
