using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Repository;
using SMS.Models;
using SMS.Bll;

namespace SMS
{
    public partial class CompanyForm : Form
    {


        CompanySetupManager _categorySetupManager = new CompanySetupManager();
        Company category= new Company();
        
        public CompanyForm()
        {
            InitializeComponent();
           

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
           category.Name = companyNameTextBox.Text;

            _categorySetupManager.SaveCategory(category);

            displayCompanyDataGridView.DataSource = _categorySetupManager.ShowCategory();

        }

      
    }
}
