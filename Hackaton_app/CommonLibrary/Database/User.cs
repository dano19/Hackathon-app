using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("users")]
    public class User
    {
        [Column("ID"), Key]
        public int Id { get; set; }
        [Column("FNAME")]
        public string Firstname { get; set; }
        [Column("LNAME")]
        public string Lastname { get; set; }
    }
}
