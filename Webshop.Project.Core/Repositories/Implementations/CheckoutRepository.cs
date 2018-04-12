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

        public List<ProductModel> GetCheckout()
        { 
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<ProductModel>("SELECT * FROM Cart JOIN Products ON Cart.product_id=Products.product_id").ToList();
            }
        }


        public void InsertToCheckout(OrderModel model)
        {
            string AddCheckout = "INSERT INTO Checkout (user_name, email, phone, adress) VALUES (@user_name, @email, @phone, @adress)";
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute(AddCheckout, new
                {
                    user_name = model.user_name,
                    email = model.Email,
                    phone = model.Phone,
                    adress = model.Adress
                });

            }
        }


    }
}
