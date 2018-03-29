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
            List<CartViewModel> cart;             using (var connection = new MySqlConnection(this.connectionString))             {                 cart = connection.Query<CartViewModel>("SELECT * FROM Cart INNER JOIN Products ON Cart.product_id=Products.product_id").ToList();
            }

            return View(cart);
        }

        [HttpPost]
        public ActionResult Index(CartViewModel model)
        {
            string InsertSql = "DELETE FROM Cart WHERE product_id=@product_id";
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute(InsertSql, new { product_id = model.product_id });
            }
            return RedirectToAction("Index");
        }
    }
}
