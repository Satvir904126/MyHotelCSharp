using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotel
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connect conn =new Connect();
            
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
           String query = "Select count(*) from [users] where username = '" + txtUserName.Text + "'and password = '" + txtPassword.Text + "'";
           // String query = "Select count(*) from [users] where username = @usn and password = @pass";



            //command.CommandText = query;
            //command.Connection = conn.getConnection();

            //command.Parameters.Add("@usn", SqlDbType.VarChar).Value = txtUserName.Text;
            //command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn.getConnection());

            //adapter.SelectCommand = command;
            adapter.Fill(table);

            //if user name and password exist
             if (table.Rows[0][0].ToString() == "1")

                {
                this.Hide();
                Main_Form main =  new Main_Form();
                main.Show();
            }
            else
            {
                if (txtUserName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter the user name", "Empty User name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else if (txtPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter the password", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username or password not exist", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
