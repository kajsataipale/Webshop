using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Webshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webshop.Controllers
{
    public class OrderController : Controller
    {
        private readonly string connectionString;

        public OrderController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");
        }

        public ActionResult Index()
        {
            List<OrderViewModel> product;
            using (var connection = new MySqlConnection(this.connectionString))
            {
                product = connection.Query<OrderViewModel>("select * from Checkout").ToList();
            }

            return View(product);
        }
    }
}
