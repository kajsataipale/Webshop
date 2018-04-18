using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;

namespace Webshop.Project.Core.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly string connectionString;

        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ProductModel> GetAll()
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<ProductModel>("select * from Products").ToList();
            }
        
        }
        public void InsertIntoCart(ProductModel model, string cart_id)
        {
            string InsertSql = "INSERT INTO Cart (product_id,amount, price, cart_id) VALUES (@product_id, 1, @price, @cart_id)";
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute(InsertSql, new { product_id = model.product_id, price = model.Price, cart_id = cart_id });

            }

        }
    }
}
