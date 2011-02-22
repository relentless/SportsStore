using NUnit.Framework;
using SportStore.Domain.Entities;
using NSubstitute;
using SportStore.Domain.Abstract;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportStore.UnitTests {
    public static class UnitTestHelpers {

        public static void ShouldEqual<T>(this T actualValue, T expectedValue) {
            Assert.AreEqual(expectedValue, actualValue);
        }

        public static void ShouldBeRedirectionTo(this ActionResult actionResult, 
                                                 object expectedRouteValues) {

            var actualValues = ((RedirectToRouteResult)actionResult).RouteValues;
            var expectedValues = new RouteValueDictionary(expectedRouteValues);

            foreach (var key in expectedValues) {
                actualValues[key.Key].ShouldEqual(key.Value);
            }
        }

        public static IProductsRepository MockRepository(params Product[] products) {
            var mockRepository = Substitute.For<IProductsRepository>();
            mockRepository.Products.Returns(products.AsQueryable());
            return mockRepository;
        }
    }
}
