using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Utility
{
    public class StatusResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int ReturnId { get; set; }
    }
}
