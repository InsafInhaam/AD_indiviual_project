namespace AD_indiviual_project.Models
{
    partial class BookRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patientComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomTheaterComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BookingFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BookingToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 166;
            this.label1.Text = "From Booking Date";
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBookRoom.Location = new System.Drawing.Point(346, 359);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(162, 50);
            this.btnBookRoom.TabIndex = 164;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(339, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 38);
            this.label15.TabIndex = 163;
            this.label15.Text = "Book Room";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 160;
            this.label2.Text = "Room ID";
            // 
            // patientComboBox
            // 
            this.patientComboBox.BackColor = System.Drawing.Color.Transparent;
            this.patientComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.patientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.patientComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.patientComboBox.ItemHeight = 30;
            this.patientComboBox.Location = new System.Drawing.Point(448, 162);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(350, 36);
            this.patientComboBox.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 180;
            this.label3.Text = "Patient ID";
            // 
            // roomTheaterComboBox
            // 
            this.roomTheaterComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roomTheaterComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomTheaterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTheaterComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTheaterComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTheaterComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomTheaterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomTheaterComboBox.ItemHeight = 30;
            this.roomTheaterComboBox.Location = new System.Drawing.Point(54, 162);
            this.roomTheaterComboBox.Name = "roomTheaterComboBox";
            this.roomTheaterComboBox.Size = new System.Drawing.Size(350, 36);
            this.roomTheaterComboBox.TabIndex = 181;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 182;
            this.label4.Text = "End Booking Date";
            // 
            // BookingFromDate
            // 
            this.BookingFromDate.Checked = true;
            this.BookingFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BookingFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BookingFromDate.Location = new System.Drawing.Point(54, 264);
            this.BookingFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BookingFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BookingFromDate.Name = "BookingFromDate";
            this.BookingFromDate.Size = new System.Drawing.Size(350, 36);
            this.BookingFromDate.TabIndex = 183;
            this.BookingFromDate.Value = new System.DateTime(2023, 9, 3, 23, 13, 31, 0);
            // 
            // BookingToDate
            // 
            this.BookingToDate.Checked = true;
            this.BookingToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BookingToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BookingToDate.Location = new System.Drawing.Point(448, 264);
            this.BookingToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BookingToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BookingToDate.Name = "BookingToDate";
            this.BookingToDate.Size = new System.Drawing.Size(350, 36);
            this.BookingToDate.TabIndex = 184;
            this.BookingToDate.Value = new System.DateTime(2023, 9, 3, 23, 13, 33, 766);
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 484);
            this.Controls.Add(this.BookingToDate);
            this.Controls.Add(this.BookingFromDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomTheaterComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BookRoom";
            this.Text = "AddBookRoom";
            this.Load += new System.EventHandler(this.BookRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox patientComboBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox roomTheaterComboBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker BookingFromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker BookingToDate;
    }
}