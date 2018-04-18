using System;
using System.Collections.Generic;

namespace Webshop.Project.Core.Models
{
    public class OrderModel
    {
        public string user_name { get; set; }
        public int order_id { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string cart_id { get; set; }
    }
}
