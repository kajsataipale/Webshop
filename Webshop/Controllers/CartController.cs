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

        public ActionResult Index()
        {
            List<CartViewModel> cart;
            using (var connection = new MySqlConnection(this.connectionString))
            {
                cart = connection.Query<CartViewModel>("select * from Cart").ToList();
            }

            return View(cart);
        }

        //public ActionResult Get(string id)
        //{
        //    CartViewModel newsItem;
        //    using (var connection = new MySqlConnection(this.connectionString))
        //    {
        //        newsItem = connection.QuerySingleOrDefault<CartViewModel>("select * from Products where id = @id",
        //            new { id });
        //    }

        //    if (newsItem == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(newsItem);
        //}

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(CartViewModel model)
        //{
        //    using (var connection = new MySqlConnection(this.connectionString))
        //    {
        //        connection.Execute("insert into Products values(@id, @product_id, @cart_id)", new { model.Id, model.product_id,model.cart_id });
        //    }

        //    ViewBag.CreateMessage = "News item has been added successfully.";

        //    return View();
        //}

    }
}
