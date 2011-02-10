using System.Web;
using System.Web.Mvc;
using System.Linq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Concrete;

namespace SportStore.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsRepository productsRepository;

        public ProductsController() {
            string connectionString = @"Server=.\SQLEXPRESS2005;Database=SportStore;Trusted_Connection=yes;";
            productsRepository = new SqlProductsRepository(connectionString);
        }

        public ActionResult List()
        {
            return View(productsRepository.Products.ToList());
        }

    }
}
