using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("User_DISAB")]
    public class User_Disability
    {
        [Column("USER")]
        public int UserId { get; set; }
        [Column("DISABILITY")]
        public int DisabilityId { get; set; }
    }
}
