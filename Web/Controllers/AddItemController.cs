using BloodSearch.Models.Api;
using System.Web.Mvc;
using Web.Infrastructure.Authorization;
using Web.Models;

namespace Web.Controllers {

    public class AddItemController : BaseController {

        [WebAuthorize]
        public ActionResult Index(long? id) {

            var model = new AddItemRequest();

            if (id.HasValue) {
                try {
                    var getOfferResult = BloodSearchModelsRemoteProvider.GetOffer(id.Value);
                    if (getOfferResult.UserId != User.UserId) {
                        return Redirect("/");
                    }
                    model = AddItemRequest.FromOfferResult(getOfferResult);
                } catch {
                    return Redirect("/");
                }
            } else {
                model.Name = User.Name;
                model.Phone = User.Phone;
                model.Email = User.Email;
            }

            return View(model);
        }
    }
}