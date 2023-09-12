using AD_indiviual_project.Controller;
using AD_indiviual_project.Pages;
using ServiceStack;
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
    public partial class UpdateMedication : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int MedicationId;
        private MedicationController medicationController;


        public UpdateMedication(int MedicationId)
        {
            InitializeComponent();
            this.MedicationId = MedicationId;
            // Load patient details using patientId
            LoadMedicationDetails();
            medicationController = new MedicationController(connectionString);
            // Populate ComboBox controls
            PopulateDoctorComboBox();
            LoadPatientNames();
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

        private void LoadMedicationDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Medications WHERE MedicationId = @MedicationId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicationId", MedicationId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with medication details
                        txtPatientId.SelectedValue = (int)reader["PatientId"];
                        txtMedicationName.Text = reader["MedicationName"].ToString();
                        txtDosage.Text = reader["Dosage"].ToString();
                        txtFrequency.Text = reader["Frequency"].ToString();
                        startDatePicker.Value = (DateTime)reader["StartDate"];

                        if (reader["EndDate"] != DBNull.Value)
                        {
                            endDatePicker.Checked = true;
                            endDatePicker.Value = (DateTime)reader["EndDate"];
                        }
                        else
                        {
                            endDatePicker.Checked = false;
                        }

                        txtInstructions.Text = reader["Instructions"].ToString();
                        txtPrescribingDoctorId.SelectedValue = (int)reader["PrescribingDoctorId"];
                        txtNotes.Text = reader["Notes"].ToString();
                    }
                }
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateInputFields())
            {
                return; // Validation failed
            }

            // Create a Medication object with updated values
            Medication updatedMedication = new Medication
            {
                MedicationID = MedicationId, // Assuming you have access to MedicationId
                PatientID = (int)txtPatientId.SelectedValue,
                MedicationName = txtMedicationName.Text,
                Dosage = txtDosage.Text,
                Frequency = txtFrequency.Text,
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Checked ? endDatePicker.Value : (DateTime?)null,
                Instructions = txtInstructions.Text,
                PrescribingDoctorID = (int)txtPrescribingDoctorId.SelectedValue,
                Notes = txtNotes.Text
            };

            // Call the UpdateMedication method with the Medication object
            bool isSuccess = medicationController.UpdateMedication(updatedMedication);


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

        private void UpdateMedication_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
