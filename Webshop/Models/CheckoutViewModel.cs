﻿using System;
namespace Webshop.Models
{
    public class CheckoutViewModel
    {
        public int Id { get; set; }
        public int product_id { get; set; }
        public string name { get; set; }
        public int price { get; set; }


        public string user_name { get; set; }
        public int order_id { get; set; }
        //public int product_price { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
