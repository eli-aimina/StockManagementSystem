using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SMS.Models;

namespace SMS.Repository
{
    
    public class CompanyRepository
    {

       private SqlConnection sqlConnection;
       private string connectionString = @"Server=RAKIB\SQLEXPRESS; Database=StockManagementSystem; Integrated Security=True";

       private SqlCommand sqlCommand;
        string commandString;
       

        public void SaveCategory(Company category)
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"insert into Company (Name) values('" + category.Name+"')";
            sqlCommand = new SqlCommand(commandString,sqlConnection);

            sqlConnection.Open();
           
             sqlCommand.ExecuteNonQuery();
           
            sqlConnection.Close();

          
        }
       
        public DataTable ShowCategory()
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"Select * from Company";
            sqlCommand = new SqlCommand(commandString,sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           
            

            sqlConnection.Close();

            return dataTable;

        }

    }
}

