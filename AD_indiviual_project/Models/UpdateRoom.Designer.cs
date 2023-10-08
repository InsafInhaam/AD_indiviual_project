namespace AD_indiviual_project.Models
{
    partial class UpdateRoom
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
            this.roomNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.roomTheaterNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomNotes
            // 
            this.roomNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomNotes.DefaultText = "";
            this.roomNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNotes.Location = new System.Drawing.Point(36, 243);
            this.roomNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomNotes.Name = "roomNotes";
            this.roomNotes.PasswordChar = '\0';
            this.roomNotes.PlaceholderText = "";
            this.roomNotes.SelectedText = "";
            this.roomNotes.Size = new System.Drawing.Size(350, 90);
            this.roomNotes.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 166;
            this.label1.Text = "Notes";
            // 
            // roomtype
            // 
            this.roomtype.BackColor = System.Drawing.Color.Transparent;
            this.roomtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomtype.ItemHeight = 30;
            this.roomtype.Items.AddRange(new object[] {
            "Standard Room",
            "Suite",
            "ICU (Intensive Care Unit)",
            "Maternity Room",
            "Pediatric Room",
            "Isolation Room",
            "Operating Room",
            "Emergency Room",
            "Radiology Room",
            "Laboratory Room",
            "Recovery Room",
            "Oncology Room",
            "Cardiology Room",
            "Neurology Room",
            "Orthopedic Room"});
            this.roomtype.Location = new System.Drawing.Point(430, 140);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(349, 36);
            this.roomtype.TabIndex = 165;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddRoom.Location = new System.Drawing.Point(645, 283);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(134, 50);
            this.btnAddRoom.TabIndex = 164;
            this.btnAddRoom.Text = "Update";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(282, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 38);
            this.label15.TabIndex = 163;
            this.label15.Text = "Update Room";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomTheaterNo
            // 
            this.roomTheaterNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomTheaterNo.DefaultText = "";
            this.roomTheaterNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomTheaterNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomTheaterNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTheaterNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTheaterNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTheaterNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomTheaterNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTheaterNo.Location = new System.Drawing.Point(36, 140);
            this.roomTheaterNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomTheaterNo.Name = "roomTheaterNo";
            this.roomTheaterNo.PasswordChar = '\0';
            this.roomTheaterNo.PlaceholderText = "";
            this.roomTheaterNo.SelectedText = "";
            this.roomTheaterNo.Size = new System.Drawing.Size(350, 40);
            this.roomTheaterNo.TabIndex = 162;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 161;
            this.label9.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 160;
            this.label2.Text = "Room Theater Number";
            // 
            // UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 371);
            this.Controls.Add(this.roomNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.roomTheaterNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "UpdateRoom";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox roomNotes;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox roomtype;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox roomTheaterNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}