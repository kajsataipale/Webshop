using System;
using System.Collections.Generic; using System.Data.SqlClient; using System.Linq; using Dapper; using Microsoft.AspNetCore.Mvc; using Microsoft.Extensions.Configuration; using MySql.Data.MySqlClient;
using Webshop.Models; using Webshop.Project.Core.Models;
using Webshop.Project.Core.Repositories;
using Webshop.Project.Core.Repositories.Implementations;
using Webshop.Project.Core.Servies.Implementations;  namespace Webshop.Controllers {     public class ProductController : Controller     {         private ProductService productService;         private readonly string connectionString;          public ProductController(IConfiguration configuration)         {             this.connectionString = configuration.GetConnectionString("ConnectionString");              productService = new ProductService(new ProductRepository(this.connectionString));         }          public ActionResult Index()         {             List<ProductModel> product;             product = productService.GetAll();              return View(product);         }          [HttpPost]         public ActionResult Index(ProductModel model)         {             var cookie = Request.Cookies["cart_id"];
            if( cookie == null ) 
            {
                cookie = Guid.NewGuid().ToString();
                Response.Cookies.Append("cart_id", cookie);
            }             this.productService.InsertIntoCart(model, cookie);             return RedirectToAction("Index");         }     } }