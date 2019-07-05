using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class StockItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ReorderLevel { get; set; }
        public int CategoryID { get; set; }
        public string Category { get; set; }
        public int CompanyID { get; set; }
        public string Company { get; set; }




    }
}
