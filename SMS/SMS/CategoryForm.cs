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

namespace SMS
{
    public partial class CategoryForm : Form
    {
       

        CategoryManager _categoryManager = new CategoryManager();
        private Category category;
        private object displayDataGridView;

        public CategoryForm()
        {
            InitializeComponent();
            category = new Category();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            this.ShowCategory();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            category.Name = categoryNameTextBox.Text;

            int isExecuted;
            isExecuted = _categoryManager.InsertCategory(category);
            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved!!");
            }

            this.ShowCategory();

        }

        private void ShowCategory()
        {
            categoryDataGridView.DataSource = _categoryManager.ShowCategory();
        }

       

    }
}
