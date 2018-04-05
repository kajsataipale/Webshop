using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;
using Webshop.Project.Core.Repositories.Implementations;

namespace Webshop.Project.Core.Servies.Implementations
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;
        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<ProductModel> GetAll()
        {
            return productRepository.GetAll();
        }

        public void InsertIntoCart(ProductModel model)
        {
            productRepository.InsertIntoCart(model);
        }
    }
}
