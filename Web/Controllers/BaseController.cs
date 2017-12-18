using System.Web.Mvc;
using Web.Infrastructure.Authorization;

namespace Web.Controllers {
    public class BaseController : Controller {

        private WebUser _user;

        protected new WebUser User => _user ?? (_user = new MembershipService().CurrentUser);
    }
}