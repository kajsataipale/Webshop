using System;
namespace Webshop.Models
{
    public class CheckoutViewModel
    {
        public int Id { get; set; }
        public int product_id { get; set; }
        public int price { get; set; }
    


        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
