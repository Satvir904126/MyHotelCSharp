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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_FormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }

        private void manageClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClient manageClient = new ManageClient();
            manageClient.ShowDialog();
        }

        private void manageReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservation manageReservation = new ManageReservation();
            manageReservation.ShowDialog();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoom manageRoom = new ManageRoom();
            manageRoom.ShowDialog();
        }
    }
}
