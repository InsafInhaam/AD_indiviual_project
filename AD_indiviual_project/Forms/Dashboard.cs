using AD_indiviual_project.Controller;
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
    public partial class Dashboard : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private DashboardController dashboardManager;

        public Dashboard()
        {
            InitializeComponent();
            dashboardManager = new DashboardController(connectionString);
            UpdateTotalCounts();    // Call the method to update the total counts.
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        // Method to update the total counts and display them on the form.
        private void UpdateTotalCounts()
        {
            try
            {
                // Get the total counts using DashboardCount instance.
                int staffCount = dashboardManager.GetStaffTotalCount();
                int doctorCount = dashboardManager.GetDoctorsTotalCount();
                int patientCount = dashboardManager.GetPatientsCount();
                int resourceCount = dashboardManager.GetResourceTotalCount();
                int appointmentCount = dashboardManager.GetAppointmentTotalCount();
                int roomsCount = dashboardManager.GetRoomsTotalCount();

                // Update the labels to display the counts.
                Patientlabel.Text = patientCount.ToString();
                Stafflabel.Text = staffCount.ToString();
                Doctorlabel.Text = doctorCount.ToString();
                ResourceLabel.Text = resourceCount.ToString();
                Appointmentlabel.Text = appointmentCount.ToString();
                RoomsLabel.Text = roomsCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching total counts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
