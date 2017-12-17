using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
//using Akula.Core.Models;
//using Auth.Api;
//using Auth.Api.Models.Request;
//using Auth.Api.Models.Response;
//using Newtonsoft.Json;
//using Web.Models;
//using Sender.Api;
//using Sender.Api.Models.Emails;
//using System.Collections.Generic;
//using Sender.Api.Models;
//using Web.Constants;
//using static Akula.Core.Utils.CommonUtils;
//using Sender.Api.Utils;

namespace Web.Infrastructure.Authorization {

    public class MembershipService {

        private const string AuthTokenCookieName = "token";

        private static HttpContext Context => HttpContext.Current;

        //    public static LoginResult Login(string email, string password) {
        //        if (!string.IsNullOrWhiteSpace(email))
        //            email = email.ToLower().Trim();

        //        var task = AkulaAuth.Login(Context, email, GetHash256(password));

        //        if (!task.IsAuth || !task.Success) {
        //            return new LoginResult() {
        //                Success = false,
        //                ErrMessages = task.ErrMessages
        //            };
        //        }
        //        return task;
        //    }

        //    public static BaseResponse Registration(string email, string password, string name = null, string phone = null) {
        //        if (!string.IsNullOrWhiteSpace(email))
        //            email = email.ToLower().Trim();

        //        if (!string.IsNullOrEmpty(name))
        //            name = name.Trim();

        //        if (!string.IsNullOrEmpty(phone))
        //            phone = phone.Trim();

        //        //            var hash = GetHash256(password);
        //        var task = AkulaAuth.Registration(Context, email, password, name, phone);
        //        if (!task.Success) {
        //            return new BaseResponse() {
        //                Success = false,
        //                ErrMessages = task.ErrMessages
        //            };
        //        }

        //        SendEmailUtil.TrySendEmailRegistration(email);

        //        Login(email, password);
        //        return new BaseResponse();
        //        //return new BaseResponse();
        //    }

        //    /// <summary>
        //    /// Отправка собщения на восстановление пароля
        //    /// </summary>
        //    public static BaseResponse ForgotPassword(string email) {
        //        if (!string.IsNullOrWhiteSpace(email))
        //            email = email.ToLower().Trim();

        //        var task = AkulaAuth.RequestRecoveryPassword(email);

        //        if (!task.Success) {
        //            return new BaseResponse() {
        //                Success = false,
        //                ErrMessages = task.ErrMessages
        //            };
        //        }

        //        return new BaseResponse();
        //    }

        //    /// <summary>
        //    /// Смена на новый пароль
        //    /// </summary>
        //    public static BaseResponse RestorePassword(string passwordRestoreHash, string password) {
        //        var task = AkulaAuth.ResponseRecoveryPassword(passwordRestoreHash, password);

        //        if (!task.Success) {
        //            return new BaseResponse() {
        //                Success = false,
        //                ErrMessages = task.ErrMessages
        //            };
        //        }

        //        return new BaseResponse();
        //    }

        //    /// <summary>
        //    /// выход
        //    /// </summary>
        //    public static void Logout() {
        //        //var ms = new MembershipService();
        //        SetCookie(AuthTokenCookieName, null, DateTime.Now.AddYears(-1));
        //        //ms._currentUser =  new WebUser();
        //    }

        //    private WebUser _currentUser;

        //    public WebUser CurrentUser {
        //        get {
        //            if (_currentUser != null)
        //                return _currentUser ?? (_currentUser = new WebUser());
        //            try {
        //                var userId = TryGetAdmishkaUserId();

        //                var task = userId > 0
        //                    ? AkulaAuth.GetById(userId)
        //                    : AkulaAuth.GetUserByContext(Context);

        //                if (!task.Success)
        //                    return _currentUser = new WebUser();

        //                return _currentUser = new WebUser(new TicketUserInfo() {
        //                    Email = task.Email,
        //                    UserId = task.Id,
        //                    Name = task.Name,
        //                    Phone = task.Phone,
        //                    Token = Context.Request.Cookies[AuthTokenCookieName]?.Value
        //                });

        //            } catch (Exception ex) {
        //                return _currentUser = new WebUser();
        //            }
        //        }
        //    }

        //    private int TryGetAdmishkaUserId() {
        //        var result = default(int);
        //        var admishkaUserId = Context.Request.Cookies[CookieKeys.AdmishkaUserId]?.Value;

        //        if (admishkaUserId == null)
        //            return result;

        //        int.TryParse(admishkaUserId, out result);

        //        return result;
        //    }

        //    /// <summary>
        //    /// Установить значение в куку
        //    /// </summary>
        //    /// <param name="cookieName">название куки</param>
        //    /// <param name="cookieValue">значение</param>
        //    /// <param name="dateStoreTo">дата окончания действия</param>
        //    public static void SetCookie(string cookieName, string cookieValue, DateTime dateStoreTo) {
        //        var cookie = HttpContext.Current.Response.Cookies[cookieName] ?? new HttpCookie(cookieName) { Path = "/" };
        //        cookie.Value = cookieValue;
        //        cookie.Expires = dateStoreTo;
        //        HttpContext.Current.Response.SetCookie(cookie);
        //    }

        //    /// <summary>
        //    /// хэш для пароля
        //    /// </summary>
        //    /// <param name="pass">пароль</param>
        //    /// <returns></returns>
        //    public static string GetHash256(string pass) {
        //        var inputBytes = Encoding.UTF8.GetBytes(pass);
        //        var hashedBytes = SHA256.Create().ComputeHash(inputBytes);
        //        return BitConverter.ToString(hashedBytes).Replace("-", "");
        //    }
        //}

        /// <summary>
        /// Информация о пользователе для куки тикета
        /// </summary>
        public class TicketUserInfo {
            public int UserId { get; set; }
            public string Email { get; set; }
            public string Token { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
        }
    }
}