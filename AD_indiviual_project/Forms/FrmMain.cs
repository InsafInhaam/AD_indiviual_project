using AD_indiviual_project.Models;
using AD_indiviual_project.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide(); 
        }

        private void bindingNavigatorPositionItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // panelStaff.Visible = false;
            // panelPatient.Visible = true;
            //panelAppointment.Visible = false;
            loadform(new Patient());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear user session
            Session.Username = null;
            Session.Role = null;

            // Navigate back to the login form
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff addstaff = new AddStaff();
            addstaff.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPatient addpatient = new AddPatient();
            addpatient.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //panelStaff.Visible = true;
            // panelPatient.Visible = false;
            //panelAppointment.Visible = false;
            loadform(new Staff());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}