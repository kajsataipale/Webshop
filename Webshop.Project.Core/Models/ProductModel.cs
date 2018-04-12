using System;
namespace Webshop.Project.Core.Models
{
    public class ProductModel
    {
        public int product_id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
    }
}
