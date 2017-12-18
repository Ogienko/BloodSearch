using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Web.Infrastructure.Authorization;

namespace Web.Controllers.Api {

    public class BaseApiController : ApiController {

        private WebUser _user;

        protected new WebUser User => _user ?? (_user = new MembershipService().CurrentUser);

        protected UrlHelper MvcUrl {
            get {
                var httpContext = HttpContext.Current;

                if (httpContext == null) {
                    return null;
                }

                var httpContextBase = new HttpContextWrapper(httpContext);
                var routeData = new RouteData();
                var requestContext = new RequestContext(httpContextBase, routeData);

                return new UrlHelper(requestContext);
            }
        }
    }
}