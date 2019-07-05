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
    public partial class CompanyUi : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        private Company company;
        private object displayDataGridView;

        int ID = 0;
        public CompanyUi()
        {
            InitializeComponent();
            company = new Company();
        }

        private void CompanyUi_Load(object sender, EventArgs e)
        {
            this.ShowCompany();
        }

        private void CompanySaveButton_Click(object sender, EventArgs e)
        {
            company.Name = companyNameTextBox.Text;

            int CompanyCount = _companyManager.CountCompanyByName(company);
            if (CompanyCount == 0)
            {
                int isExecuted = _companyManager.InsertCompany(company);
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
                MessageBox.Show(company.Name + " Already exists in  database.");
            }

            this.ShowCompany();

        }

        private void ShowCompany()
        {
            companyDataGridView.DataSource = _companyManager.ShowCompany();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(companyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            companyNameTextBox.Text = companyDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void CompanyEditButton_Click(object sender, EventArgs e)
        {
            company.ID = ID;
            company.Name = companyNameTextBox.Text;

            int isExecuted;
            isExecuted = _companyManager.EditCompany(company);
            if (isExecuted > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated!!");
            }

            this.ShowCompany();
        }

        private void CompanyDeleteButton_Click(object sender, EventArgs e)
        {
            company.ID = ID;

            int isExecuted;
            isExecuted = _companyManager.DeleteCompany(company);
            if (isExecuted > 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted!!");
            }

            this.ShowCompany();
        }

        private void companyDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            companyDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
