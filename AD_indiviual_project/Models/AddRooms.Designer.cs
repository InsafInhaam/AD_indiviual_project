namespace AD_indiviual_project.Models
{
    partial class AddRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRooms));
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roomTheaterNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.roomtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScheduledProcedures = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = "Room Theater Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 147;
            this.label9.Text = "Room Type";
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
            this.roomTheaterNo.Location = new System.Drawing.Point(116, 144);
            this.roomTheaterNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomTheaterNo.Name = "roomTheaterNo";
            this.roomTheaterNo.PasswordChar = '\0';
            this.roomTheaterNo.PlaceholderText = "";
            this.roomTheaterNo.SelectedText = "";
            this.roomTheaterNo.Size = new System.Drawing.Size(350, 40);
            this.roomTheaterNo.TabIndex = 148;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(362, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 38);
            this.label15.TabIndex = 154;
            this.label15.Text = "Add New Room";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddRoom.Location = new System.Drawing.Point(427, 355);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(134, 50);
            this.btnAddRoom.TabIndex = 156;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
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
            "Rooms",
            "Theater"});
            this.roomtype.Location = new System.Drawing.Point(510, 144);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(349, 36);
            this.roomtype.TabIndex = 157;
            this.roomtype.SelectedIndexChanged += new System.EventHandler(this.roomtype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 158;
            this.label1.Text = "Scheduled Procedures";
            // 
            // ScheduledProcedures
            // 
            this.ScheduledProcedures.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScheduledProcedures.DefaultText = "";
            this.ScheduledProcedures.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ScheduledProcedures.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ScheduledProcedures.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScheduledProcedures.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScheduledProcedures.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScheduledProcedures.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScheduledProcedures.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScheduledProcedures.Location = new System.Drawing.Point(116, 247);
            this.ScheduledProcedures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScheduledProcedures.Name = "ScheduledProcedures";
            this.ScheduledProcedures.PasswordChar = '\0';
            this.ScheduledProcedures.PlaceholderText = "";
            this.ScheduledProcedures.SelectedText = "";
            this.ScheduledProcedures.Size = new System.Drawing.Size(350, 40);
            this.ScheduledProcedures.TabIndex = 159;
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(907, 19);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 160;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // AddRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 481);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.ScheduledProcedures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.roomTheaterNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRooms";
            this.Text = "AddRooms";
            this.Load += new System.EventHandler(this.AddRooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox roomTheaterNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2ComboBox roomtype;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox ScheduledProcedures;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}