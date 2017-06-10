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
            var venues = Venue.GetList();
            foreach (var venue in venues) {
                venue.MediaList = Media.GetList(venue.Id);
                venue.VenueDisabilties = VenueDisability.GetList(venue.Id);
            }

            return View("Venues", venues);
            }

        public ActionResult Details()
        {

            return View("Details");
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
        }
}