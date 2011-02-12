using System.Web;
using System.Web.Mvc;
using System.Linq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Concrete;
using SportStore.WebUI.Models;
using System;
using System.ComponentModel;

namespace SportStore.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsRepository productsRepository;

        public int PageSize = 4;

        public ProductsController(IProductsRepository productsRepository) {
            this.productsRepository = productsRepository;
        }

        public ViewResult List([DefaultValue(1)] int page)
        {
            return View(
                new ProductListViewModel {
                    Products = productsRepository.Products
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize)
                        .ToList(),
                    Paging = new PagingInfo {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = productsRepository.Products.Count()
                    }
                });
        }

    }
}
