using System;
namespace Webshop.Models
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public int product_id { get; set; }
        public int image { get; set; }
        public int price { get; set; }
    }
}
