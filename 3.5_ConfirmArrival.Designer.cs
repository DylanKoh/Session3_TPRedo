namespace Session3_TPRedo
{
    partial class ConfirmArrival
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn22July = new System.Windows.Forms.RadioButton();
            this.rbtn23July = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.nudHead = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDelegates = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCompetitors = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lbl19Seater = new System.Windows.Forms.Label();
            this.lbl42Seater = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelegates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 84);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(737, 29);
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
            this.label2.Location = new System.Drawing.Point(353, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Arrival Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(52, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(848, 61);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "9am";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "10am";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "11am";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "12pm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "1pm";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "2pm";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "3pm";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "4pm";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrival Time: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrival Date: ";
            // 
            // rbtn22July
            // 
            this.rbtn22July.AutoSize = true;
            this.rbtn22July.Location = new System.Drawing.Point(174, 147);
            this.rbtn22July.Name = "rbtn22July";
            this.rbtn22July.Size = new System.Drawing.Size(83, 22);
            this.rbtn22July.TabIndex = 8;
            this.rbtn22July.TabStop = true;
            this.rbtn22July.Text = "22 July";
            this.rbtn22July.UseVisualStyleBackColor = true;
            this.rbtn22July.CheckedChanged += new System.EventHandler(this.rbtn22July_CheckedChanged);
            // 
            // rbtn23July
            // 
            this.rbtn23July.AutoSize = true;
            this.rbtn23July.Location = new System.Drawing.Point(263, 147);
            this.rbtn23July.Name = "rbtn23July";
            this.rbtn23July.Size = new System.Drawing.Size(83, 22);
            this.rbtn23July.TabIndex = 9;
            this.rbtn23July.TabStop = true;
            this.rbtn23July.Text = "23 July";
            this.rbtn23July.UseVisualStyleBackColor = true;
            this.rbtn23July.CheckedChanged += new System.EventHandler(this.rbtn23July_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "No. of Pax: ";
            // 
            // nudHead
            // 
            this.nudHead.Location = new System.Drawing.Point(174, 297);
            this.nudHead.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHead.Name = "nudHead";
            this.nudHead.Size = new System.Drawing.Size(68, 27);
            this.nudHead.TabIndex = 11;
            this.nudHead.ValueChanged += new System.EventHandler(this.nudHead_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Head Of Delegation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Delegates (Excluding Head)";
            // 
            // nudDelegates
            // 
            this.nudDelegates.Location = new System.Drawing.Point(174, 330);
            this.nudDelegates.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDelegates.Name = "nudDelegates";
            this.nudDelegates.Size = new System.Drawing.Size(68, 27);
            this.nudDelegates.TabIndex = 13;
            this.nudDelegates.ValueChanged += new System.EventHandler(this.nudDelegates_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Competitors";
            // 
            // nudCompetitors
            // 
            this.nudCompetitors.Location = new System.Drawing.Point(174, 363);
            this.nudCompetitors.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCompetitors.Name = "nudCompetitors";
            this.nudCompetitors.Size = new System.Drawing.Size(68, 27);
            this.nudCompetitors.TabIndex = 15;
            this.nudCompetitors.ValueChanged += new System.EventHandler(this.nudCompetitors_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(460, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Complimentary Vehicles provided by Host";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(200, 482);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(18, 18);
            this.lblCar.TabIndex = 18;
            this.lblCar.Text = "0";
            // 
            // lbl19Seater
            // 
            this.lbl19Seater.AutoSize = true;
            this.lbl19Seater.Location = new System.Drawing.Point(200, 513);
            this.lbl19Seater.Name = "lbl19Seater";
            this.lbl19Seater.Size = new System.Drawing.Size(18, 18);
            this.lbl19Seater.TabIndex = 19;
            this.lbl19Seater.Text = "0";
            // 
            // lbl42Seater
            // 
            this.lbl42Seater.AutoSize = true;
            this.lbl42Seater.Location = new System.Drawing.Point(200, 544);
            this.lbl42Seater.Name = "lbl42Seater";
            this.lbl42Seater.Size = new System.Drawing.Size(18, 18);
            this.lbl42Seater.TabIndex = 20;
            this.lbl42Seater.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 482);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Car for Head of Delegation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "19-Seater Bus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 544);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 18);
            this.label15.TabIndex = 23;
            this.label15.Text = "42-Seater Bus";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(803, 578);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 33);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ConfirmArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 623);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl42Seater);
            this.Controls.Add(this.lbl19Seater);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudCompetitors);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudDelegates);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudHead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtn23July);
            this.Controls.Add(this.rbtn22July);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConfirmArrival";
            this.Text = "Confirm Arrival Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelegates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn22July;
        private System.Windows.Forms.RadioButton rbtn23July;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudHead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDelegates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCompetitors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lbl19Seater;
        private System.Windows.Forms.Label lbl42Seater;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnConfirm;
    }
}