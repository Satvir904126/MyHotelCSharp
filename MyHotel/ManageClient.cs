using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotel
{
    public partial class ManageClient : Form
    {


        Client client = new Client();
        public ManageClient()
        {
            InitializeComponent();
        }

        private void btnClearfield_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtPhone.Text = "";
            txtCountry.Text = "";
        }

        private void btnAddclient_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;
            String phone = txtPhone.Text;
            String country = txtCountry.Text;
            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
            {
                MessageBox.Show("Field cant not be empty", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Boolean insertClient = client.insertClient(fname, lname, phone, country);
                if (insertClient)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("New Client Added Successfully", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("New Client not Added", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void ManageClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

        private void btnEditclient_Click(object sender, EventArgs e)
        {
            int id;
            String fname = txtFname.Text;
            String lname = txtLname.Text;
            String phone = txtPhone.Text;
            String country = txtCountry.Text;
            try
            {
               id= Convert.ToInt32(txtId.Text);


                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("Field cant not be empty", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    Boolean editClient = client.editClient(id, fname, lname, phone, country);
                    if (editClient)
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("New Client Update Successfully", "Client Updateed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" Client not Updated", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Select any row to update", "Updation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        // dispaly the selected data
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
       txtFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCountry.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnRemoveclient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if (client.removeClient(id))
                {

                    dataGridView1.DataSource = client.getClients();
                    btnClearfield_Click(sender, e);

                    MessageBox.Show("Client Deleted Successfully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear fields after remove client
                }
                else
                {
                    MessageBox.Show("Error to  Deleted Client", "Error Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
