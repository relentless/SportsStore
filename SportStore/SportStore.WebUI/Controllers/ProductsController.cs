using System.Web;
using System.Web.Mvc;
using System.Linq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Concrete;
using System;

namespace SportStore.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsRepository productsRepository;

        public int PageSize = 4;

        public ProductsController(IProductsRepository productsRepository) {
            this.productsRepository = productsRepository;
        }

        public ViewResult List(int page)
        {
            return View(productsRepository.Products
                .Skip((page-1) * PageSize)
                .Take(PageSize)
                .ToList());
        }

    }
}
