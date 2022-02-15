using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApplication.Services
{
    public class OrderService
    {
        public OrderStatus PlaceOrder(Order order)
        {
            if (order is null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            // save in repository
            return OrderStatus.OrderPlacedCorrectly;
        }


        
    }

    public enum OrderStatus
    {
        OrderPlacedCorrectly,
        ErrorPlacingOrder,
        NotEnoughCapacity
    }

    public class Order
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
    }
}
