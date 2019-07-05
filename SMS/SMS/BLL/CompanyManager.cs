using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SMS.Repository;
using SMS.Models;

namespace SMS.Bll
{
    public class CompanySetupManager
    {
        CompanyRepository _categorySetup = new CompanyRepository();

        public void SaveCategory(Company category)
        {
            _categorySetup.SaveCategory(category);
        }

        public DataTable ShowCategory()
        {
            return _categorySetup.ShowCategory();
        }
    }
}
