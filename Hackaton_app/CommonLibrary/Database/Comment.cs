using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("comments")]
    public class Comment
    {
        [Column("ID"), Key]
        public int Id { get; set; }
        
        [Column("VENUE")]
        public int VenueId { get; set; }
        [Column("USER")]
        public int UserId { get; set; }
        
        [Column("RATING")]
        public int Rating { get; set; }
        [Column("COMMENT")]
        public string CommentContent { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }
    }
}
