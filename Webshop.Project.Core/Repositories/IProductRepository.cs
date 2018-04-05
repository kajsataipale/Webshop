using System;
using System.Collections.Generic;
using Webshop.Project.Core.Models;

namespace Webshop.Project.Core.Repositories
{
    public interface IProductRepository
    {
         List<ProductModel> GetAll();

         void InsertIntoCart(ProductModel model);
    }
}
