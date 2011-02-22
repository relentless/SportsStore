using System;
using NUnit.Framework;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using SportStore.WebUI.Controllers;
using SportStore.WebUI.Models;
using System.Collections.Generic;
using System.Linq;

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
            var result = controller.List(null, 2);

            // assert
            var displayedProducts = ((ProductListViewModel)result.ViewData.Model).Products.ToList();
            displayedProducts.Count.ShouldEqual(2);
            displayedProducts[0].Name.ShouldEqual("p4");
            displayedProducts[1].Name.ShouldEqual("p5");
        }

        [Test]
        public void can_view_specific_product_category() {
            // arrange
            IProductsRepository repository = UnitTestHelpers.MockRepository(
                new Product { Name = "p1", Category = "c1" },
                new Product { Name = "p2", Category = "c2" }
                );

            var controller = new ProductsController(repository);
            controller.PageSize = 3;

            // act
            var result = controller.List("c1", 1);

            // assert
            var displayedProducts = ((ProductListViewModel)result.ViewData.Model).Products.ToList();
            displayedProducts.Count.ShouldEqual(1);
            displayedProducts[0].Category.ShouldEqual("c1");
        }

        [Test]
        public void can_view_all_product_categories() {
            // arrange
            IProductsRepository repository = UnitTestHelpers.MockRepository(
                new Product { Name = "p1", Category = "c1" },
                new Product { Name = "p2", Category = "c2" }
                );

            var controller = new ProductsController(repository);
            controller.PageSize = 3;

            // act
            var result = controller.List("All", 1);

            // assert
            var displayedProducts = ((ProductListViewModel)result.ViewData.Model).Products.ToList();
            displayedProducts.Count.ShouldEqual(2);
            displayedProducts[0].Category.ShouldEqual("c1");
            displayedProducts[1].Category.ShouldEqual("c2");
            ((ProductListViewModel)result.ViewData.Model).Category.ShouldEqual("All");
        }
    }
}
