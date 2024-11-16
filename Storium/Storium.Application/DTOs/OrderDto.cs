using System;
using System.Collections.Generic;

namespace Storium.Application.DTOs
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // OrderStatus Enum to String
        public decimal TotalAmount { get; set; } // Calculated total
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
    }
}