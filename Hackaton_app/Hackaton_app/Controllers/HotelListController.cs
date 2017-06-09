using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackaton_app.Controllers
{
    public class HotelListController : Controller
    {
        // GET: HotelList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HotelList()
        {

            Models.HotelListModel hotelListData = new Models.HotelListModel()
            {
                Hotels = new List<Models.HotelItem>
            {
                new Models.HotelItem() { Name = "Gotyk House", Address = "Barowa 4" },
                new Models.HotelItem() { Name = "Some House", Address = "Piwna 4", }

            }
            };             
            return View("HotelListView", hotelListData);

        }
    }
}