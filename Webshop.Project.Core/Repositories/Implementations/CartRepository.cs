using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;

namespace Webshop.Project.Core.Repositories.Implementations
{
    public class CartRepository
    {
        private readonly string connectionString;

        public CartRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<CartModel> GetCart(){
        using (var connection = new MySqlConnection(this.connectionString))
            {
                   return connection.Query<CartModel>("SELECT * FROM Cart INNER JOIN Products ON Cart.product_id=Products.product_id").ToList();
            }
        }
        public void DeleteFromCart(CartModel model){
        string InsertSql = "DELETE FROM Cart WHERE id=@id";
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute(InsertSql, new { id = model.Id});
               
            }
        }

    }
}
