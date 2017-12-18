using BloodSearch.Core.Models;
using BloodSearch.Models.Api.Models.Auth.Response;
using System.Web.Http;
using Web.Extensions;
using Web.Infrastructure.Authorization;
using Web.Models.Account;

namespace Web.Controllers.Api {

    [RoutePrefix("api/account")]
    public class ApiAccountController : BaseApiController {

        public const string RouteNameApiLogin = "LoginPost";
        public const string RouteNameApiRegistration = "RegistrationPost";
        public const string RouteNameApiProfile = "ProfilePost";
        public const string RouteNameApiSaveProfile = "SaveProfilePost";

        [Route("login/", Name = RouteNameApiLogin)]
        public LoginResult Login(LoginViewModel request) {
            if (!ModelState.IsValid) {
                return ModelState.GetLoginResult();
            }

            return MembershipService.Login(request.Email, request.Password);
        }

        [Route("registration/", Name = RouteNameApiRegistration)]
        public BaseResponse Registration(RegisterViewModel request) {
            if (!ModelState.IsValid) {
                return ModelState.GetBaseResponse();
            }

            return MembershipService.Registration(request.Email, request.Password, request.Name, request.Phone);
        }

        //[Route("profile/", Name = RouteNameApiProfile)]
        //public BaseResponse<ProfileViewModel> GetProfile() {
        //    var res = Auth.Api.AkulaAuth.GetUserByContext(HttpContext.Current);
        //    if (!res.Success)
        //        return new BaseResponse<ProfileViewModel>(res);

        //    return new BaseResponse<ProfileViewModel>(new ProfileViewModel {
        //        Email = res.Email,
        //        Name = res.Name,
        //        Phone = res.Phone
        //    });
        //}

        //[Route("profile/save/", Name = RouteNameApiSaveProfile)]
        //public BaseResponse SaveProfile(ProfileViewModel request) {
        //    var res = User.UpdateProfileInfo(request);
        //    return res;
        //}
    }
}