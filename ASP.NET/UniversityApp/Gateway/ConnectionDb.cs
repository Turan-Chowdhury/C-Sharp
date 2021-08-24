using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UniversityApp.Gateway
{
    public class ConnectionDb
    {
        SqlConnection connection;

        public SqlConnection GetConnectionAndOpen()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-QC16PG4\SQLEXPRESS;Initial Catalog=UniversityDb;Integrated Security=True;MultipleActiveResultSets=True");
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
            {
                connection.Open();
            }

            return connection;
        }

        public void GetClose()
        {
            if(connection != null)
            {
                connection.Close();
            }
        }
    }
}