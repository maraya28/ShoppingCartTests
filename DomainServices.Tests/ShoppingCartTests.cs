using DomainModel;
using Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DomainServices.Tests
{
    public class ShoppingCartTests
    {
        private Mock<IProductRepository> _productRepository;
        private ShoppingCart _shoppingCart;

        public ShoppingCartTests()
        {
            _productRepository = new Mock<IProductRepository>();
            _shoppingCart = new ShoppingCart(_productRepository.Object);
        }

        [Fact]
        public void The_Code_Product_Does_Not_Exist()
        {
            var code = "10020068SL";
            var ex = Assert.Throws<ShoppingCartException>(() => _shoppingCart.AddItem(code));

            Assert.Equal($"The code: {code} doesn´t exist.", ex.Message);
        }
    }
}
