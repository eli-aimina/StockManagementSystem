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
    public partial class ViewUi : Form
    {
        StockOutManager _stockOutManager = new StockOutManager();

        public ViewUi()
        {
            InitializeComponent();
        }

        private void ViewSearchButton_Click(object sender, EventArgs e)
        {
            String FromDate = FromDateTimePicker.Text;
            String ToDate = ToDateTimePicker.Text;

            String SoType = "Sold";
            if (SoldRadioButton.Checked == true)
            {
                SoType = "Sold";
            }
            else if (DamageRadioButton.Checked == true)
            {
                SoType = "Damaged";
            }
            else if (LostRadioButton.Checked == true)
            {
                SoType = "Lost";
            }

            viewDataGridView.DataSource = _stockOutManager.SearchStockOut(SoType, FromDate, ToDate);
        }
    }
}
