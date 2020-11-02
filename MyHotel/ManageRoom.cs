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
    public partial class ManageRoom : Form
    {
        public ManageRoom()
        {
            InitializeComponent();
        }

        Room room = new Room();
        private void ManageRoom_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            dataGridView1.DataSource = room.getRooms();

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int number;
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
          string phone = txtRoomPhone.Text;
            string free = "";
            if (radioButtonYes.Checked)
            {
                free = "YES";

            }
            else if (radioButtonNo.Checked)
            {
                free = "NO";
            }
            try
            {
                number = Convert.ToInt32(txtRooomNumber.Text);
                if (room.addRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();

                    MessageBox.Show("Room added successfully", "Add Room ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problem adding room ", "Add Room ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Adding roo format is not correct try again", "ADD Room ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            int number =0 ;
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());

            string phone = txtRoomPhone.Text;
            string free =" ";
            if (radioButtonYes.Checked)
            {
                free = "YES";

            }
            else if(radioButtonNo.Checked)
            {
                free = "NO";
            }
            try
            {
                number = Convert.ToInt32(txtRooomNumber.Text);


                if (number.Equals("") || phone.Trim().Equals("") || type.Equals("")  )
                {
                    MessageBox.Show("Field cant not be empty", "Room Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    Boolean editRoom = room.editRoom(number,type,phone,free);
                    if (editRoom)
                    {
                        dataGridView1.DataSource = room.getRooms();
                        MessageBox.Show("New Room Update Successfully", "Room Updateed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" Room not Updated", "Room Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Select any row to update", "Updation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtRooomNumber.Text);
                if (room.removeRoom(id))
                {

                    dataGridView1.DataSource = room.getRooms();
                    // Clear fields after remove
                    btnClearRoomfield_Click(sender, e);

                    MessageBox.Show("Room is Deleted Successfully", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Error to  Deleted Room", "Error Delete Romm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClearRoomfield_Click(object sender, EventArgs e)
        {
            txtRooomNumber.Text = "";
            txtRoomPhone.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            radioButtonYes.Checked = true;

        }

        //display selected row from datagridview tptextbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRooomNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            txtRoomPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (free.Equals("YES"))
            {
                radioButtonYes.Checked = true;
            }
            else if (free.Equals("NO"))
            {
                radioButtonNo.Checked = true;
            }
        }
    }
}
