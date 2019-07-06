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
    public class ItemManager
    {
        SmsRepository _smsRepository = new SmsRepository();

        public int InsertItem(StockItem item)
        {
            return _smsRepository.InsertItem(item);
        }

        public int CountItemByName(StockItem item)
        {
            return _smsRepository.CountItemByName(item);
        }

        public DataTable ShowItem()
        {
            return _smsRepository.ShowItem();
        }

        public int EditItem(StockItem item)
        {
            return _smsRepository.EditItem(item);
        }

        public int DeleteItem(StockItem item)
        {
            return _smsRepository.DeleteItem(item);
        }

        //6.Search & View Items Summary 
        public DataTable SearchItemSummary(int CompanyID, int CategoryID)
        {
            return _smsRepository.SearchItemSummary(CompanyID, CategoryID);
        }
    }
}
