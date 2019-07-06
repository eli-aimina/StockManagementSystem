using SMS.Models;
using SMS.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL
{
    public class StockOutManager
    {
        SmsRepository _smsRepository = new SmsRepository();
        
        public DataTable SearchStockOut(String SoType, String FromDate, String ToDate)
        {
            return _smsRepository.SearchStockOut(SoType, FromDate, ToDate);
        }
    }
}
