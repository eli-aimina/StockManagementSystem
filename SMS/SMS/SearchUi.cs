using SMS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class SearchUI : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        CompanyManager _companyManager = new CompanyManager();
        ItemManager _itemManager = new ItemManager();

        private object categoryComboBox;

        public SearchUI()
        {
            InitializeComponent();
        }

        private void SearchUI_Load(object sender, EventArgs e)
        {
            searchCategoryComboBox.DataSource = _categoryManager.ShowCategory();
            searchCompanyComboBox.DataSource = _companyManager.ShowCompany();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int CategoryID = Convert.ToInt32(searchCategoryComboBox.SelectedValue);
            int CompanyID = Convert.ToInt32(searchCompanyComboBox.SelectedValue);

            searchDataGridView.DataSource = _itemManager.SearchItemSummary(CompanyID, CategoryID);

        }
    }
}
