using BloodSearch.Core.Extensions;
using BloodSearch.Models.Api.Models.Geo;
using BloodSearch.Models.Api.Models.Offers;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System;

namespace Web.Models {

    public class AddItemRequest {

        public long Id { get; set; }

        public string Name { get; set; }

        public OfferTypeEnum Type { get; set; }

        public CategoryEnum Category { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Weight { get; set; }

        public bool Healthy { get; set; }

        public string Description { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public GeoAddress GeoAddress { get; set; }

        public AddOfferModel ToAddOfferModel(int? userId = null) {
            return new AddOfferModel {
                Id = Id,
                Type = Type,
                UserId = userId,
                Offer = new OfferModel {
                    ContactName = Name,
                    Category = Category,
                    DateOfBirth = DateOfBirth,
                    Weight = Weight,
                    Healthy = Healthy,
                    Description = Description,
                    Phone = StringExtensions.ParsePhone(Phone),
                    Email = Email,
                    GeoAddress = GeoAddress
                }
            };
        }

        public static AddItemRequest FromOfferResult(GetOfferResult getOfferResult) {
            return new AddItemRequest {
                Id = getOfferResult.Id,
                Name = getOfferResult.Offer.ContactName,
                Type = getOfferResult.Type,
                Category = getOfferResult.Offer.Category,
                DateOfBirth = getOfferResult.Offer.DateOfBirth,
                Weight = getOfferResult.Offer.Weight,
                Healthy = getOfferResult.Offer.Healthy,
                Description = getOfferResult.Offer.Description,
                Phone = getOfferResult.Offer.Phone.FormatedNumber,
                Email = getOfferResult.Offer.Email,
                GeoAddress = getOfferResult.Offer.GeoAddress
            };
        }
    }
}