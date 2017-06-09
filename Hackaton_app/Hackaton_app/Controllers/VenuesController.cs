using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonLibrary.Logic;

namespace Hackaton_app.Controllers
{
    public class VenuesController : Controller
    {
        public ActionResult Index()
        {
            return View("Create");
        }

        public ActionResult RenderVenues() {

            Dictionary<CommonLibrary.Database.Venue, CommonLibrary.Database.Media> venueAndMainPicturePair = new Dictionary<CommonLibrary.Database.Venue, CommonLibrary.Database.Media>();
            foreach (CommonLibrary.Database.Venue venue in Venue.GetList()) {
                venueAndMainPicturePair.Add(venue, Media.GetDefaultPictureByVenueId(venue.Id));
            }
         
      
            return View("Venues", venueAndMainPicturePair);
        }

        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string name, int type, string description, string country, string city, string street, string phone, string email, string facebook, string mapsPlaceId)
        {
            return View();
        }
#endregion
        public ActionResult Details()
        {
            return View("Details");
        }

    }
}