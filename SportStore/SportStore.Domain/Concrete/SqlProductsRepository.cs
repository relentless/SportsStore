
using System.Linq;
using System.Data.Linq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Concrete {
    public class SqlProductsRepository: IProductsRepository {

        private Table<Product> productsTable;

        public SqlProductsRepository(string connectionString){
            productsTable = (new DataContext(connectionString)).GetTable<Product>();
        }

        public IQueryable<Product> Products {
            get { return productsTable; }
        }
    }
}
