using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storium.Domain.Entities;

namespace Storium.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Primary Key
            builder.HasKey(p => p.ProductId);

            // Properties
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Description)
                   .HasMaxLength(250); // Add .IsRequired() if Description must be mandatory

            // Owned Type: Price
            builder.OwnsOne(p => p.Price, money =>
            {
                money.Property(m => m.Amount)
                     .HasPrecision(18, 2)
                     .IsRequired();
                money.Property(m => m.Currency)
                     .HasMaxLength(3)
                     .IsRequired();
            });

            // Relationships
            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict); // Optional based on domain rules

            // Indexes
            builder.HasIndex(p => p.Name);
        }
    }
}
