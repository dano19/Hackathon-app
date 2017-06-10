using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("venue")]
    public class Venue
    {
        [Column("ID"), Key]
        public int Id { get; set; }
        [Column("TYPE")]
        public int Type { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("REVISION_DATE")]
        public DateTime RevisionDate { get; set; }
        [Column("USER")]
        public int User { get; set; }
        
        [Column("STREET")]
        public string AddressStreet { get; set; }
        [Column("CITY")]
        public string AddressCity { get; set; }
        [Column("COUNTRY")]
        public string AddressCountry { get; set; }
        [Column("PLACE_ID")]
        public string PlaceId { get; set; }
        
        [Column("PHONE")]
        public string PhoneNumber { get; set; }
        [Column("MAIL")]
        public string Email { get; set; }
        [Column("WWW")]
        public string Website { get; set; }
        [Column("FB")]
        public string Facebook { get; set; }

        [NotMapped]
        public List<Database.Media> MediaList = new List<Media>();

        [NotMapped]
        public List<DTO.VenueDisabilityDTO> VenueDisabilties = new List<DTO.VenueDisabilityDTO>();
        [NotMapped]
        public List<Database.Comment> Comments = new List<Comment>();
    }
}
