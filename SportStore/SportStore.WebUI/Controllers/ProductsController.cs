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

        public ProductsController(IProductsRepository productsRepository) {
            this.productsRepository = productsRepository;
        }

        public ActionResult List()
        {
            return View(productsRepository.Products.ToList());
        }

    }
}
