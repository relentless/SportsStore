using NUnit.Framework;
using SportStore.Domain.Entities;
using NSubstitute;
using SportStore.Domain.Abstract;
using System.Linq;

namespace SportStore.UnitTests {
    public static class UnitTestHelpers {

        public static void ShouldEqual<T>(this T actualValue, T expectedValue) {
            Assert.AreEqual(expectedValue, actualValue);
        }

        public static IProductsRepository MockRepository(params Product[] products) {
            var mockRepository = Substitute.For<IProductsRepository>();
            mockRepository.Products.Returns(products.AsQueryable());
            return mockRepository;
        }
    }
}
