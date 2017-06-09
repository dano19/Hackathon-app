using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            Models.HotelListModel hotelListData = new Models.HotelListModel()
            {
                Hotels = new List<Models.HotelItem>
            {
                new Models.HotelItem() { Name = "Gotyk House", Address = "Barowa 4" },
                new Models.HotelItem() { Name = "Some House", Address = "Piwna 4", }

            }
            };
            return View("Venues", hotelListData);
        }


        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View("Details");
        }

    }
}