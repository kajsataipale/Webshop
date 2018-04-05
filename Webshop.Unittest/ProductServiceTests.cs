using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using Webshop.Project.Core.Repositories;
using Webshop.Project.Core.Servies.Implementations;
using FakeItEasy;
using Webshop.Project.Core.Models;
using Webshop.Project.Core.Repositories.Implementations;

namespace Webshop.Unittest
{
    public class ProductServiceTests
    {
        private ProductService productService;
        private IProductRepository productRepository;

        [SetUp]
        public void SetUp()
        {
            this.productRepository = A.Fake<IProductRepository>();

            this.productService = new ProductService(this.productRepository);
        }

        [Test]
        public void GetAll_ReturnsExpectedProducts()
        {
            // Arrange
            var products = new List<ProductModel>
            {
                new ProductModel { product_id = 37 }
            };

           
            A.CallTo(() => this.productRepository.GetAll()).Returns(products);

            // Act
            var result = this.productService.GetAll();

            // Assert
            Assert.That(result, Is.EqualTo(products));
        }
    }
}
