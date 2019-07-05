﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.Repository
{
    public class SmsRepository
    {
        
        string connectionString = @"Server=DESKTOP-6PGBG54\SQLEXPRESS; Database=StockManagementSystem; Integrated Security=True";
        private SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;

        public SmsRepository()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int InsertCategory(Category category)
        {
            commandString = @"INSERT INTO Category (Name) VALUES ('" + category.Name + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            
            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int CountCategoryByName(Category category)
        {
            commandString = @"SELECT count(*) from Category where Name='" + category.Name + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int CategoryCount = Convert.ToInt32(sqlCommand.ExecuteScalar());

            sqlConnection.Close();

            return CategoryCount;
        }

        public DataTable ShowCategory()
        {
            commandString = @"SELECT * FROM Category";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            sqlConnection.Close();

            return dataTable;

        }

        public int EditCategory(Category category)
        {
            commandString = @"UPDATE Category SET Name='"+category.Name+"' WHERE ID='"+category.ID+"'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            
            sqlConnection.Close();

            return isExecuted;
        }

        public int DeleteCategory(Category category)
        {
            commandString = @"DELETE FROM Category WHERE ID='" + category.ID + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();


            sqlConnection.Close();

            return isExecuted;
        }
    }
}