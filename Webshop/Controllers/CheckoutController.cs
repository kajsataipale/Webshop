using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Webshop.Models;
//using System.Data.SqlClient;
using Dapper;
using MySql.Data.MySqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webshop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly string connectionString;

        public CheckoutController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");
        }

        public IActionResult Index()
        {
            List<CheckoutViewModel> cart;
            using (var connection = new MySqlConnection(this.connectionString))
            {
                cart = connection.Query<CheckoutViewModel>("SELECT * FROM Cart JOIN Products ON Cart.product_id=Products.product_id").ToList();
            }

            return View(cart);
        }

        [HttpPost]
        public ActionResult Index(string user_name, string email, string phone, string adress)
        {
            string AddCheckout = "INSERT INTO Checkout (user_name, email, phone, adress) VALUES (@user_name, @email, @phone, @adress)";
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute(AddCheckout, new 
                { 
                    user_name = @user_name, 
                    email = @email, 
                    phone = @phone,
                    adress = @adress
                });

            }
            return RedirectToAction("../Order");
        }
 

                






    }
}
