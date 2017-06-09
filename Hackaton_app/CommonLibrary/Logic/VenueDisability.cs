using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Logic
{
    public class VenueDisability
    {
        public static List<Database.Venue_disability> GetList(int venueId)
        {
            using (var db = new DatabaseContent())
                return db.VenueDisabilities.Where(x => x.VenueId.Equals(venueId)).ToList();
        }
    
    }
}
