using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;
namespace Webshop.Project.Core.Repositories.Implementations
{
    public class OrderRepository
    {
        private readonly string connectionString;

        public OrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<OrderModel> ReturnOrder(int order_id)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<OrderModel>("select * from Checkout where order_id=@order_id", new { order_id}).ToList();
            }
        }

        public List<OrderModel> GetOrder()
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<OrderModel>("SELECT * FROM Cart JOIN Products ON Cart.product_id=Products.product_id").ToList();
            }
        }
    }
}
