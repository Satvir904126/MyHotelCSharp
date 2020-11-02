using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotel
{
    class Connect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=CV0QFT2\SQLEXPRESSNEW;Initial Catalog=hotelmanagement;User ID=satvir;Password=904126satt;Pooling=False");

        //create function to return our cionnection
        public SqlConnection getConnection()
        {
            return connection;
        }
        //create a function to open the connection
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
               connection.Open();
            }
        }

        //create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }


    }
}
