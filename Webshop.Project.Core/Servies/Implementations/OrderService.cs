using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Webshop.Project.Core.Repositories.Implementations;

namespace Webshop.Project.Core.Servies.Implementations
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository;
        public OrderService(OrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public OrderModel ReturnOrder(string cart_id)
        {
            return orderRepository.ReturnOrder(cart_id);
        }
        public List<OrderModel> GetOrder()
        { 
            return orderRepository.GetOrder();
        }
    }
}