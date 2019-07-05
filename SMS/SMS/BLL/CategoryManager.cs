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
    public class CategoryManager
    {
        SmsRepository _smsRepository = new SmsRepository();

        public int InsertCategory(Category category)
        {
            return _smsRepository.InsertCategory(category);
        }

        public int CountCategoryByName(Category category)
        {
            return _smsRepository.CountCategoryByName(category);
        }

        public DataTable ShowCategory()
        {
            return _smsRepository.ShowCategory();
        }

        public int EditCategory(Category category)
        {
            return _smsRepository.EditCategory(category);
        }

        public int DeleteCategory(Category category)
        {
            return _smsRepository.DeleteCategory(category);
        }
    }
}
