
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

        public void Save(Product product) {
            if (product.ProductID == 0) {
                productsTable.InsertOnSubmit(product);
            }
            else if (productsTable.GetOriginalEntityState(product) == null) {
                productsTable.Attach(product);
                productsTable.Context.Refresh(RefreshMode.KeepCurrentValues, product);
            }

            productsTable.Context.SubmitChanges();
        }
    }
}
