﻿namespace AD_indiviual_project.Models
{
    partial class UpdateStaff
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
            this.PositionTextBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BirthdatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.HireDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AddressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalaryTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DepartmentTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.GenderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.staffLastnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffFirstnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PositionTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PositionTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionTextBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PositionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PositionTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PositionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PositionTextBox.ItemHeight = 30;
            this.PositionTextBox.Items.AddRange(new object[] {
            "Developer",
            "Cleaner",
            "Nursue",
            "Laboraty"});
            this.PositionTextBox.Location = new System.Drawing.Point(516, 380);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(350, 36);
            this.PositionTextBox.TabIndex = 109;
            // 
            // BirthdatePicker
            // 
            this.BirthdatePicker.Checked = true;
            this.BirthdatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BirthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BirthdatePicker.Location = new System.Drawing.Point(516, 210);
            this.BirthdatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthdatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthdatePicker.Name = "BirthdatePicker";
            this.BirthdatePicker.Size = new System.Drawing.Size(350, 40);
            this.BirthdatePicker.TabIndex = 107;
            this.BirthdatePicker.Value = new System.DateTime(2023, 8, 22, 9, 1, 57, 726);
            // 
            // HireDatePicker
            // 
            this.HireDatePicker.Checked = true;
            this.HireDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.HireDatePicker.Location = new System.Drawing.Point(516, 462);
            this.HireDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.HireDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.HireDatePicker.Name = "HireDatePicker";
            this.HireDatePicker.Size = new System.Drawing.Size(350, 40);
            this.HireDatePicker.TabIndex = 106;
            this.HireDatePicker.Value = new System.DateTime(2023, 8, 22, 9, 1, 57, 726);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.DefaultText = "";
            this.AddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.Location = new System.Drawing.Point(62, 380);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.PasswordChar = '\0';
            this.AddressTextBox.PlaceholderText = "";
            this.AddressTextBox.SelectedText = "";
            this.AddressTextBox.Size = new System.Drawing.Size(350, 40);
            this.AddressTextBox.TabIndex = 105;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(58, 355);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 104;
            this.label16.Text = "Address";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTextBox.DefaultText = "";
            this.PhoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTextBox.Location = new System.Drawing.Point(516, 291);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PasswordChar = '\0';
            this.PhoneTextBox.PlaceholderText = "";
            this.PhoneTextBox.SelectedText = "";
            this.PhoneTextBox.Size = new System.Drawing.Size(350, 40);
            this.PhoneTextBox.TabIndex = 103;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalaryTextBox.DefaultText = "";
            this.SalaryTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalaryTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalaryTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SalaryTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryTextBox.Location = new System.Drawing.Point(62, 548);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.PasswordChar = '\0';
            this.SalaryTextBox.PlaceholderText = "";
            this.SalaryTextBox.SelectedText = "";
            this.SalaryTextBox.Size = new System.Drawing.Size(350, 40);
            this.SalaryTextBox.TabIndex = 102;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepartmentTextBox.DefaultText = "";
            this.DepartmentTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DepartmentTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DepartmentTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DepartmentTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DepartmentTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepartmentTextBox.Location = new System.Drawing.Point(62, 462);
            this.DepartmentTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.PasswordChar = '\0';
            this.DepartmentTextBox.PlaceholderText = "";
            this.DepartmentTextBox.SelectedText = "";
            this.DepartmentTextBox.Size = new System.Drawing.Size(350, 40);
            this.DepartmentTextBox.TabIndex = 101;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBox.Location = new System.Drawing.Point(62, 291);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderText = "";
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.Size = new System.Drawing.Size(350, 40);
            this.EmailTextBox.TabIndex = 100;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.BackColor = System.Drawing.Color.Transparent;
            this.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenderComboBox.ItemHeight = 30;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not preferred"});
            this.GenderComboBox.Location = new System.Drawing.Point(62, 210);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(350, 36);
            this.GenderComboBox.TabIndex = 99;
            // 
            // staffLastnameTextBox
            // 
            this.staffLastnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffLastnameTextBox.DefaultText = "";
            this.staffLastnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffLastnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffLastnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffLastnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffLastnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffLastnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.staffLastnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffLastnameTextBox.Location = new System.Drawing.Point(516, 136);
            this.staffLastnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staffLastnameTextBox.Name = "staffLastnameTextBox";
            this.staffLastnameTextBox.PasswordChar = '\0';
            this.staffLastnameTextBox.PlaceholderText = "";
            this.staffLastnameTextBox.SelectedText = "";
            this.staffLastnameTextBox.Size = new System.Drawing.Size(350, 40);
            this.staffLastnameTextBox.TabIndex = 98;
            // 
            // staffFirstnameTextBox
            // 
            this.staffFirstnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffFirstnameTextBox.DefaultText = "";
            this.staffFirstnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffFirstnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffFirstnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffFirstnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffFirstnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffFirstnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.staffFirstnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffFirstnameTextBox.Location = new System.Drawing.Point(62, 134);
            this.staffFirstnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staffFirstnameTextBox.Name = "staffFirstnameTextBox";
            this.staffFirstnameTextBox.PasswordChar = '\0';
            this.staffFirstnameTextBox.PlaceholderText = "";
            this.staffFirstnameTextBox.SelectedText = "";
            this.staffFirstnameTextBox.Size = new System.Drawing.Size(350, 40);
            this.staffFirstnameTextBox.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(349, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 38);
            this.label15.TabIndex = 96;
            this.label15.Text = "Update Staff";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(514, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 95;
            this.label12.Text = "HireDate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 524);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 94;
            this.label13.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(512, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 93;
            this.label11.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 92;
            this.label10.Text = "Department";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddStaff.Location = new System.Drawing.Point(732, 538);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(134, 50);
            this.btnAddStaff.TabIndex = 91;
            this.btnAddStaff.Text = "UPDATE";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 90;
            this.label8.Text = "D.O.B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(513, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Firstname";
            // 
            // UpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 644);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.BirthdatePicker);
            this.Controls.Add(this.HireDatePicker);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.staffLastnameTextBox);
            this.Controls.Add(this.staffFirstnameTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UpdateStaff";
            this.Text = "UpdateStaff";
            this.Load += new System.EventHandler(this.UpdateStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox PositionTextBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthdatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker HireDatePicker;
        private Guna.UI2.WinForms.Guna2TextBox AddressTextBox;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTextBox;
        private Guna.UI2.WinForms.Guna2TextBox SalaryTextBox;
        private Guna.UI2.WinForms.Guna2TextBox DepartmentTextBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox GenderComboBox;
        private Guna.UI2.WinForms.Guna2TextBox staffLastnameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox staffFirstnameTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}