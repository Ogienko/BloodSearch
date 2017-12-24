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
                var getOfferResult = BloodSearchModelsRemoteProvider.GetOffer(id.Value);
                model = AddItemRequest.FromOfferResult(getOfferResult);
            }

            return View(model);
        }
    }
}