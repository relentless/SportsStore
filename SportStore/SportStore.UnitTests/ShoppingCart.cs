using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using SportStore.WebUI.Controllers;

namespace SportStore.UnitTests {
    [TestFixture]
    public class ShoppingCart {
        [Test]
        public void can_add_products_to_cart() {
            // arrange
            IProductsRepository repository = Substitute.For<IProductsRepository>();
            Product someProduct = new Product { ProductID= 123 };
            repository.Products.Returns( new List<Product> { someProduct }.AsQueryable() );
            Cart cart = new Cart();

            CartController controller = new CartController(repository);

            // act
            controller.AddProduct(123, null, cart);


            // assert
            cart.Lines[0].Product.ShouldEqual(someProduct);
        }

        [Test]
        public void adding_product_redirects_to_index() {
            // arrange
            IProductsRepository repository = Substitute.For<IProductsRepository>();
            repository.Products.Returns(new List<Product> { new Product { ProductID = 123 } }.AsQueryable());
            CartController controller = new CartController(repository);

            // act
            var result = controller.AddProduct(123, null, new Cart());


            // assert
            result.ShouldBeRedirectionTo(new { action = "Index" });
        }
    }
}
