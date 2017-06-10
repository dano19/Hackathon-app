using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Logic
{
    public class Disability
    {
        public static List<Database.Disability> GetList()
        {
            using (var db = new DatabaseContent())
                return db.Disabilities.ToList();
        }


   

    }
}
