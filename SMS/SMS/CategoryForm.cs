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

        int ID = 0;
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

            int CategoryCount = _categoryManager.CountCategoryByName(category);
            if (CategoryCount == 0)
            {
                int isExecuted = _categoryManager.InsertCategory(category);
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved!!");
                }
            }
            else {
                MessageBox.Show(category.Name+ " Already exists in  database.");
            }
            
            this.ShowCategory();

        }

        private void ShowCategory()
        {
            categoryDataGridView.DataSource = _categoryManager.ShowCategory();
        }
        
        /*
        private void categoryDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            categoryDataGridView.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }
        */
        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            categoryNameTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void CategoryEditButton_Click(object sender, EventArgs e)
        {
            category.ID = ID;
            category.Name = categoryNameTextBox.Text;

            int isExecuted;
            isExecuted = _categoryManager.EditCategory(category);
            if (isExecuted > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated!!");
            }

            this.ShowCategory();
        }

        private void CategoryDeleteButton_Click(object sender, EventArgs e)
        {
            category.ID = ID;

            int isExecuted;
            isExecuted = _categoryManager.DeleteCategory(category);
            if (isExecuted > 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted!!");
            }

            this.ShowCategory();
        }

        private void categoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            categoryDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void categoryDataGridView_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
