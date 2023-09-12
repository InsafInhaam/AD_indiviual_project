using AD_indiviual_project.Models;
using AD_indiviual_project.Pages;
using System;
using System.Windows.Forms;

namespace AD_indiviual_project.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            string loggedInUser = Session.Username;
            welcomeLabel.Text = $"Welcome, {loggedInUser}!";

            // Call a method to set up the sidebar based on the user's role
            SetupSidebar();
            loadform(new Dashboard());
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void SetupSidebar()
        {
            // Check the user's role from the session
            if (Session.Role == "1")  // 1 is for admin
            {
                // Show admin-specific menu items
                btnDoctor.Visible = true;
                btnRooms.Visible = true;

                // Hide staff-specific menu items
                btnStaff.Visible = false;
                btnPatient.Visible = false;
                btnAppointment.Visible = false;
            }
            else if (Session.Role == "0")  // 0 is for staffs
            {
                // Show staff-specific menu items
                btnStaff.Visible = true;
                btnPatient.Visible = true;
                btnAppointment.Visible = true;

                // Hide admin-specific menu items
                btnDoctor.Visible = false;
                btnRooms.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadform(new Patient());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear user session
            Session.Username = null;
            Session.Role = null;

            // Navigate back to the login form
            UserLogin loginForm = new UserLogin();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff addstaff = new AddStaff();
            addstaff.Show();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPatient addpatient = new AddPatient();
            addpatient.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            loadform(new Staff());
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            loadform(new Staff());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            loadform(new User());
        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
            loadform(new Patient());
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            loadform(new Doctor());
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            loadform(new Appointment());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            loadform(new Rooms());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new RoomBook());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            loadform(new Medication());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loadform(new Billing());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            loadform(new Procedures());
        }
    }
}