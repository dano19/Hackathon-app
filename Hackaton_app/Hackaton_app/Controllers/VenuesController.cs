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
        // GET: Venue
        public ActionResult Index()
        {
            return View("Add");
        }

        public ActionResult RenderVenues() {

            Dictionary<CommonLibrary.Database.Venue, CommonLibrary.Database.Media> venueAndMainPicturePair = new Dictionary<CommonLibrary.Database.Venue, CommonLibrary.Database.Media>();
            foreach (CommonLibrary.Database.Venue venue in Venue.GetList()) {
                venueAndMainPicturePair.Add(venue, Media.GetDefaultPictureByVenueId(venue.Id));
            }
         
      
            return View("Venues", venueAndMainPicturePair);
        }


        public ActionResult Add()
        {
            return View();
        }

    }
}