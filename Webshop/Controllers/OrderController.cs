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

        public ActionResult Index(int order_id)
        {
            List<OrderViewModel> orderconfirmed;
            using (var connection = new MySqlConnection(this.connectionString))
            {
                orderconfirmed = connection.Query<OrderViewModel>("select * from Checkout where order_id=@order_id", new { order_id }).ToList();
            }

            return View(orderconfirmed);
        }
    }
}
