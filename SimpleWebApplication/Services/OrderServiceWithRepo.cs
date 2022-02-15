using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApplication.Services
{
    public class OrderServiceWithRepo
    {
        private readonly IOrderRepository _orderRepository;

        public OrderServiceWithRepo(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderStatus PlaceOrder(Order order)
        {
            bool result = _orderRepository.Save(order);

            if (result) return OrderStatus.OrderPlacedCorrectly;
            else return OrderStatus.ErrorPlacingOrder;
        }
    }

    public interface IOrderRepository
    {
        bool Save(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        public bool Save(Order order)
        {
            return true;
        }
    }
}
