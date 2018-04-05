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
using Webshop.Project.Core.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Webshop.Project.Core.Repositories.Implementations;

namespace Webshop.Controllers
{
    public class CartController : Controller
    {
        private CartService cartService;
        private readonly string connectionString;

        public CartController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");

            cartService = new CartService(new CartRepository(this.connectionString));
        }

        public IActionResult Index()
        {
            List<CartModel> cart;             cart = cartService.GetCart();
            return View(cart);
        }

        [HttpPost]
        public ActionResult Index(CartModel model)
        {
            this.cartService.DeleteFromCart(model);
            return RedirectToAction("Index");
        }
    }
}
