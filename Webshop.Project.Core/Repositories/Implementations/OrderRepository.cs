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

        public OrderModel ReturnOrder(string cart_id)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<OrderModel>("SELECT * FROM Checkout WHERE cart_id=@cart_id", new { cart_id});
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
