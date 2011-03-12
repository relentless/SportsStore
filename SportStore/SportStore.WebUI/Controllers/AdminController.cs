using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductsRepository _repository;

        public AdminController(IProductsRepository repository) {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(_repository.Products.ToList());
        }

        public ActionResult Edit(int ProductID) {
            var product = _repository.Products.Where(x => x.ProductID == ProductID).First();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product) {
            if (ModelState.IsValid) {
                _repository.Save(product);
                TempData["message"] = product.Name + " has been saved";
                return RedirectToAction("Index");
            }
            else {
                return View(product);
            }
        }
    }
}
