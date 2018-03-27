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
            List<CartViewModel> cart;             using (var connection = new MySqlConnection(this.connectionString))             {                 cart = connection.Query<CartViewModel>("SELECT * FROM Products INNER JOIN Cart ON Products.product_id=Cart.product_id").ToList();
            }

            return View(cart);
        }
    
        //[HttpGet]
        //public IActionResult Add(string id)
        //{
        //    var cartId = Request.Cookies["CartID"];

        //    using (var connection = new MySqlConnection(this.connectionString))
        //    {

        //        var addToCartQuery = "INSERT INTO Cart (product_id, cart_id) VALUES(@id, @cartId)";

        //        connection.Execute(addToCartQuery, new { id, cartId });

        //    }
        //    return Redirect("/Checkout");

        //}
    }
}
