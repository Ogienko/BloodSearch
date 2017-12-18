using System.Web.Http;
using Web.Infrastructure.Authorization;

namespace Web.Controllers.Api {

    public class BaseApiController : ApiController {

        private WebUser _user;

        protected new WebUser User => _user ?? (_user = new MembershipService().CurrentUser);
    }
}