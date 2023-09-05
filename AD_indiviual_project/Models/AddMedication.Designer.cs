namespace AD_indiviual_project.Models
{
    partial class AddMedication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedication));
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDosage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInstructions = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMedicationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrequency = new Guna.UI2.WinForms.Guna2TextBox();
            this.startDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.endDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPrescribingDoctorId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPatient.Location = new System.Drawing.Point(1051, 370);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(134, 50);
            this.btnAddPatient.TabIndex = 192;
            this.btnAddPatient.Text = "Add Medication";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(52, 304);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(350, 116);
            this.txtNotes.TabIndex = 189;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 188;
            this.label7.Text = "Notes";
            // 
            // txtDosage
            // 
            this.txtDosage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDosage.DefaultText = "";
            this.txtDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosage.Location = new System.Drawing.Point(835, 143);
            this.txtDosage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.PlaceholderText = "";
            this.txtDosage.SelectedText = "";
            this.txtDosage.Size = new System.Drawing.Size(350, 40);
            this.txtDosage.TabIndex = 183;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(831, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 182;
            this.label16.Text = "Dosage";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstructions.DefaultText = "";
            this.txtInstructions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstructions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstructions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstructions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInstructions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructions.Location = new System.Drawing.Point(444, 303);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.PasswordChar = '\0';
            this.txtInstructions.PlaceholderText = "";
            this.txtInstructions.SelectedText = "";
            this.txtInstructions.Size = new System.Drawing.Size(350, 40);
            this.txtInstructions.TabIndex = 179;
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicationName.DefaultText = "";
            this.txtMedicationName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicationName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicationName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicationName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicationName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicationName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMedicationName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicationName.Location = new System.Drawing.Point(445, 144);
            this.txtMedicationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.PasswordChar = '\0';
            this.txtMedicationName.PlaceholderText = "";
            this.txtMedicationName.SelectedText = "";
            this.txtMedicationName.Size = new System.Drawing.Size(350, 40);
            this.txtMedicationName.TabIndex = 177;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(495, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 38);
            this.label15.TabIndex = 175;
            this.label15.Text = "Add Medication";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(831, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 174;
            this.label13.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 173;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(442, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 172;
            this.label9.Text = "Medication Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(833, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 171;
            this.label5.Text = "Prescribing Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 170;
            this.label4.Text = "Instructions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 169;
            this.label3.Text = "Frequency";
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
            this.txtPatientId.Location = new System.Drawing.Point(52, 143);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(350, 36);
            this.txtPatientId.TabIndex = 205;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 204;
            this.label1.Text = "Patient";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrequency.DefaultText = "";
            this.txtFrequency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrequency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrequency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrequency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrequency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrequency.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFrequency.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrequency.Location = new System.Drawing.Point(52, 219);
            this.txtFrequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.PasswordChar = '\0';
            this.txtFrequency.PlaceholderText = "";
            this.txtFrequency.SelectedText = "";
            this.txtFrequency.Size = new System.Drawing.Size(350, 40);
            this.txtFrequency.TabIndex = 206;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Checked = true;
            this.startDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDatePicker.Location = new System.Drawing.Point(447, 219);
            this.startDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(348, 40);
            this.startDatePicker.TabIndex = 207;
            this.startDatePicker.Value = new System.DateTime(2023, 9, 5, 8, 47, 54, 610);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Checked = true;
            this.endDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDatePicker.Location = new System.Drawing.Point(837, 219);
            this.endDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(348, 40);
            this.endDatePicker.TabIndex = 208;
            this.endDatePicker.Value = new System.DateTime(2023, 9, 5, 8, 47, 54, 610);
            // 
            // txtPrescribingDoctorId
            // 
            this.txtPrescribingDoctorId.BackColor = System.Drawing.Color.Transparent;
            this.txtPrescribingDoctorId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPrescribingDoctorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPrescribingDoctorId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrescribingDoctorId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrescribingDoctorId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrescribingDoctorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtPrescribingDoctorId.ItemHeight = 30;
            this.txtPrescribingDoctorId.Location = new System.Drawing.Point(837, 303);
            this.txtPrescribingDoctorId.Name = "txtPrescribingDoctorId";
            this.txtPrescribingDoctorId.Size = new System.Drawing.Size(350, 36);
            this.txtPrescribingDoctorId.TabIndex = 209;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1148, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 210;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // AddMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 473);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.txtPrescribingDoctorId);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedication";
            this.Text = "AddMedication";
            this.Load += new System.EventHandler(this.AddMedication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtDosage;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtInstructions;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicationName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox txtPatientId;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFrequency;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDatePicker;
        private Guna.UI2.WinForms.Guna2ComboBox txtPrescribingDoctorId;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}