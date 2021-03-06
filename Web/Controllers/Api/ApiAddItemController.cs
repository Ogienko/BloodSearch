﻿using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System.Web.Http;
using Web.Models;

namespace Web.Controllers.Api {

    [RoutePrefix("api/add-item")]

    public class ApiAddItemController : BaseApiController {

        public const string RouteNameApiSaveItem = "AddItemSaveItem";

        [HttpPost]
        [Route("save/", Name = RouteNameApiSaveItem)]
        public AddOfferResult Save(AddItemRequest addItemRequest) {
            var model = addItemRequest.ToAddOfferModel(User.UserId);
            var result = BloodSearchModelsRemoteProvider.AddOfferSync(model);
            return result;
        }
    }
}