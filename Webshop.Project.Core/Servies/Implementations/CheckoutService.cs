using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Webshop.Project.Core.Repositories.Implementations;

namespace Webshop.Project.Core.Servies.Implementations
{
    public class CheckoutService
    {
        private readonly CheckoutRepository checkoutRepository;
        public CheckoutService(CheckoutRepository checkoutRepository)
        {
            this.checkoutRepository = checkoutRepository;
        }

        public List<ProductModel> GetCheckout(string cart_id)
        {
            return checkoutRepository.GetCheckout(cart_id);
        }

        public void InsertToCheckout(OrderModel model)
        {
            checkoutRepository.InsertToCheckout(model);
        }

       

    }
}