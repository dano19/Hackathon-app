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


        public ActionResult Add()
        {
            return View();
        }

    }
}