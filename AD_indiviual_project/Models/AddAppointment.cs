using AD_indiviual_project.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddAppointment : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private AppointmentController appointmentController;

        public AddAppointment()
        {
            InitializeComponent();
            appointmentController = new AppointmentController(connectionString);
            //PopulateDoctorComboBox();
            LoadPatientNames();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            specializationComboBox.Items.AddRange(new string[] { "Cardiology", "Dermatology", "Endocrinology", "Gastroenterology", "Hematology", "Pediatrics", "General" });
            specializationComboBox.SelectedIndex = 0;
            PopulateDoctorComboBox(specializationComboBox.SelectedItem.ToString());
        }

        private void PopulateDoctorComboBox(string specialization)
        {
            DataTable doctorsTable = appointmentController.GetDoctors(specialization);
            if (doctorsTable != null)
            {
                doctorComboBox.DataSource = doctorsTable;
                doctorComboBox.DisplayMember = "FirstName"; 
                doctorComboBox.ValueMember = "DoctorID";   
            }
        }

        private void LoadPatientNames()
        {
            DataTable patientsTable = appointmentController.GetPatients();
            if (patientsTable != null)
            {
                txtPatientId.DataSource = patientsTable;
                txtPatientId.DisplayMember = "first_name"; 
                txtPatientId.ValueMember = "patientid";  
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool ValidateInputFields()
        {
            if (txtPatientId.SelectedValue == null ||
                doctorComboBox.SelectedValue == null ||
                doctorAppointmentTime.SelectedItem == null ||
                yourDateTimePicker.Value == null || 
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all required fields for the appointment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateInputFields())
            {
                return;
            }

            // Get selected values from the ComboBoxes and textboxes
            int patientID = (int)txtPatientId.SelectedValue;
            int doctorID = (int)doctorComboBox.SelectedValue;
            DateTime appointmentDate = yourDateTimePicker.Value; // Replace with your DateTimePicker control
            string appointmentTime = doctorAppointmentTime.SelectedItem.ToString(); // Get the selected appointment time
            string description = txtDescription.Text; // Replace with your description textbox

            // Add the appointment using the controller
            bool appointmentAdded = appointmentController.AddAppointment(patientID, doctorID, appointmentDate, appointmentTime, description);

            if (appointmentAdded)
            {
                MessageBox.Show("Appointment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear or reset your form as needed
            }
            else
            {
                MessageBox.Show("Failed to add appointment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the specialization ComboBox's SelectedIndexChanged event.
            string selectedSpecialization = specializationComboBox.SelectedItem.ToString();

            // Populate the doctor ComboBox based on the selected specialization.
            PopulateDoctorComboBox(selectedSpecialization);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void appointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}