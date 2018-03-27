using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Webshop.Models;
using System.Data.SqlClient;
using Dapper;
using MySql.Data.MySqlClient;

namespace Webshop.Controllers
{
    public class CartController : Controller
    {
        private readonly string connectionString;

        public CartController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");
        }

        public IActionResult Index()
        {
            //var cartId = Request.Cookies["CartID"];
            List<CartViewModel> cart;             using (var connection = new MySqlConnection(this.connectionString))             {                 cart = connection.Query<CartViewModel>("select *, COUNT(product_id) AS amount FROM Cart JOIN Products ON Cart.product_id=Products.id WHERE cart_id = @cartId").ToList();             }              return View(cart);
        }

        [HttpGet]
        public IActionResult Add(string id)
        {
            var cartId = Request.Cookies["CartID"];

            using (var connection = new MySqlConnection(this.connectionString))
            {

                var addToCartQuery = "INSERT INTO Cart (product_id, cart_id) VALUES(@id, @cartId)";

                connection.Execute(addToCartQuery, new { id, cartId });

            }
            return RedirectToAction("Index");

        }


    }
}
