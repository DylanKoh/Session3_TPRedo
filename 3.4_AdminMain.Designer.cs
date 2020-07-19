namespace Session3_TPRedo
{
    partial class AdminMain
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
            this.btnArrivalSummary = new System.Windows.Forms.Button();
            this.btnHotelSummary = new System.Windows.Forms.Button();
            this.btnGuestsSummary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1008, 84);
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(784, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArrivalSummary
            // 
            this.btnArrivalSummary.Location = new System.Drawing.Point(359, 165);
            this.btnArrivalSummary.Name = "btnArrivalSummary";
            this.btnArrivalSummary.Size = new System.Drawing.Size(245, 47);
            this.btnArrivalSummary.TabIndex = 3;
            this.btnArrivalSummary.Text = "Arrival Summary";
            this.btnArrivalSummary.UseVisualStyleBackColor = true;
            this.btnArrivalSummary.Click += new System.EventHandler(this.btnArrivalSummary_Click);
            // 
            // btnHotelSummary
            // 
            this.btnHotelSummary.Location = new System.Drawing.Point(359, 218);
            this.btnHotelSummary.Name = "btnHotelSummary";
            this.btnHotelSummary.Size = new System.Drawing.Size(245, 47);
            this.btnHotelSummary.TabIndex = 4;
            this.btnHotelSummary.Text = "Hotel Summary";
            this.btnHotelSummary.UseVisualStyleBackColor = true;
            this.btnHotelSummary.Click += new System.EventHandler(this.btnHotelSummary_Click);
            // 
            // btnGuestsSummary
            // 
            this.btnGuestsSummary.Location = new System.Drawing.Point(359, 271);
            this.btnGuestsSummary.Name = "btnGuestsSummary";
            this.btnGuestsSummary.Size = new System.Drawing.Size(245, 47);
            this.btnGuestsSummary.TabIndex = 5;
            this.btnGuestsSummary.Text = "Guests Summary";
            this.btnGuestsSummary.UseVisualStyleBackColor = true;
            this.btnGuestsSummary.Click += new System.EventHandler(this.btnGuestsSummary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Admin Main Menu";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuestsSummary);
            this.Controls.Add(this.btnHotelSummary);
            this.Controls.Add(this.btnArrivalSummary);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminMain";
            this.Text = "Admin Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArrivalSummary;
        private System.Windows.Forms.Button btnHotelSummary;
        private System.Windows.Forms.Button btnGuestsSummary;
        private System.Windows.Forms.Label label2;
    }
}