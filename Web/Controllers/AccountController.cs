using BloodSearch.Models.Api;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Infrastructure.Authorization;
using Web.Models.SearchItems;

namespace Web.Controllers {

    public class AccountController : BaseController {

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

            var model = new ProfileIndexResponse {
                Email = User.Email,
                Name = User.Name,
                Phone = User.Phone,
                Items = BloodSearchModelsRemoteProvider.GetOffersByUser(User.UserId)
            };

            return View(model);
        }
    }
}