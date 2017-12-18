using BloodSearch.Models.Api;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers {

    public class AddItemController : BaseController {

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