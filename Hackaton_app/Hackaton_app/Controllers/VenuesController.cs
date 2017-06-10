using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonLibrary.Logic;

namespace Hackaton_app.Controllers
{
    public class VenuesController : Controller
    {
        public ActionResult RenderVenues()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult RenderVenues(String city, int typeOfDisablity, int type) {
            var venues = Venue.GetList();
            venues = FilterVenues(venues,city, typeOfDisablity, type);

            foreach (var venue in venues)
            {
                venue.MediaList = Media.GetList(venue.Id);
                venue.VenueDisabilties = VenueDisability.GetList(venue.Id);
            }
            return View("Venues", venues);
        }
        
        private List<CommonLibrary.Database.Venue> FilterVenues(List<CommonLibrary.Database.Venue> venuesToFilter, String city, int typeOfDisability, int type) {
            if (city != null) {
                venuesToFilter = venuesToFilter.Where(x => x.AddressCity.ToUpper().Equals(city.ToUpper())).ToList();
            }
            if (typeOfDisability > 0) {
                venuesToFilter = venuesToFilter.Where(x => x.VenueDisabilties.Equals(typeOfDisability)).ToList();
            }
            if (type > 0) {
                venuesToFilter = venuesToFilter.Where(x => x.Type.Equals(type)).ToList();
            }
            return venuesToFilter;

        }


        #region Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(CommonLibrary.Logic.Type.GetList());
        }
        [HttpPost]
        public ActionResult Create(string name, int type, string description, string country, string city, string street, string phone, string email, string website, string facebook, string mapsPlaceId, HttpPostedFileBase[] files)
        {
            var result = Venue.Create(name, type, description, country, city, street, phone, email, facebook, website, mapsPlaceId);
            TempData["message"] = result;
            if (result.Success)
            {
                foreach (var item in files)
                {
                    var filename = CommonLibrary.Utility.Security.RandomKey(item.FileName) + $"{Path.GetExtension(item.FileName)}";
                    item.SaveAs($"{Server.MapPath("~/Content/hotels/")}{filename}");
                    Media.SaveToDatabase(result.ReturnId, filename);
                    // TODO: Improve this into drag and drop / Saving the file on server in temp and removing of adding failed / Save in batches
                }
                return RedirectToAction("Details", "Venues", new { id = result.ReturnId });
            }
            return RedirectToAction("Create", "Venues");
        }
        #endregion
        
        public ActionResult Details(int id)
        {
            var venue = Venue.GetById(id);
            venue.MediaList = Media.GetList(venue.Id);
            return View("Details", venue);
        }

    }
}