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
    
    public class CategoryRepository
    {

       private SqlConnection sqlConnection;
       private string connectionString = @"Server=RAKIB\SQLEXPRESS; Database=StockManagementSystem; Integrated Security=True";

       private SqlCommand sqlCommand;
        //private SqlCommand duplicate;
        string commandString;
       

        public void SaveCategory(Category category)
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"insert into Category(Name) values('"+category.Name+"')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

           // string uniquecheck = @"SELECT ('"+category.ID+"','" + category.Name + "'),COUNT(*) FROM Category GROUP BY ('" + category.Name + "') HAVING  (COUNT(*)>1)";
            //duplicate = new SqlCommand(uniquecheck, sqlConnection);

            
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
           /*int records= duplicate.ExecuteNonQuery();
            
            if ( records> 1)
            {
                MessageBox.Show("alreaddy exist");
            }
            else
            {
                MessageBox.Show("not exist");
            }*/
           
            sqlConnection.Close();

          
        }
       
        public DataTable ShowCategory()
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"Select * from Category";
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

