using System.Web;
using System.Web.Mvc;

namespace Web.Infrastructure.Authorization {

    public class WebAuthorizeAttribute : AuthorizeAttribute {

        public bool AllowAnonymus { get; set; }

        private WebUser User => new MembershipService().CurrentUser;

        protected override bool AuthorizeCore(HttpContextBase httpContext) {
            if (AllowAnonymus) {
                return true;
            }
            if (!User.IsAuthorized) {
                return false;
            }
            return true;
        }

        public override void OnAuthorization(AuthorizationContext filterContext) {
            if (!User.IsAuthorized && filterContext.HttpContext.Request.IsAjaxRequest()) {
                var model = new {
                    script = "<script>location.reload(true);</script>",
                    text = "reload",
                    isNotAuthorize = true,
                    error = true
                };
                filterContext.Result = new JsonResult() {
                    Data = model,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
                return;
            }
            if (!User.IsAuthorized) {
                filterContext.Result = new RedirectResult("/login/");
                return;
            }
            base.OnAuthorization(filterContext);
        }
    }
}