using BloodSearch.Filter.Models.Offers;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;

namespace Web.Models.SearchItems {

    public class SearchItemsIndexResponse {

        private readonly Regex RxPagingQueryParameter = new Regex(@"p=\d{1,}");
        private readonly string requestUrl;

        private readonly string urlWithoutPaging;

        public SearchItemsIndexResponse(HttpContext context) {
            requestUrl = context.Request.Url.PathAndQuery;
            urlWithoutPaging = RxPagingQueryParameter.Replace(requestUrl, string.Empty).Replace("&&", "&");

            var lastSymbol = urlWithoutPaging.Substring(urlWithoutPaging.Length - 1);
            if (lastSymbol == "?" || lastSymbol == "&") {
                urlWithoutPaging = urlWithoutPaging.Substring(0, urlWithoutPaging.Length - 1);
            }
        }

        public QueryParameters QueryParameters { get; set; }

        public List<GetOfferResult> Items { get; set; }

        public SearchFilter Filter { get; set; }

        public PagingFilter PagingFilter { get; set; }

        public long TotalCount { get; set; }

        public string GetUrlByWithPageNumber(int pageNumber) {
            if (pageNumber <= 1) {
                return urlWithoutPaging;
            }

            if (urlWithoutPaging.Contains("?")) {
                return urlWithoutPaging + "&p=" + pageNumber;
            } else {
                return urlWithoutPaging + "?p=" + pageNumber;
            }
        }
    }
}