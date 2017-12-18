using static Web.Infrastructure.Authorization.MembershipService;

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

        public bool IsAuthorized => !string.IsNullOrWhiteSpace(Email);
    }
}