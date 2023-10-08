namespace AD_indiviual_project.Models
{
    partial class UpdateResource
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
            this.NotesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResourceTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StatusTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ModelTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ResourceNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPatient.Location = new System.Drawing.Point(659, 365);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(134, 50);
            this.btnAddPatient.TabIndex = 178;
            this.btnAddPatient.Text = "Update";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NotesTextBox.DefaultText = "";
            this.NotesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NotesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NotesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NotesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NotesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NotesTextBox.Location = new System.Drawing.Point(50, 375);
            this.NotesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.PasswordChar = '\0';
            this.NotesTextBox.PlaceholderText = "";
            this.NotesTextBox.SelectedText = "";
            this.NotesTextBox.Size = new System.Drawing.Size(350, 40);
            this.NotesTextBox.TabIndex = 177;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 176;
            this.label5.Text = "Notes";
            // 
            // ResourceTypeComboBox
            // 
            this.ResourceTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ResourceTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ResourceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResourceTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResourceTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResourceTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ResourceTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ResourceTypeComboBox.ItemHeight = 30;
            this.ResourceTypeComboBox.Items.AddRange(new object[] {
            "New",
            "Maintenance",
            "Damaged"});
            this.ResourceTypeComboBox.Location = new System.Drawing.Point(445, 135);
            this.ResourceTypeComboBox.Name = "ResourceTypeComboBox";
            this.ResourceTypeComboBox.Size = new System.Drawing.Size(348, 36);
            this.ResourceTypeComboBox.TabIndex = 175;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StatusTextBox.DefaultText = "";
            this.StatusTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StatusTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StatusTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusTextBox.Location = new System.Drawing.Point(443, 296);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.PasswordChar = '\0';
            this.StatusTextBox.PlaceholderText = "";
            this.StatusTextBox.SelectedText = "";
            this.StatusTextBox.Size = new System.Drawing.Size(350, 40);
            this.StatusTextBox.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 173;
            this.label1.Text = "Status";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ManufacturerTextBox.DefaultText = "";
            this.ManufacturerTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ManufacturerTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ManufacturerTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ManufacturerTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ManufacturerTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ManufacturerTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(443, 214);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.PasswordChar = '\0';
            this.ManufacturerTextBox.PlaceholderText = "";
            this.ManufacturerTextBox.SelectedText = "";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(350, 40);
            this.ManufacturerTextBox.TabIndex = 172;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextBox.DefaultText = "";
            this.ModelTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ModelTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ModelTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ModelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelTextBox.Location = new System.Drawing.Point(50, 295);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.PasswordChar = '\0';
            this.ModelTextBox.PlaceholderText = "";
            this.ModelTextBox.SelectedText = "";
            this.ModelTextBox.Size = new System.Drawing.Size(350, 40);
            this.ModelTextBox.TabIndex = 171;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 170;
            this.label3.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 169;
            this.label4.Text = "Model";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialNumberTextBox.DefaultText = "";
            this.SerialNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SerialNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SerialNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SerialNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialNumberTextBox.Location = new System.Drawing.Point(50, 213);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.PasswordChar = '\0';
            this.SerialNumberTextBox.PlaceholderText = "";
            this.SerialNumberTextBox.SelectedText = "";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(350, 40);
            this.SerialNumberTextBox.TabIndex = 168;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(46, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 167;
            this.label16.Text = "Serial Number";
            // 
            // ResourceNameTextBox
            // 
            this.ResourceNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResourceNameTextBox.DefaultText = "";
            this.ResourceNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ResourceNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ResourceNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ResourceNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ResourceNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResourceNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResourceNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResourceNameTextBox.Location = new System.Drawing.Point(51, 131);
            this.ResourceNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResourceNameTextBox.Name = "ResourceNameTextBox";
            this.ResourceNameTextBox.PasswordChar = '\0';
            this.ResourceNameTextBox.PlaceholderText = "";
            this.ResourceNameTextBox.SelectedText = "";
            this.ResourceNameTextBox.Size = new System.Drawing.Size(350, 40);
            this.ResourceNameTextBox.TabIndex = 166;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(287, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 38);
            this.label15.TabIndex = 165;
            this.label15.Text = "Update Resources";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 164;
            this.label9.Text = "Resource Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 163;
            this.label2.Text = "Firstname";
            // 
            // UpdateResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 459);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResourceTypeComboBox);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManufacturerTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ResourceNameTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "UpdateResource";
            this.Text = "UpdateResource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2TextBox NotesTextBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox ResourceTypeComboBox;
        private Guna.UI2.WinForms.Guna2TextBox StatusTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox ManufacturerTextBox;
        private Guna.UI2.WinForms.Guna2TextBox ModelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox SerialNumberTextBox;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox ResourceNameTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}