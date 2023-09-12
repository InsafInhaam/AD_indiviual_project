using AD_indiviual_project.Controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddMedication : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private MedicationController medicationController;

        public AddMedication()
        {
            InitializeComponent();
            medicationController = new MedicationController(connectionString);
            PopulateDoctorComboBox();
            LoadPatientNames();
        }

        private void AddMedication_Load(object sender, EventArgs e)
        {

        }

        private void PopulateDoctorComboBox()
        {
            DataTable doctorsTable = medicationController.GetDoctors();
            if (doctorsTable != null)
            {
                txtPrescribingDoctorId.DataSource = doctorsTable;
                txtPrescribingDoctorId.DisplayMember = "FirstName"; // Display the first name in the control
                txtPrescribingDoctorId.ValueMember = "DoctorID";   // Save the DoctorID as the selected value
            }
        }

        private void LoadPatientNames()
        {
            DataTable patientsTable = medicationController.GetPatients();
            if (patientsTable != null)
            {
                txtPatientId.DataSource = patientsTable;
                txtPatientId.DisplayMember = "first_name"; // Display the first name in the control
                txtPatientId.ValueMember = "patientid";   // Save the PatientID as the selected value
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateInputFields())
            {
                return; // Validation failed
            }

            // Parse input values
            int patientId = (int)txtPatientId.SelectedValue;
            string medicationName = txtMedicationName.Text;
            string dosage = txtDosage.Text;
            string frequency = txtFrequency.Text;
            DateTime startDate = startDatePicker.Value;
            DateTime? endDate = endDatePicker.Checked ? endDatePicker.Value : (DateTime?)null; // Nullable DateTime
            string instructions = txtInstructions.Text;
            int prescribingDoctorId = (int)txtPrescribingDoctorId.SelectedValue;
            string notes = txtNotes.Text;

            // Insert medication record
            bool isSuccess = medicationController.InsertMedicationRecord(
                patientId, medicationName, dosage, frequency, startDate, endDate, instructions, prescribingDoctorId, notes);

            if (isSuccess)
            {
                // Medication record inserted successfully
                MessageBox.Show("Medication record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields
                this.Close();
            }
            else
            {
                // Medication record insertion failed
                MessageBox.Show("Failed to insert medication record. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputFields()
        {
            // Perform input field validation here
            // You can check if required fields are not empty, validate dates, etc.
            // Return true if validation passes, false otherwise

            if (string.IsNullOrWhiteSpace(txtPatientId.SelectedValue.ToString()) ||
                string.IsNullOrWhiteSpace(txtMedicationName.Text) ||
                string.IsNullOrWhiteSpace(txtDosage.Text) ||
                string.IsNullOrWhiteSpace(txtFrequency.Text) ||
                string.IsNullOrWhiteSpace(txtPrescribingDoctorId.SelectedValue.ToString()))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // You can add more validation logic as needed

            return true;
        }

        private void txtPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
