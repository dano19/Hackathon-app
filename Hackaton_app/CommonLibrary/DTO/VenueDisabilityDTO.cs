using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.DTO
{
    
    public class VenueDisabilityDTO
    {
        public int Id { get; set; }
        public int VenueId { get; set; }
        public int Disability { get; set; }
        public int Level { get; set; }

        public String DisabilityDescription { get; set; }

        public String LevelDisabilityDescription { get; set; }
        
        public String UrlToIcon { get; set; }
    }
}
