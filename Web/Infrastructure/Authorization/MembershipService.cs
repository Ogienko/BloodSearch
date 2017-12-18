using BloodSearch.Core.Models;
using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Auth.Response;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Web.Infrastructure.Authorization {

    public class MembershipService {

        private const string AuthTokenCookieName = "token";

        private static HttpContext Context => HttpContext.Current;

        public static LoginResult Login(string email, string password) {
            if (!String.IsNullOrWhiteSpace(email)) {
                email = email.ToLower().Trim();
            }

            var task = BloodSearchModelsRemoteProvider.Login(Context, email, GetHash256(password));

            if (!task.IsAuth || !task.Success) {
                return new LoginResult() {
                    Success = false,
                    ErrMessages = task.ErrMessages
                };
            }

            return task;
        }

        public static BaseResponse Registration(string email, string password, string name = null, string phone = null) {
            if (!String.IsNullOrWhiteSpace(email)) {
                email = email.ToLower().Trim();
            }

            if (!String.IsNullOrEmpty(name)) {
                name = name.Trim();
            }

            if (!String.IsNullOrEmpty(phone)) {
                phone = phone.Trim();
            }

            var task = BloodSearchModelsRemoteProvider.Registration(Context, email, GetHash256(password), name, phone);

            if (!task.Success) {
                return new BaseResponse() {
                    Success = false,
                    ErrMessages = task.ErrMessages
                };
            }

            Login(email, password);
            return new BaseResponse();
        }

        public static void Logout() {
            SetCookie(AuthTokenCookieName, null, DateTime.Now.AddYears(-1));
        }

        private WebUser _currentUser;

        public WebUser CurrentUser {
            get {
                if (_currentUser != null) {
                    return _currentUser ?? (_currentUser = new WebUser());
                }
                try {
                    var userId = TryGetAdmishkaUserId();

                    var task = userId > 0
                        ? BloodSearchModelsRemoteProvider.GetUserById(userId)
                        : BloodSearchModelsRemoteProvider.GetUserByContext(Context);

                    if (!task.Success) {
                        return _currentUser = new WebUser();
                    }

                    return _currentUser = new WebUser(new TicketUserInfo() {
                        Email = task.Email,
                        UserId = task.Id,
                        Name = task.Name,
                        Phone = task.Phone,
                        Token = Context.Request.Cookies[AuthTokenCookieName]?.Value
                    });
                } catch (Exception ex) {
                    return _currentUser = new WebUser();
                }
            }
        }

        private int TryGetAdmishkaUserId() {
            var result = default(int);
            var admishkaUserId = Context.Request.Cookies["AdmishkaUserIdTempCookieKey"]?.Value;

            if (admishkaUserId == null)
                return result;

            int.TryParse(admishkaUserId, out result);

            return result;
        }

        public static void SetCookie(string cookieName, string cookieValue, DateTime dateStoreTo) {
            var cookie = HttpContext.Current.Response.Cookies[cookieName] ?? new HttpCookie(cookieName) { Path = "/" };
            cookie.Value = cookieValue;
            cookie.Expires = dateStoreTo;
            HttpContext.Current.Response.SetCookie(cookie);
        }

        public static string GetHash256(string password) {
            var inputBytes = Encoding.UTF8.GetBytes(password);
            var hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes).Replace("-", "");
        }
    }

    public class TicketUserInfo {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}