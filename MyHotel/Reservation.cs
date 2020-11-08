using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MyHotel
{
    class Reservation
    {
        //Get all reservation
        Connect conn = new Connect();
        public DataTable getALlReserve()
        {
            SqlCommand command = new SqlCommand("Select * From reservation", conn.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool addReservation(int roomNum,int cId,DateTime dIn,DateTime dOut)
        {
            SqlCommand command = new SqlCommand();
            //   command.CommandText = "INSERT INTO [reservation] (roomNumber = @rnum,clientId = @cId,dataIn = @dateI,dateOut = @dateO))";
         string addReserv = "INSERT INTO [reservation] ([roomNumber],[clientId],[dataIn],[dateOut]) VALUES( '" + roomNum + "','" + cId + "','" + dIn + "','" + dOut + "' )";
            command.CommandText = addReserv;
            command.Connection = conn.getConnection();

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }else
            {
                conn.closeConnection();
                return false;
            }

           
        }
        //Function to edit the select reservation
        public bool editReservation(int reserveId,int roomNum, int clientId, DateTime dateIn, DateTime dateOut)
        {
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE [reservation] SET roomNumber = @rnum,clientId = @clientId,dataIn = @dateIn,dateOut = @dateOut WHERE reservationId =@reserveId";
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@reserveId", reserveId);
            command.Parameters.AddWithValue("@rnum", roomNum);
            command.Parameters.AddWithValue("@clientId", clientId);
            command.Parameters.AddWithValue("@dateIn", dateIn);
            command.Parameters.AddWithValue("@dateOut", dateOut);

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

        //function to delete reservation
        public bool deleteReservation(int reserveId)
        {
            SqlCommand command = new SqlCommand();

            command.CommandText = "DELETE FROM [dbo].[reservation] WHERE reservationId =@reserveId";
            command.Connection = conn.getConnection();

            command.Parameters.AddWithValue("@reserveId", reserveId);
           
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

