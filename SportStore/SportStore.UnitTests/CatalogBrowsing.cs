using System;
using NUnit.Framework;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using SportStore.WebUI.Controllers;
using System.Collections.Generic;

namespace SportStore.UnitTests {
    [TestFixture]
    public class CatalogBrowsing {
        [Test]
        public void can_view_single_page_of_products() {
            // arrange
            IProductsRepository repository = UnitTestHelpers.MockRepository(
                new Product { Name = "p1" },
                new Product { Name = "p2" },
                new Product { Name = "p3" },
                new Product { Name = "p4" },
                new Product { Name = "p5" }
                );

            var controller = new ProductsController(repository);
            controller.PageSize = 3;

            // act
            var result = controller.List(2);

            // assert
            var displayedProducts = (IList<Product>)result.ViewData.Model;
            displayedProducts.Count.ShoudEqual(2);
            displayedProducts[0].Name.ShoudEqual("p4");
            displayedProducts[1].Name.ShoudEqual("p5");
        }
    }
}
