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
    public partial class ManageReservation : Form
    {
        public ManageReservation()
        {
            InitializeComponent();
        }

        Room room = new Room();
        Reservation reservation = new Reservation();
        private void ManageReservation_Load(object sender, EventArgs e)
        {
            //display room type
            comboBoxReservationRoomType.DataSource = room.roomTypeList();
            comboBoxReservationRoomType.DisplayMember = "label";
            comboBoxReservationRoomType.ValueMember = "category_id";
           
            //display room number on the selected type
            int type = Convert.ToInt32(comboBoxReservationRoomType.SelectedValue.ToString());
            comboBoxresrvationRoomNum.DataSource = room.roomByType(type);
            comboBoxresrvationRoomNum.DisplayMember = "roomNumber";
           comboBoxresrvationRoomNum.ValueMember = "roomNumber";
            //show all reservation in datagrid view
            dataGridView1.DataSource = reservation.getALlReserve();


        }

        private void btnClearReserveRoomfield_Click(object sender, EventArgs e)
        {

            txtMreservationClientId.Text = "";
            txtReservationId.Text = "";
          //  comboBoxReservationRoomType.SelectedIndex = 0;
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickeroiOut.Value = DateTime.Now;

        }

        private void comboBoxReservationRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display room number on the selected type
                int type = Convert.ToInt32(comboBoxReservationRoomType.SelectedValue.ToString());
                comboBoxresrvationRoomNum.DataSource = room.roomByType(type);
                comboBoxresrvationRoomNum.DisplayMember = "roomNumber";
                comboBoxresrvationRoomNum.ValueMember = "roomNumber";
              
            
            
            }
            catch (Exception)
            {
                //nothin to catch
            }
        }

        private void btnAddReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(txtMreservationClientId.Text);
                int roomNumber = Convert.ToInt32(comboBoxresrvationRoomNum.SelectedValue);
                DateTime dateIN = dateTimePickerIn.Value;
                DateTime dateOUT = dateTimePickeroiOut.Value;
              
                //date in must be = or > taday's date
                //date out must be = or> date in  
                if(dateIN.Day < DateTime.Now.Day)
                {
                    MessageBox.Show("The Date In Must be = or > taday's date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dateOUT.Day < dateIN.Day)
                {
                    MessageBox.Show("The Date Out Must be = or > To Date In", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientID, dateIN, dateOUT))
                    {
                        //set room free colomn to No
                        room.setRoomFree(roomNumber,"NO");
                        //shoe data in datagrid after adding 
                        dataGridView1.DataSource = reservation.getALlReserve();


                        MessageBox.Show("New Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("New Reservation not  Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ADD reservatio Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void btnEditReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int reserveId = Convert.ToInt32(txtReservationId.Text);
                int clientID = Convert.ToInt32(txtMreservationClientId.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                DateTime dateIN = dateTimePickerIn.Value;
                DateTime dateOUT = dateTimePickeroiOut.Value;

                //date in must be = or > taday's date
                //date out must be = or> date in  
                if (DateTime.Compare(dateIN.Date,DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("The Date In Must be = or > taday's date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateTime.Compare(dateOUT.Date,dateIN.Date) < 0)
                {
                    MessageBox.Show("The Date Out Must be = or > To Date In", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (reservation.editReservation(reserveId,roomNumber, clientID, dateIN, dateOUT))
                    {
                        //set room free colomn to No
                        dataGridView1.DataSource = reservation.getALlReserve();

                        room.setRoomFree(roomNumber,"NO");
                        MessageBox.Show("New Reservation Update", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("New Reservation not  Update", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ADD reservatio Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReservationId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMreservationClientId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //we needto select the combo of room type
            //we need to first know the type of room

            //get the room id
            int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            //select the room type from the combobox
            comboBoxReservationRoomType.SelectedValue = room.getRoomType(roomId);
            //select the room number from the combobox
            comboBoxresrvationRoomNum.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            // txtReservationId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            // txtReservationId.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerIn.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            dateTimePickeroiOut.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);

        }

        private void btnRemoveReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                int reserveId = Convert.ToInt32(txtReservationId.Text);
                if (reservation.deleteReservation(reserveId))
                {
                    dataGridView1.DataSource = reservation.getALlReserve();
                    //after deleting room set to free  colomn Yes
                    room.setRoomFree(roomNumber, "YES");



                    MessageBox.Show("Reservation Deleted", "Delete reservatio Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Reservation Not Deleted select row before deleting", "Delete reservatio Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete reservatio Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
