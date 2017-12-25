using BloodSearch.Core.Models;
using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Auth.Request;
using System;
using System.Web;
using Web.Models.Account;

namespace Web.Infrastructure.Authorization {

    public class WebUser {

        public WebUser() { }

        public WebUser(TicketUserInfo ticketUserInfo) {
            Email = ticketUserInfo.Email;
            Token = ticketUserInfo.Token;
            UserId = ticketUserInfo.UserId;
            Phone = ticketUserInfo.Phone;
            Name = ticketUserInfo.Name;
        }

        public int UserId { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public bool IsAuthorized => !String.IsNullOrWhiteSpace(Email);

        public bool IsAdmin => !String.IsNullOrWhiteSpace(Email) && Email == "admin@admin.com";

        public BaseResponse UpdateProfileInfo(ProfileViewModel request) {

            var user = BloodSearchModelsRemoteProvider.GetUserByContext(HttpContext.Current);
            if (!user.Success) {
                return new BaseResponse() {
                    Success = false,
                    ErrMessages = user.ErrMessages
                };
            }

            var result = BloodSearchModelsRemoteProvider.EditUser(new EditUserRequest() {
                Token = Token,
                Name = request.Name,
                UserId = UserId,
                Phone = request.Phone
            });

            return result;
        }
    }
}