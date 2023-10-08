using AD_indiviual_project.Controller;
using AD_indiviual_project.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class UpdateAppointment : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int appointmentId;
        private AppointmentController appointmentController;

        public UpdateAppointment(int appointmentId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            appointmentController = new AppointmentController(connectionString);
            LoadAppointmentDetails();
            LoadPatientNames();
        }

        private void UpdateAppointment_Load(object sender, EventArgs e)
        {
            // Populate the specialization ComboBox with your specialization options.
            specializationComboBox.Items.AddRange(new string[] { "Cardiology", "Dermatology", "Endocrinology", "Gastroenterology", "Hematology", "Pediatrics", "General" });
            // Set the default selection to the first item.
            specializationComboBox.SelectedIndex = 0;
            PopulateDoctorComboBox(specializationComboBox.SelectedItem.ToString());
        }

        private void PopulateDoctorComboBox(string specialization)
        {
            DataTable doctorsTable = appointmentController.GetDoctors(specialization);
            if (doctorsTable != null)
            {
                doctorComboBox.DataSource = doctorsTable;
                doctorComboBox.DisplayMember = "FirstName"; // Display the first name in the control
                doctorComboBox.ValueMember = "DoctorID";   // Save the DoctorID as the selected value
            }
        }

        private void LoadPatientNames()
        {
            DataTable patientsTable = appointmentController.GetPatients();
            if (patientsTable != null)
            {
                txtPatientId.DataSource = patientsTable;
                txtPatientId.DisplayMember = "first_name"; // Display the first name in the control
                txtPatientId.ValueMember = "patientid";   // Save the PatientID as the selected value
            }
        }

        private void LoadAppointmentDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Appointments WHERE AppointmentID = @AppointmentId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtPatientId.SelectedValue = (int)reader["PatientID"];
                            doctorComboBox.SelectedValue = (int)reader["DoctorID"];

                            // Assuming the items in doctorAppointmentTime are strings
                            string appointmentTime = reader["AppointmentTime"].ToString();
                            if (doctorAppointmentTime.Items.Contains(appointmentTime))
                            {
                                doctorAppointmentTime.SelectedItem = appointmentTime;
                            }
                            yourDateTimePicker.Value = (DateTime)reader["AppointmentDate"];
                            txtDescription.Text = reader["Description"].ToString();

                            // You can add more controls based on your database schema
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while loading appointment details: " + ex.Message);
                // Handle the exception (e.g., log or display an error message).
            }
        }


        private bool ValidateInputFields()
        {
            // Validate input fields for the appointment
            if (txtPatientId.SelectedValue == null ||
                doctorComboBox.SelectedValue == null ||
                doctorAppointmentTime.SelectedItem == null ||
                yourDateTimePicker.Value == null || // Replace with your DateTimePicker control
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all required fields for the appointment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // You can add more validation logic as needed

            return true;
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    int patientId = (int)txtPatientId.SelectedValue;
                    int doctorId = (int)doctorComboBox.SelectedValue;
                    DateTime appointmentDate = yourDateTimePicker.Value;
                    string appointmentTime = doctorAppointmentTime.SelectedItem.ToString();
                    string description = txtDescription.Text;

                    if (appointmentController.UpdateAppointment(appointmentId, patientId, doctorId, appointmentDate, appointmentTime, description))
                    {
                        MessageBox.Show("Appointment Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update appointment record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating appointment record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorComboBox.SelectedItem != null)
            {
                int selectedDoctorID = (int)doctorComboBox.SelectedValue;
                PopulateAppointmentTimeComboBox(selectedDoctorID);
            }
        }

        private void doctorAppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateAppointmentTimeComboBox(int doctorID)
        {
            DataTable appointmentTimesTable = appointmentController.GetAppointmentTimes(doctorID);
            if (appointmentTimesTable != null)
            {
                doctorAppointmentTime.DataSource = appointmentTimesTable;
                doctorAppointmentTime.DisplayMember = "AvailableTime";
                doctorAppointmentTime.ValueMember = "AvailableTime"; // You can change this if needed
            }
        }

        private void specializationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             string selectedSpecialization = specializationComboBox.SelectedItem.ToString();

            // Populate the doctor ComboBox based on the selected specialization.
            PopulateDoctorComboBox(selectedSpecialization);
        }
    }
}
