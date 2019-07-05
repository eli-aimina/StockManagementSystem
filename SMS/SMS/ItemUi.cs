using SMS.BLL;
using SMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace SMS
{
    public partial class ItemUi : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        CompanyManager _companyManager = new CompanyManager();
        ItemManager _itemManager = new ItemManager();

        private StockItem item;
      
    
        public ItemUi()
        {
            InitializeComponent();
            item = new StockItem();
                
        }

        private void ItemUi_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _categoryManager.ShowCategory();
            companyComboBox.DataSource = _companyManager.ShowCompany();
            this.ShowItem();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            item.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
            item.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
            item.Name = itemNameTextBox.Text;
            item.ReorderLevel = 0;
            if (reorderLevelTextBox.Text != "") {
                item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
            }
            


            int ItemCount = _itemManager.CountItemByName(item);
            if (ItemCount == 0)
            {
                int isExecuted = _itemManager.InsertItem(item);
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved!!");
                }
            }
            else
            {
                MessageBox.Show(item.Name + " Already exists in  database.");
            }

            this.ShowItem();
        }

        private void ShowItem()
        {
            itemDataGridView.DataSource = _itemManager.ShowItem();
        }

        private void itemDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            itemDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
