using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyWatchdog.Models
{
    public class GetCsvData
    {
        public int CsvID { get; set; }
        public DateTime CsvDate { get; set; }
        public string CsvName { get; set; }
        public double CsvAmount { get; set; }
    }
}
