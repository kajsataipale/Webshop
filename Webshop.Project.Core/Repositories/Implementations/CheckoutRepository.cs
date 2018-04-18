using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;
namespace Webshop.Project.Core.Repositories.Implementations
{
    public class CheckoutRepository
    {
        private readonly string connectionString;

        public CheckoutRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ProductModel> GetCheckout(string cart_id)
        { 
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<ProductModel>("SELECT * FROM Cart JOIN Products ON Cart.product_id=Products.product_id WHERE cart_id=@cart_id", new { cart_id = cart_id}).ToList();
    
            }
        }


        public void InsertToCheckout(OrderModel model)
        {
            string AddCheckout = "INSERT INTO Checkout (user_name, email, phone, adress, cart_id) VALUES (@user_name, @email, @phone, @adress, @cart_id)";
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute(AddCheckout, new
                {
                    user_name = model.user_name,
                    email = model.Email,
                    phone = model.Phone,
                    adress = model.Adress,
                    cart_id = model.cart_id,
                });

            }
        }


    }
}
