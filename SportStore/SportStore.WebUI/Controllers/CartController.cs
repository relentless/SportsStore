using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using SportStore.WebUI.Models;

namespace SportStore.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductsRepository _repository;
        private IOrderProcessor _orderProcessor;

        public CartController(IProductsRepository repository, IOrderProcessor orderProcessor) {
            _repository = repository;
            _orderProcessor = orderProcessor;
        }

        public ViewResult Index(Cart cart, string redirectToUrl) {
            return View(new CartViewModel { Cart = cart, RedirectionUrl = redirectToUrl });
        }

        public RedirectToRouteResult AddProduct(int productId, string redirectToUrl, Cart cart)
        {
            var addedProduct = _repository.Products.FirstOrDefault(x => x.ProductID == productId);

            cart.Add(addedProduct, 1);

            return RedirectToAction("Index", new {  redirectToUrl });
        }

        public RedirectToRouteResult RemoveProduct(int productId, string RedirectionUrl, Cart cart) {

            cart.Remove(productId);

            return RedirectToAction("Index", new { redirectToUrl = RedirectionUrl });
        }

        public ViewResult Summary(Cart cart) {
            return View(cart);
        }

        public ViewResult Checkout() {
            return View(new DeliveryDetails());
        }

        public ViewResult ConfirmDetails(Cart cart, DeliveryDetails details) {
            if (ModelState.IsValid) {
                _orderProcessor.ProcessOrder(cart, details);
                return View();
            }
            else {
                return View("Checkout", details);
            }
        }
    }
}
