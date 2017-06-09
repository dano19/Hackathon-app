using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("types")]
    public class Type
    {
        [Column("ID"), Key]
        public int Id { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("DEFINITION")]
        public string Definition { get; set; }
    }
}
