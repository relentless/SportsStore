using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.WebUI.UrlHelpers {
    public static class UrlHelperExtentions {
        public static string ProductsList(this UrlHelper helper, int pageNum) {
            return helper.Action("List", new { page = pageNum });
        }

        public static string Checkout(this UrlHelper helper, string returnUrl) {
            return helper.Action("Index", "Cart", new { redirectToUrl = returnUrl });
        }

        public static string Stylesheet(this UrlHelper helper, string fileName) {
            return helper.Content(string.Format("~/Content/{0}", fileName));
        }

        public static string Script(this UrlHelper helper, string fileName) {
            return helper.Content(string.Format("~/Scripts/{0}", fileName));
        }
    }
}
