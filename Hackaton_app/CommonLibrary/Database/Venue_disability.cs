using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("venue_disability")]
    public class Venue_disability
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("VENUE")]
        public int VenueId { get; set; }
        [Column("DISABILITY")]
        public int Disability { get; set; }
        [Column("LEVEL")]
        public int Level { get; set; }
    }
}
