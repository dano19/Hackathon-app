using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Utility;

namespace CommonLibrary.Logic
{
    public class Media
    {
        public static Database.Media GetDefaultPictureByVenueId(int id)
        {
            using (var db = new DatabaseContent())
                return db.Medias.FirstOrDefault(x => x.VenueId.Equals(id) && x.IsDefault.Equals(1));
        }

        public static List<Database.Media> GetList()
        {
            using (var db = new DatabaseContent())
                return db.Medias.ToList();
        }

        public static StatusResult SaveToDatabase(int venueId, string location)
        {
            using (var db = new DatabaseContent())
            {
                var hasDefault = db.Medias.Count(x => x.VenueId == venueId && x.IsDefault);
                db.Medias.Add(new Database.Media() { Description = "", IsDefault = hasDefault == 0, Location = location, VenueId = venueId });
                db.SaveChanges();
                return new StatusResult(){ Success = true };
            }
        }
    }
}
