using BloodSearch.Core.Models;
using BloodSearch.Models.Api.Models.Auth.Response;
using System.Linq;
using System.Web.Http.ModelBinding;

namespace Web.Extensions {

    public static class ModelStateExtension {

        public static BaseResponse GetBaseResponse(this ModelStateDictionary modelState) {
            var i = 0;
            return new BaseResponse() {
                Success = false,
                ErrMessages = modelState.Values.SelectMany(v => v.Errors).Select(_ => new KeyMsg() { Key = i++, Message = _.ErrorMessage }).ToList()
            };
        }

        public static LoginResult GetLoginResult(this ModelStateDictionary modelState) {
            var i = 0;
            return new LoginResult() {
                Success = false,
                ErrMessages = modelState.Values.SelectMany(v => v.Errors).Select(_ => new KeyMsg() { Key = i++, Message = _.ErrorMessage }).ToList()
            };
        }
    }
}