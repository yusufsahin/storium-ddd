using System;

namespace Storium.Application.DTOs
{
    public class OrderItemDto
    {
        public Guid OrderItemId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } // Optional for display
        public int Quantity { get; set; }
        public MoneyDto UnitPrice { get; set; }
        public MoneyDto TotalPrice { get; set; }
    }
}