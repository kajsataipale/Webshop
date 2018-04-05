using System;
using System.Collections.Generic;

namespace Webshop.Project.Core.Models
{
    public class CheckoutModel
    {

        public List<ProductModel> product { get; set; }
        public OrderModel order { get; set; }
       
    }
}
