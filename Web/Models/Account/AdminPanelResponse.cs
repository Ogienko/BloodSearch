using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Collections.Generic;

namespace Web.Models.Account {

    public class AdminPanelResponse {

        public List<GetOfferResult> Items { get; set; }

        public long TotalCount { get; set; }
    }
}