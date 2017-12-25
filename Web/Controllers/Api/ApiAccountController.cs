using BloodSearch.Core.Models;
using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Auth.Response;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Web.Extensions;
using Web.Infrastructure.Authorization;
using Web.Models.Account;

namespace Web.Controllers.Api {

    [RoutePrefix("api/account")]
    public class ApiAccountController : BaseApiController {

        public const string RouteNameApiLogin = "LoginPost";
        public const string RouteNameApiRegistration = "RegistrationPost";
        public const string RouteNameApiSaveProfile = "SaveProfilePost";
        public const string RouteNameApiDeleteOffer = "DeleteOffer";
        public const string RouteNameApiPublishOffer = "PublishOffer";

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

        [Route("profile/save/", Name = RouteNameApiSaveProfile)]
        public BaseResponse SaveProfile(ProfileViewModel request) {
            return User.UpdateProfileInfo(request);
        }

        [HttpGet]
        [Route("deleteitem/", Name = RouteNameApiDeleteOffer)]
        public DeleteOfferResult DeleteOffer(long offerId) {
            var result = BloodSearchModelsRemoteProvider.GetUserByContext(HttpContext.Current);

            if (!result.Success) {
                return new DeleteOfferResult {
                    Success = result.Success,
                    ErrMessages = result.ErrMessages.Select(x => new KeyValuePair<string, string>(x.Key.ToString(), x.Message)).ToList()
                };
            }

            var deleteOfferResult = BloodSearchModelsRemoteProvider.DeleteOffer(new DeleteOfferModel {
                OfferId = offerId,
                UserId = result.Id,
                IsAdmin = User.IsAdmin
            });

            if (!deleteOfferResult.Success) {
                return new DeleteOfferResult {
                    Success = deleteOfferResult.Success,
                    ErrMessages = deleteOfferResult.ErrMessages
                };
            }

            return deleteOfferResult;
        }

        [HttpGet]
        [Route("publishitem/", Name = RouteNameApiPublishOffer)]
        public PublishOfferResult PublishOffer(long offerId) {
            var result = BloodSearchModelsRemoteProvider.GetUserByContext(HttpContext.Current);

            if (!result.Success) {
                return new PublishOfferResult {
                    Success = result.Success,
                    ErrMessages = result.ErrMessages.Select(_ => new KeyValuePair<string, string>(_.Key.ToString(), _.Message)).ToList()
                };
            }

            var publishOfferResult = BloodSearchModelsRemoteProvider.PublishOffer(new PublishOfferModel() {
                OfferId = offerId,
                UserId = result.Id,
                IsAdmin = User.IsAdmin
            });

            if (!publishOfferResult.Success) {
                return new PublishOfferResult {
                    Success = publishOfferResult.Success,
                    ErrMessages = publishOfferResult.ErrMessages
                };
            }

            return publishOfferResult;
        }
    }
}