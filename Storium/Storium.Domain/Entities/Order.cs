using Storium.Domain.Enums;

namespace Storium.Domain.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; } // Enum
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public decimal TotalAmount => OrderItems.Sum(item => item.TotalPrice.Amount);

        public void UpdateStatus(OrderStatus status)
        {
            Status = status;
        }
    }
}