using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
