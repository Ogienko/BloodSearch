using System;
using System.Web.Mvc;

namespace Web.Infrastructure.Authorization {

    public class BaseViewPage : WebViewPage {

        private WebUser _user;

        public new WebUser User => _user ?? (_user = new MembershipService().CurrentUser);

        public bool IsAuthenticated => User.IsAuthorized;

        public override void Execute() {
            throw new NotImplementedException();
        }
    }

    public class BaseViewPage<TModel> : WebViewPage<TModel> {

        private WebUser _user;

        public new WebUser User => _user ?? (_user = new MembershipService().CurrentUser);

        public bool IsAuthenticated => User.IsAuthorized;

        public override void Execute() {
            throw new NotImplementedException();
        }
    }
}