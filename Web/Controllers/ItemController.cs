using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Web.Mvc;

namespace Web.Controllers {

    public class ItemController : BaseController {

        public ActionResult Index(long id) {
            var model = new GetOfferResult();
            try {
                 model = BloodSearchModelsRemoteProvider.GetOffer(id);
            }
            catch {
                return Redirect("/");
            }
            return View(model);
        }
    }
}