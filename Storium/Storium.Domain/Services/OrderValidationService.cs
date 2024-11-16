using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storium.Domain.Entities;

namespace Storium.Domain.Services
{
    public class OrderValidationService
    {
        public bool CanPlaceOrder(Order order)
        {
            return order.OrderItems.All(item => item.Quantity > 0 && item.UnitPrice.Amount > 0);
        }
    }
}
