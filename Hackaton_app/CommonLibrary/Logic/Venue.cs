using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Logic
{
    public class Venue
    {
        public static Database.Venue GetById(int id)
        {
            using (var db = new DatabaseContent())
                return db.Venues.FirstOrDefault(x => x.Id.Equals(id));
        }

        public static List<Database.Venue> GetList()
        {
            using (var db = new DatabaseContent())
                return db.Venues.ToList();
        }
        
        
        
    }
}
