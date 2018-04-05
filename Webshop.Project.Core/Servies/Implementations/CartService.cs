using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Webshop.Project.Core.Repositories.Implementations;

namespace Webshop.Project.Core.Servies.Implementations
{
    public class CartService
    {
        private readonly CartRepository cartRepository;
        public CartService(CartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public List<CartModel> GetCart()
        { 
            return cartRepository.GetCart();
        }

        public void DeleteFromCart(CartModel model)
        { 
            cartRepository.DeleteFromCart(model);
        }
          
	}
}
