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
    public partial class ItemUi : Form
    {
        CategoryManager _categoryManager = new CategoryManager();

        public ItemUi()
        {
            InitializeComponent();
        }

        private void ItemUi_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _categoryManager.ShowCategory();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
