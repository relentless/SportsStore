using System.Web;
using System.Web.Mvc;
using System.Linq;
using SportStore.Domain.Abstract;
using SportStore.Domain.Concrete;
using SportStore.WebUI.Models;
using System;
using System.ComponentModel;
using System.Web.Routing;
using System.Collections.Generic;

namespace SportStore.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsRepository productsRepository;

        public int PageSize = 4;

        public ProductsController(IProductsRepository productsRepository) {
            this.productsRepository = productsRepository;
        }

        [OutputCache(CacheProfile="ProductList")]
        [HttpGet]
        public ViewResult List([DefaultValue("All")] string category, [DefaultValue(1)] int page)
        {
            var filteredProducts = productsRepository.Products.ToList();

            if( category != "All") {
                filteredProducts = filteredProducts.Where(x => x.Category == category ).ToList();
            }

            return View(
                new ProductListViewModel {
                    Products = filteredProducts
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize)
                        .ToList(),
                    Paging = new PagingInfo {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = filteredProducts.Count()
                    },
                    Category = category ?? "All"
                });
        }

        public PartialViewResult CategoryList(string category) {
            var categories = productsRepository.Products.Select(product => product.Category).Distinct();

            var links = new List<CategoryLink> {
                new CategoryLink {
                Controller = "Products",
                Action = "List",
                Category = "All",
                IsSelected = category == "All"
                }
            };

            links.AddRange(categories.Select(x => GenerateCategoryLink(x, category)).ToList());

            return PartialView(links);
        }

        private CategoryLink GenerateCategoryLink(string category, string currentCategory) {
            return new CategoryLink {
                Controller = "Products",
                Action = "List",
                Category = category,
                IsSelected = category == currentCategory
            };
        }

    }
}
