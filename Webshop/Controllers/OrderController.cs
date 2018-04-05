using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Webshop.Models;
using Webshop.Project.Core.Models;
using Webshop.Project.Core.Repositories.Implementations;
using Webshop.Project.Core.Servies.Implementations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webshop.Controllers
{
    public class OrderController : Controller
    {
        private readonly string connectionString;

        private OrderService orderService;

        public OrderController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");

            orderService = new OrderService(new OrderRepository(this.connectionString));

        }

        public ActionResult Index(int order_id)
        {
            List<OrderModel> orderconfirmed;
            orderconfirmed = orderService.ReturnOrder(order_id);

            return View(orderconfirmed);
        }
    }
}
