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
            //var cartId = Request.Cookies["CartID"];
            List<CheckoutViewModel> cart;
            using (var connection = new MySqlConnection(this.connectionString))
            {
                cart = connection.Query<CheckoutViewModel>("SELECT * FROM Cart INNER JOIN Products ON Cart.product_id=Products.product_id").ToList();
            }

            return View(cart);
        }
 

                






    }
}
