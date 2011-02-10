using System.Linq;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Abstract {
    public interface IProductsRepository {
        IQueryable<Product> Products { get; }
    }
}
