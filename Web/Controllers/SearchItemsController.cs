using BloodSearch.Filter.Models.Offers;
using BloodSearch.Filter.Utils;
using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Web.Mvc;
using Web.Models.SearchItems;

namespace Web.Controllers {

    public class SearchItemsController : BaseController {

        public ActionResult Index(QueryParameters parameters) {

            var model = new SearchItemsIndexResponse(System.Web.HttpContext.Current) {
                QueryParameters = parameters
            };

            var filters = OffersQueryParamsUtils.ParseFilterFromQueryParameters(parameters);

            model.Filter = filters.Filter;

            model.PagingFilter = filters.PagingFilter;

            var result = BloodSearchModelsRemoteProvider.GetOffers(new GetOffersByFiltersParameters {
                Filter = filters.Filter,
                PagingFilter = filters.PagingFilter
            });

            model.Items = result.Offers;

            model.TotalCount = result.TotalCount;

            return View(model);
        }
    }
}