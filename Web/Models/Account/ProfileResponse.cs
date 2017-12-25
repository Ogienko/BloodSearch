using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Collections.Generic;

namespace Web.Models.Account {

    public class ProfileResponse {

        public string Email { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public List<GetOfferResult> Items { get; set; }
    }
}