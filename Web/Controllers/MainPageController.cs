using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodSearch.Models.Api;
using BloodSearch.Models.Api.Models.Offers.Requests;
using BloodSearch.Models.Api.Models.Offers;

namespace Web.Controllers {

    public class MainPageController : Controller {

        public ActionResult Index() {

            BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
                Type = OfferTypeEnum.Donor,
                Offer = new OfferModel {
                    Description = "Тест №1",
                    Category = CategoryEnum.FirstNegative,
                    City = 31,
                    Contact = "+7 (910) 745 06 76",
                    Name = "Огиенко Е.Е."
                }
            });

            BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
                Type = OfferTypeEnum.Donor,
                Offer = new OfferModel {
                    Description = "Тест №2",
                    Category = CategoryEnum.FirstPositive,
                    City = 31,
                    Contact = "+7 (910) 745 06 76",
                    Name = "Огиенко Е.Е."
                }
            });

            BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
                Type = OfferTypeEnum.Donor,
                Offer = new OfferModel {
                    Description = "Тест №3",
                    Category = CategoryEnum.FourthNegative,
                    City = 2,
                    Contact = "+7 (910) 745 06 76",
                    Name = "Огиенко Е.Е."
                }
            });

            BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
                Type = OfferTypeEnum.Recipient,
                Offer = new OfferModel {
                    Description = "Тест №4",
                    Category = CategoryEnum.FirstNegative,
                    City = 1,
                    Contact = "+7 (910) 745 06 76",
                    Name = "Огиенко Е.Е."
                }
            });

            BloodSearchModelsRemoteProvider.AddOfferSync(new AddOfferModel {
                Type = OfferTypeEnum.Recipient,
                Offer = new OfferModel {
                    Description = "Тест №5",
                    Category = CategoryEnum.FirstNegative,
                    City = 31,
                    Contact = "+7 (910) 745 06 76",
                    Name = "Огиенко Е.Е."
                }
            });

            return View();
        }
    }
}