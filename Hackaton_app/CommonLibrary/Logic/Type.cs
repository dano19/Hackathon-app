using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Logic
{
    public class Type
    {
        public static List<Database.Type> GetList()
        {
            using (var db = new DatabaseContent())
                return db.Types.ToList();
        }
    }
}
