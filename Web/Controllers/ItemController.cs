using BloodSearch.Models.Api;
using System.Web.Mvc;

namespace Web.Controllers {

    public class ItemController : Controller {

        public ActionResult Index(long id) {
            var model = BloodSearchModelsRemoteProvider.GetOffer(id);
            return View(model);
        }
    }
}