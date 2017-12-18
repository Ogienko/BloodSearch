using System.Web.Mvc;

namespace Web.Controllers {

    public class AccountController : Controller {

        public ActionResult Login() {
            return View();
        }

        public ActionResult Registration() {
            return View();
        }
    }
}