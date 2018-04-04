using System;
namespace Webshop.Models
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public int product_id { get; set; }
        public string Image { get; set;  }
        public string Name { get; set; }
        //public int amount { get; set; }
        public int price { get; set; }
        public int product_price { get; set; }
        public int Quantity { get; set; }
    }
}
