using System;
using System.Web;
using System.Web.Mvc;
using Web.Infrastructure.Authorization;

namespace Web.Controllers {

    public class AccountController : Controller {

        public ActionResult Login() {
            return View();
        }

        public ActionResult Registration() {
            return View();
        }

        [WebAuthorize]
        public ActionResult Logout() {
            RemoveAdmishkaCookie();
            MembershipService.Logout();
            var reffer = Request.UrlReferrer?.OriginalString;
            if (!string.IsNullOrWhiteSpace(reffer)) {
                return Redirect(reffer);
            }
            return RedirectToAction("Index", "Home");
        }

        private void RemoveAdmishkaCookie() {
            var cookie = new HttpCookie("AdmishkaUserIdTempCookieKey");
            cookie.Expires = DateTime.Now.AddDays(-1);
            HttpContext.Response.Cookies.Add(cookie);
        }

        [WebAuthorize]
        public new ActionResult Profile() {
            return View();
        }
    }
}