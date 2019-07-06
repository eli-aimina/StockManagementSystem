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
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategorySetupButton_Click(object sender, EventArgs e)
        {
            CategoryUi categoryUi = new CategoryUi();
            categoryUi.ShowDialog();
        }

        private void CompanySetupButton_Click(object sender, EventArgs e)
        {
            CompanyUi companyUi = new CompanyUi();
            companyUi.ShowDialog();
        }

        private void ItemSetupButton_Click(object sender, EventArgs e)
        {
            ItemUi itemUi = new ItemUi();
            itemUi.ShowDialog();
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            StockInUi stockInUi = new StockInUi();
            stockInUi.ShowDialog();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            StockOutUi stockOutUi = new StockOutUi();
            stockOutUi.ShowDialog();
        }

        private void ItemSummaryButton_Click(object sender, EventArgs e)
        {
            SearchUI searchUI = new SearchUI();
            searchUI.ShowDialog();
        }

        private void ViewReportButton_Click(object sender, EventArgs e)
        {
            ViewUi viewUi = new ViewUi();
            viewUi.ShowDialog();
        }
    }
}
