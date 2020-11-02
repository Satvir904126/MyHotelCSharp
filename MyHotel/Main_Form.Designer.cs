namespace MyHotel
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Form_Form_Closing = new System.Windows.Forms.MenuStrip();
            this.manageClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Form_Form_Closing.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Form_Form_Closing
            // 
            this.Main_Form_Form_Closing.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_Form_Form_Closing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClientToolStripMenuItem,
            this.manageReservationToolStripMenuItem,
            this.manageRoomToolStripMenuItem});
            this.Main_Form_Form_Closing.Location = new System.Drawing.Point(0, 0);
            this.Main_Form_Form_Closing.Name = "Main_Form_Form_Closing";
            this.Main_Form_Form_Closing.Size = new System.Drawing.Size(800, 28);
            this.Main_Form_Form_Closing.TabIndex = 1;
            this.Main_Form_Form_Closing.Text = "menuStrip1";
            // 
            // manageClientToolStripMenuItem
            // 
            this.manageClientToolStripMenuItem.Name = "manageClientToolStripMenuItem";
            this.manageClientToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.manageClientToolStripMenuItem.Text = "Manage Client";
            this.manageClientToolStripMenuItem.Click += new System.EventHandler(this.manageClientToolStripMenuItem_Click);
            // 
            // manageReservationToolStripMenuItem
            // 
            this.manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            this.manageReservationToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.manageReservationToolStripMenuItem.Text = "Manage Reservation";
            this.manageReservationToolStripMenuItem.Click += new System.EventHandler(this.manageReservationToolStripMenuItem_Click);
            // 
            // manageRoomToolStripMenuItem
            // 
            this.manageRoomToolStripMenuItem.Name = "manageRoomToolStripMenuItem";
            this.manageRoomToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.manageRoomToolStripMenuItem.Text = "Manage Room";
            this.manageRoomToolStripMenuItem.Click += new System.EventHandler(this.manageRoomToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_Form_Form_Closing);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Main_Form_Form_Closing;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClose);
            this.Main_Form_Form_Closing.ResumeLayout(false);
            this.Main_Form_Form_Closing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_Form_Form_Closing;
        private System.Windows.Forms.ToolStripMenuItem manageClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomToolStripMenuItem;
    }
}