using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Http;
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
        private CheckoutService checkoutService;

        public OrderController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");

            orderService = new OrderService(new OrderRepository(this.connectionString));
            checkoutService = new CheckoutService(new CheckoutRepository(this.connectionString));

        }

        public ActionResult Index( )
        {
            var cookie = Request.Cookies["cart_id"];
            Response.Cookies.Append("cart_id", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });

            CheckoutModel orderconfirmed = new CheckoutModel();
            orderconfirmed.order = orderService.ReturnOrder(cookie);
            orderconfirmed.product = checkoutService.GetCheckout(cookie);

            return View(orderconfirmed);
        }
      
    }
}
