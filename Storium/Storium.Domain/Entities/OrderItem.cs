using Storium.Domain.ValueObjects;

namespace Storium.Domain.Entities
{
    public class OrderItem
    {
        public Guid OrderItemId { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Money UnitPrice { get; set; } // Value Object
        public Money TotalPrice => UnitPrice.Multiply(Quantity);
    }
}