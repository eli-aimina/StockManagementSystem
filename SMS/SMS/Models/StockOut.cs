using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class StockOut
    {
        public int ID { get; set; }
        public string SoType { get; set; }
        public int SoQuantity { get; set; }
        public String CreatedDate { get; set; }
        public int ItemID { get; set; }
        public string Item { get; set; }
        public string Company { get; set; }
        
    }
}
