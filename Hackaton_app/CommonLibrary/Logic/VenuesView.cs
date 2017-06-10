using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Logic
{
   public class VenuesView
    {
        public List<Database.Type> listOfType { get; set; }
        public List<Database.Disability_Level> venueVisibility { get; set; }
    }
}
