using BloodSearch.Filter.Models.Offers;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;

namespace Web.Models.SearchItems {

    public class ProfileIndexResponse {

        public string Email { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public List<GetOfferResult> Items { get; set; }
    }
}