using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Domain.Entities;

namespace SportStore.WebUI.Infrastructure {
    public class CartModelBinder: IModelBinder {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) {
            if (bindingContext.Model != null) {
                throw new Exception("CartModelBinder cannot update an existing Cart");
            }

            if (controllerContext.HttpContext.Session["cart"] == null) {
                controllerContext.HttpContext.Session["cart"] = new Cart();
            }

            return (Cart)controllerContext.HttpContext.Session["cart"];
        }
    }
}
