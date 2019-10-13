using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoneyWatchdog.Models;

namespace MoneyWatchdog.Models                  //Pg 214 for database Migration(creation) ASP.Net book
{
    public class MoneyWatchdog
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
