using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;
namespace MyHotel
{

    // Manage room class
    class Room
    {
        //function to get list of rooms
        Connect conn = new Connect();
        public DataTable roomTypeList()
        {
            SqlCommand command = new SqlCommand("Select * From [rooms_category]", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }


        //create function to add new room
        public bool addRoom(int number  , int type, String phone, String free)
        {
            SqlCommand command = new SqlCommand();
            String insertQuery = "INSERT INTO [rooms] ([roomNumber],[type],[phone],[free]) VALUES( '" + number + "','" + type + "','" + phone + "','" + free + "' )";
            command.CommandText = insertQuery;
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
        //create function to get all rooms
        public DataTable getRooms()
        {
            SqlCommand command = new SqlCommand("Select * From [rooms]", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }
        //function to delete selected rooom
        public bool removeRoom(int number)
        {
            SqlCommand command = new SqlCommand();
            String deleteQuery = "DELETE [rooms]  WHERE roomNumber= @number";
            command.CommandText = deleteQuery;

            command.Parameters.AddWithValue("@number", number);

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

        //function to edit room
        public bool editRoom(int number, int type, String phone, String free)
        {
            SqlCommand command = new SqlCommand();
            String editQuery = "UPDATE [rooms]  SET type = @rtype,phone = @rphone,free = @rfree WHERE roomNumber= @rnum";
            command.CommandText = editQuery;

            command.Parameters.AddWithValue("@rnum", number);
            command.Parameters.AddWithValue("@rtype", type);
            command.Parameters.AddWithValue("@rphone", phone);
            command.Parameters.AddWithValue("@rfree", free);



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

    }
}
