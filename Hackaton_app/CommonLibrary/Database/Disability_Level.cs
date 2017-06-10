using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Database
{
    [Table("dis_levels")]
    public class Disability_Level
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DISABILITY")]
        public int Disability { get; set; }
        [Column("LEVEL")]
        public int Level { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("URL")]
        public string UrlToImage { get; set; }
    }
}
