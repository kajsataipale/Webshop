using System;
namespace Webshop.Models
{
    public class OrderViewModel
    {
        public string user_name { get; set; }
        public int order_id { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
