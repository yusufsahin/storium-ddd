using Storium.Domain.ValueObjects;

namespace Storium.Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public Money Price { get; set; } // Value Object
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}