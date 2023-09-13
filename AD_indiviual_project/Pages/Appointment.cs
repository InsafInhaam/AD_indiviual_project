using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Appointment : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private AppointmentController appointmentManager;

        public Appointment()
        {
            InitializeComponent();
            appointmentManager = new AppointmentController(connectionString);
            LoadAppointmentRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAppointment addappointment = new AddAppointment();
            addappointment.Show();
        }

        public void LoadAppointmentRecords()
        {
            DataTable dataTable = appointmentManager.GetAppointments();
            dataGridView1.DataSource = dataTable;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = appointmentManager.SearchAppointments(searchText);
            dataGridView1.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int appointmentId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["appointmentid"].Value);

                    if (appointmentManager.DeleteAppointment(appointmentId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointmentRecords();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the appointment ID from the selected row
                int appointmentId = Convert.ToInt32(selectedRow.Cells["appointmentid"].Value);

                // Open an update form or dialog to modify appointment information
                // You can pass the appointmentId to the update form so it knows which record to update
                UpdateAppointment updateForm = new UpdateAppointment(appointmentId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the appointment records after the update
                    LoadAppointmentRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single appointment record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}