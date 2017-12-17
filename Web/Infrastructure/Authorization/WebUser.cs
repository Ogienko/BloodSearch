using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Akula.Core.Models;
//using Auth.Api;
//using Auth.Api.Models.Request;
using Web.Models;

namespace Web.Infrastructure.Authorization {

    /// <summary>
    /// Пользователь в приложении
    /// </summary>
    public class WebUser {

        public WebUser() {
            //Role = UserRole.Unknown;
        }

        //public WebUser(TicketUserInfo ticketUserInfo) {
        //    Email = ticketUserInfo.Email;
        //    Token = ticketUserInfo.Token;
        //    UserId = ticketUserInfo.UserId;
        //    Phone = ticketUserInfo.Phone;
        //    Name = ticketUserInfo.Name;
        //}

        public int UserId { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Токен
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Авторизован пользователь или нет
        /// </summary>
        public bool IsAuthorized => !string.IsNullOrWhiteSpace(Email);

        ///// <summary>
        ///// обновить данные пользователя
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //public BaseResponse UpdateProfileInfo(ProfileViewModel request) {
        //    if (!IsAuthorized)
        //        return new BaseResponse() {
        //            Success = false,
        //            ErrMessages = new List<KeyMsg>()
        //            {
        //                new KeyMsg() {Key = 1, Message = "Необходимо авторизоваться."}
        //            }
        //        };
        //    var user = AkulaAuth.GetUserByContext(HttpContext.Current);
        //    if (!user.Success)
        //        return new BaseResponse() {
        //            Success = false,
        //            ErrMessages = user.ErrMessages
        //        };
        //    //if (!string.IsNullOrWhiteSpace(user.Name) && !string.IsNullOrWhiteSpace(user.Phone))
        //    //    return new BaseResponse();
        //    //var name = string.IsNullOrWhiteSpace(user.Name) ? request.Name: user.Name;
        //    //var phone = string.IsNullOrWhiteSpace(user.Phone) ? request.Phone : user.Phone;
        //    var res = AkulaAuth.EditUser(new EditUserRequest() {
        //        Token = Token,
        //        Name = request.Name,
        //        UserId = UserId,
        //        Phone = request.Phone
        //    });
        //    return res;
        //}
    }
}