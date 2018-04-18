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
using Webshop.Project.Core.Servies.Implementations;
using Webshop.Project.Core.Repositories.Implementations;
using Webshop.Project.Core.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webshop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly string connectionString;
        private CheckoutService checkoutService;


        public CheckoutController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");

            checkoutService = new CheckoutService(new CheckoutRepository(this.connectionString));

        }

        public IActionResult Index()
        {
            var cookie = Request.Cookies["cart_id"];
            CheckoutModel cart = new CheckoutModel();
           
            cart.product = checkoutService.GetCheckout(cookie);

            return View(cart);
        }

        [HttpPost]
        public ActionResult Index(OrderModel model)
        {
            model.cart_id = Request.Cookies["cart_id"];
            this.checkoutService.InsertToCheckout(model);

            //return View("~/Views/Order/Index.cshtml", model);
            return RedirectToAction("Index", "Order");
        }
 

                






    }
}
