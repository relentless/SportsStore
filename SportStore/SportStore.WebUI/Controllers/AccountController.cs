using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.WebUI.Models;
using System.Web.Security;

namespace SportStore.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult LogOn()
        {
            return View(new AccountViewModel());
        }

        [HttpPost]
        public ActionResult LogOn(AccountViewModel details, string ReturnUrl) {
            if (ModelState.IsValid) {
                if (!FormsAuthentication.Authenticate(details.UserName, details.Password)) {
                    ModelState.AddModelError("", "Username or password incorect");
                }
            }

            if(ModelState.IsValid){
                FormsAuthentication.SetAuthCookie(details.UserName, false);
                return Redirect(ReturnUrl);
            }
            else {
                return View(details);
            }
        }
    }
}
