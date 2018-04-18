using System;
namespace Webshop.Project.Core.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public int product_id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int price { get; set; }
        public int product_price { get; set; }
        public string cart_id { get; set; }
    }
}
