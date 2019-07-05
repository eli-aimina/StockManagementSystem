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
    public class CompanyManager
    {
        SmsRepository _smsRepository = new SmsRepository();

        public int InsertCompany(Company company)
        {
            return _smsRepository.InsertCompany(company);
        }

        public int CountCompanyByName(Company company)
        {
            return _smsRepository.CountCompanyByName(company);
        }

        public DataTable ShowCompany()
        {
            return _smsRepository.ShowCompany();
        }

        public int EditCompany(Company company)
        {
            return _smsRepository.EditCompany(company);
        }

        public int DeleteCompany(Company company)
        {
            return _smsRepository.DeleteCompany(company);
        }
    }
}
