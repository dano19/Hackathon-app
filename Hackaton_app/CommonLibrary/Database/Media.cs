using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("media")]
    public class Media
    {
        [Column("ID"), Key]
        public int Id { get; set; }
        [Column("VENUE")]
        public int VenueId { get; set; }
        [Column("SELECTED")]
        public bool IsDefault { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("DATA")]
        public string Location { get; set; } // Save file to App_Data

    }
}
