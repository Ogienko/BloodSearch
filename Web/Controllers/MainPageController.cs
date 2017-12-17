using BloodSearch.Core.Extensions;
using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Offers;
using BloodSearch.Models.Api.Models.Offers.Requests;
using System;
using System.Web.Mvc;

namespace Web.Controllers {

    public class MainPageController : Controller {

        public ActionResult Index() {

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Donor,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Recipient,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Donor,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Recipient,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Donor,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Recipient,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Donor,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Recipient,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Donor,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            //BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
            //    Type = OfferTypeEnum.Recipient,
            //    Offer = new OfferModel {
            //        ContactName = "Огиенко Евгений",
            //        Category = CategoryEnum.FirstNegative,
            //        DateOfBirth = DateTime.Now,
            //        Weight = 80,
            //        Healthy = true,
            //        Description = "Тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест тест",
            //        Phone = StringExtensions.ParsePhone("+7 (910) 745 06 76"),
            //        Email = "ogienko@gmail.com",
            //        GeoCoderMeta = new BloodSearch.Models.Api.Models.Geo.GeoCoderMeta {
            //            FormattedAddress = "Россия, Белгород",
            //            Point = new BloodSearch.Models.Api.Models.Geo.GeoPoint {
            //                Lat = 44.23,
            //                Lng = 23.22
            //            }
            //        }
            //    }
            //});

            return View();
        }
    }
}