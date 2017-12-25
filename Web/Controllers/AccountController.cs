using BloodSearch.Filter.Models.Offers;
using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Offers;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Web.Infrastructure.Authorization;
using Web.Models.Account;
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
        public new ActionResult Profile() {
            var model = new ProfileResponse {
                Email = User.Email,
                Name = User.Name,
                Phone = User.Phone,
                Items = BloodSearchModelsRemoteProvider.GetOffersByUser(User.UserId)
            };
            return View(model);
        }

        [WebAuthorize]
        public ActionResult AdminPanel() {
            if (!User.IsAdmin) {
                return Redirect("/");
            }

            var result = BloodSearchModelsRemoteProvider.GetOffers(new GetOffersByFiltersParameters {
                Filter = new SearchFilter {
                    Sort = SearchFilter.SortEnum.Default,
                    Type = OfferTypeEnum.Any,
                    Statuses = new List<OfferStateEnum> { OfferStateEnum.New }
                },
                PagingFilter = new PagingFilter {
                    PageNumber = 1,
                    PageSize = 100
                }
            });

            var model = new AdminPanelResponse {
                Items = result.Offers,
                TotalCount = result.TotalCount
            };

            return View(model);
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
    }
}