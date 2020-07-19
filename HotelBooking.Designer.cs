namespace Session3_TPRedo
{
    partial class HotelBooking
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDelegates = new System.Windows.Forms.Label();
            this.lblCompetitors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomsRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 84);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(784, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hotel Booking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hotel Name: ";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Location = new System.Drawing.Point(268, 151);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(58, 18);
            this.lblHotelName.TabIndex = 7;
            this.lblHotelName.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. of Pax: ";
            // 
            // lblDelegates
            // 
            this.lblDelegates.AutoSize = true;
            this.lblDelegates.Location = new System.Drawing.Point(268, 205);
            this.lblDelegates.Name = "lblDelegates";
            this.lblDelegates.Size = new System.Drawing.Size(58, 18);
            this.lblDelegates.TabIndex = 9;
            this.lblDelegates.Text = "label6";
            // 
            // lblCompetitors
            // 
            this.lblCompetitors.AutoSize = true;
            this.lblCompetitors.Location = new System.Drawing.Point(268, 248);
            this.lblCompetitors.Name = "lblCompetitors";
            this.lblCompetitors.Size = new System.Drawing.Size(58, 18);
            this.lblCompetitors.TabIndex = 10;
            this.lblCompetitors.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Delegates (Excluding Head)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Competitors";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomType,
            this.RoomRate,
            this.AvailableRooms,
            this.RoomsRequired,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            this.RoomType.Width = 112;
            // 
            // RoomRate
            // 
            this.RoomRate.HeaderText = "Room Rate Per Night ($)";
            this.RoomRate.Name = "RoomRate";
            this.RoomRate.ReadOnly = true;
            this.RoomRate.Width = 147;
            // 
            // AvailableRooms
            // 
            this.AvailableRooms.HeaderText = "Available No of Rooms";
            this.AvailableRooms.Name = "AvailableRooms";
            this.AvailableRooms.ReadOnly = true;
            this.AvailableRooms.Width = 150;
            // 
            // RoomsRequired
            // 
            this.RoomsRequired.HeaderText = "Rooms Required";
            this.RoomsRequired.Name = "RoomsRequired";
            this.RoomsRequired.Width = 151;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub-Total ($)";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(785, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total ($): ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(882, 526);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 18);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(896, 571);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(100, 40);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // HotelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 623);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCompetitors);
            this.Controls.Add(this.lblDelegates);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HotelBooking";
            this.Text = "Hotel Booking";
            this.Load += new System.EventHandler(this.HotelBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDelegates;
        private System.Windows.Forms.Label lblCompetitors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomsRequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBook;
    }
}