using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Logic
{
    public class DisabilityLevel
    {
        public static List<Database.Disability_Level> GetList()
        {
            using (var db = new DatabaseContent())
                return db.DisabilityLevel.ToList();
        }
    }
}
