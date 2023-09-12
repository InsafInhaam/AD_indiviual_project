namespace AD_indiviual_project.Models
{
    partial class AddAppointment
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
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.doctorComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yourDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.specializationComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorAppointmentTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPatient.Location = new System.Drawing.Point(505, 378);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(134, 50);
            this.btnAddPatient.TabIndex = 192;
            this.btnAddPatient.Text = "Schedule";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(428, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 20);
            this.label16.TabIndex = 182;
            this.label16.Text = "Appointment Date";
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(821, 247);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(350, 121);
            this.txtDescription.TabIndex = 179;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.BackColor = System.Drawing.Color.Transparent;
            this.doctorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doctorComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doctorComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.doctorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.doctorComboBox.ItemHeight = 30;
            this.doctorComboBox.Location = new System.Drawing.Point(426, 165);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(350, 36);
            this.doctorComboBox.TabIndex = 178;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(435, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(344, 38);
            this.label15.TabIndex = 175;
            this.label15.Text = "Schedule Appointment";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(816, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 172;
            this.label9.Text = "Patient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(817, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 170;
            this.label4.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 168;
            this.label2.Text = "Doctor";
            // 
            // txtPatientId
            // 
            this.txtPatientId.BackColor = System.Drawing.Color.Transparent;
            this.txtPatientId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPatientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPatientId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtPatientId.ItemHeight = 30;
            this.txtPatientId.Location = new System.Drawing.Point(821, 165);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(350, 36);
            this.txtPatientId.TabIndex = 204;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 205;
            this.label1.Text = "Appointment Time";
            // 
            // yourDateTimePicker
            // 
            this.yourDateTimePicker.Checked = true;
            this.yourDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yourDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.yourDateTimePicker.Location = new System.Drawing.Point(432, 248);
            this.yourDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.yourDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.yourDateTimePicker.Name = "yourDateTimePicker";
            this.yourDateTimePicker.Size = new System.Drawing.Size(350, 36);
            this.yourDateTimePicker.TabIndex = 207;
            this.yourDateTimePicker.Value = new System.DateTime(2023, 9, 2, 21, 2, 36, 334);
            // 
            // specializationComboBox
            // 
            this.specializationComboBox.BackColor = System.Drawing.Color.Transparent;
            this.specializationComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.specializationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specializationComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specializationComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specializationComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.specializationComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.specializationComboBox.ItemHeight = 30;
            this.specializationComboBox.Location = new System.Drawing.Point(38, 165);
            this.specializationComboBox.Name = "specializationComboBox";
            this.specializationComboBox.Size = new System.Drawing.Size(350, 36);
            this.specializationComboBox.TabIndex = 210;
            this.specializationComboBox.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 209;
            this.label3.Text = "Specialization";
            // 
            // doctorAppointmentTime
            // 
            this.doctorAppointmentTime.BackColor = System.Drawing.Color.Transparent;
            this.doctorAppointmentTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.doctorAppointmentTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorAppointmentTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doctorAppointmentTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doctorAppointmentTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.doctorAppointmentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.doctorAppointmentTime.ItemHeight = 30;
            this.doctorAppointmentTime.Location = new System.Drawing.Point(38, 248);
            this.doctorAppointmentTime.Name = "doctorAppointmentTime";
            this.doctorAppointmentTime.Size = new System.Drawing.Size(350, 36);
            this.doctorAppointmentTime.TabIndex = 211;
            this.doctorAppointmentTime.SelectedIndexChanged += new System.EventHandler(this.appointmentTime_SelectedIndexChanged);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 471);
            this.Controls.Add(this.doctorAppointmentTime);
            this.Controls.Add(this.specializationComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yourDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddAppointment";
            this.Text = "AppApointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2ComboBox doctorComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txtPatientId;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker yourDateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox specializationComboBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox doctorAppointmentTime;
    }
}