using System.Web.Mvc;

namespace Web.Controllers {

    public class MainPageController : BaseController {

        public ActionResult Index() {
            return View();
        }
    }
}