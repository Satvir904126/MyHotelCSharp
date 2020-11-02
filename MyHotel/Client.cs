using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

using System.Data;
namespace MyHotel
{
    class Client
    {
        Connect conn = new Connect();
        //function to insert a new client
        public bool insertClient(String fname,String lname, String phone, String country)
        {
            SqlCommand command = new SqlCommand();
            //String insertQuery = "INSERT INTO [clients] ([firstName],[lastName],[phone],[country]) VALUES('"+ fname +" ," + lname +","+ phone +"," + country +")";
            String insertQuery = "INSERT INTO [clients] ([firstName],[lastName],[phone],[country]) VALUES( '" + fname +"','"+ lname +"','"+ phone +"','"+ country +"' )";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();
            //command.Parameters.Add("");
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }



        }

        //Function get All Clients

        public DataTable getClients()
        {
            SqlCommand command = new SqlCommand("Select * From [clients]",conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        //create function for edit client data
        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            SqlCommand command = new SqlCommand();
            //String insertQuery = "UPDATE [clients]  SET ([firstName],[lastName],[phone],[country]) VALUES( '" + id + "','" + fname + "','" + lname + "','" + phone + "','" + country + "' )";
            String editQuery = "UPDATE [clients]  SET firstName = @fname, lastName= @lname, phone = @phone, country =@country WHERE id= @id";
            command.CommandText = editQuery;

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@lname", lname);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@country", country);



            command.Connection = conn.getConnection();
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        // delete client
        public bool removeClient(int id)
        {
            SqlCommand command = new SqlCommand();
            //String insertQuery = "UPDATE [clients]  SET ([firstName],[lastName],[phone],[country]) VALUES( '" + id + "','" + fname + "','" + lname + "','" + phone + "','" + country + "' )";
            String deleteQuery = "DELETE [clients]  WHERE id= @id";
            command.CommandText = deleteQuery;

            command.Parameters.AddWithValue("@id", id);

            command.Connection = conn.getConnection();
            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
 return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

    }
}
