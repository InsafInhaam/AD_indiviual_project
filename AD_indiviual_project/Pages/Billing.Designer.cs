﻿namespace AD_indiviual_project.Pages
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.searchTerm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.print_invoice = new System.Windows.Forms.Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTerm
            // 
            this.searchTerm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTerm.DefaultText = "";
            this.searchTerm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTerm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTerm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTerm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTerm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTerm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTerm.Location = new System.Drawing.Point(21, 72);
            this.searchTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.PasswordChar = '\0';
            this.searchTerm.PlaceholderText = "";
            this.searchTerm.SelectedText = "";
            this.searchTerm.Size = new System.Drawing.Size(314, 38);
            this.searchTerm.TabIndex = 23;
            this.searchTerm.TextChanged += new System.EventHandler(this.searchTerm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 38);
            this.label2.TabIndex = 22;
            this.label2.Text = "Billing";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 397);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(738, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // print_invoice
            // 
            this.print_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.print_invoice.Location = new System.Drawing.Point(738, 19);
            this.print_invoice.Name = "print_invoice";
            this.print_invoice.Size = new System.Drawing.Size(132, 40);
            this.print_invoice.TabIndex = 25;
            this.print_invoice.Text = "View Invoice";
            this.print_invoice.UseVisualStyleBackColor = false;
            this.print_invoice.Click += new System.EventHandler(this.print_invoice_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(407, 64);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Size = new System.Drawing.Size(47, 53);
            this.guna2ImageButton1.TabIndex = 24;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.print_invoice);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Button print_invoice;
    }
}