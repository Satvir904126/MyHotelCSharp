namespace MyHotel
{
    partial class ManageReservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickeroiOut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxresrvationRoomNum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMreservationClientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxReservationRoomType = new System.Windows.Forms.ComboBox();
            this.btnClearReserveRoomfield = new System.Windows.Forms.Button();
            this.btnRemoveReserve = new System.Windows.Forms.Button();
            this.btnEditReserve = new System.Windows.Forms.Button();
            this.btnAddReserve = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReservationId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dateTimePickeroiOut);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePickerIn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxresrvationRoomNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMreservationClientId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxReservationRoomType);
            this.panel1.Controls.Add(this.btnClearReserveRoomfield);
            this.panel1.Controls.Add(this.btnRemoveReserve);
            this.panel1.Controls.Add(this.btnEditReserve);
            this.panel1.Controls.Add(this.btnAddReserve);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtReservationId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 589);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickeroiOut
            // 
            this.dateTimePickeroiOut.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickeroiOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickeroiOut.Location = new System.Drawing.Point(157, 417);
            this.dateTimePickeroiOut.Name = "dateTimePickeroiOut";
            this.dateTimePickeroiOut.Size = new System.Drawing.Size(228, 30);
            this.dateTimePickeroiOut.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date OUT";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.CustomFormat = "mm/dd/yyyy";
            this.dateTimePickerIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIn.Location = new System.Drawing.Point(157, 378);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(228, 30);
            this.dateTimePickerIn.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date IN";
            // 
            // comboBoxresrvationRoomNum
            // 
            this.comboBoxresrvationRoomNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxresrvationRoomNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxresrvationRoomNum.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxresrvationRoomNum.FormattingEnabled = true;
            this.comboBoxresrvationRoomNum.Location = new System.Drawing.Point(157, 328);
            this.comboBoxresrvationRoomNum.Name = "comboBoxresrvationRoomNum";
            this.comboBoxresrvationRoomNum.Size = new System.Drawing.Size(228, 31);
            this.comboBoxresrvationRoomNum.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Room Number";
            // 
            // txtMreservationClientId
            // 
            this.txtMreservationClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMreservationClientId.BackColor = System.Drawing.SystemColors.Info;
            this.txtMreservationClientId.Location = new System.Drawing.Point(158, 194);
            this.txtMreservationClientId.Name = "txtMreservationClientId";
            this.txtMreservationClientId.Size = new System.Drawing.Size(178, 22);
            this.txtMreservationClientId.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Client ID";
            // 
            // comboBoxReservationRoomType
            // 
            this.comboBoxReservationRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReservationRoomType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReservationRoomType.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxReservationRoomType.FormattingEnabled = true;
            this.comboBoxReservationRoomType.Location = new System.Drawing.Point(157, 277);
            this.comboBoxReservationRoomType.Name = "comboBoxReservationRoomType";
            this.comboBoxReservationRoomType.Size = new System.Drawing.Size(228, 31);
            this.comboBoxReservationRoomType.TabIndex = 16;
            this.comboBoxReservationRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxReservationRoomType_SelectedIndexChanged);
            // 
            // btnClearReserveRoomfield
            // 
            this.btnClearReserveRoomfield.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearReserveRoomfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearReserveRoomfield.Location = new System.Drawing.Point(96, 552);
            this.btnClearReserveRoomfield.MaximumSize = new System.Drawing.Size(180, 40);
            this.btnClearReserveRoomfield.MinimumSize = new System.Drawing.Size(164, 37);
            this.btnClearReserveRoomfield.Name = "btnClearReserveRoomfield";
            this.btnClearReserveRoomfield.Size = new System.Drawing.Size(164, 37);
            this.btnClearReserveRoomfield.TabIndex = 15;
            this.btnClearReserveRoomfield.Text = "Clear Feild";
            this.btnClearReserveRoomfield.UseVisualStyleBackColor = true;
            this.btnClearReserveRoomfield.Click += new System.EventHandler(this.btnClearReserveRoomfield_Click);
            // 
            // btnRemoveReserve
            // 
            this.btnRemoveReserve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveReserve.Location = new System.Drawing.Point(14, 509);
            this.btnRemoveReserve.MaximumSize = new System.Drawing.Size(180, 40);
            this.btnRemoveReserve.MinimumSize = new System.Drawing.Size(164, 37);
            this.btnRemoveReserve.Name = "btnRemoveReserve";
            this.btnRemoveReserve.Size = new System.Drawing.Size(164, 37);
            this.btnRemoveReserve.TabIndex = 14;
            this.btnRemoveReserve.Text = "Remove";
            this.btnRemoveReserve.UseVisualStyleBackColor = true;
            this.btnRemoveReserve.Click += new System.EventHandler(this.btnRemoveReserve_Click);
            // 
            // btnEditReserve
            // 
            this.btnEditReserve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReserve.Location = new System.Drawing.Point(183, 509);
            this.btnEditReserve.MaximumSize = new System.Drawing.Size(180, 40);
            this.btnEditReserve.MinimumSize = new System.Drawing.Size(164, 37);
            this.btnEditReserve.Name = "btnEditReserve";
            this.btnEditReserve.Size = new System.Drawing.Size(164, 37);
            this.btnEditReserve.TabIndex = 13;
            this.btnEditReserve.Text = "Edit";
            this.btnEditReserve.UseVisualStyleBackColor = true;
            this.btnEditReserve.Click += new System.EventHandler(this.btnEditReserve_Click);
            // 
            // btnAddReserve
            // 
            this.btnAddReserve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReserve.Location = new System.Drawing.Point(15, 459);
            this.btnAddReserve.MaximumSize = new System.Drawing.Size(348, 37);
            this.btnAddReserve.MinimumSize = new System.Drawing.Size(348, 37);
            this.btnAddReserve.Name = "btnAddReserve";
            this.btnAddReserve.Size = new System.Drawing.Size(348, 37);
            this.btnAddReserve.TabIndex = 12;
            this.btnAddReserve.Text = "Add Reserve Room";
            this.btnAddReserve.UseVisualStyleBackColor = true;
            this.btnAddReserve.Click += new System.EventHandler(this.btnAddReserve_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(397, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 449);
            this.panel3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Type";
            // 
            // txtReservationId
            // 
            this.txtReservationId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReservationId.BackColor = System.Drawing.SystemColors.Info;
            this.txtReservationId.Location = new System.Drawing.Point(158, 234);
            this.txtReservationId.Name = "txtReservationId";
            this.txtReservationId.Size = new System.Drawing.Size(178, 22);
            this.txtReservationId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 84);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(374, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservation";
            // 
            // ManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 588);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservation";
            this.Load += new System.EventHandler(this.ManageReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxresrvationRoomNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMreservationClientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxReservationRoomType;
        private System.Windows.Forms.Button btnClearReserveRoomfield;
        private System.Windows.Forms.Button btnRemoveReserve;
        private System.Windows.Forms.Button btnEditReserve;
        private System.Windows.Forms.Button btnAddReserve;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReservationId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickeroiOut;
        private System.Windows.Forms.Label label7;
    }
}