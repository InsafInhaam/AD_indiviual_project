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
    public partial class UpdatePatient : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int patientId;
        private PatientController patientManager;

        public UpdatePatient(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            // Load patient details using patientId
            LoadPatientDetails();
            patientManager = new PatientController(connectionString);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePatientForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadPatientDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM patients WHERE patientid = @PatientId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with patient details
                        FirstNameTextBox.Text = reader["first_name"].ToString();
                        LastNameTextBox.Text = reader["last_name"].ToString();
                        GenderComboBox.SelectedItem = reader["gender"].ToString();
                        BirthdatePicker.Text = reader["birthdate"].ToString();
                        EmailTextBox.Text = reader["email"].ToString();
                        PhoneTextBox.Text = reader["phone"].ToString();
                        AddressTextBox.Text = reader["address"].ToString();
                        MedicalHistoryTextBox.Text = reader["medical_history"].ToString();
                        AllergiesTextBox.Text = reader["allergies"].ToString();
                        PrimaryDoctorTextBox.Text = reader["primary_doctor"].ToString();
                        InsuranceProviderTextBox.Text = reader["insurance_provider"].ToString();
                    }
                }
            }
        }

         private void guna2ImageButton1_Click(object sender, EventArgs e)
         {
            this.Hide();
         }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                GenderComboBox.SelectedItem == null ||
                BirthdatePicker.Value == default ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(MedicalHistoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(AllergiesTextBox.Text) ||
                string.IsNullOrWhiteSpace(PrimaryDoctorTextBox.Text) ||
                string.IsNullOrWhiteSpace(InsuranceProviderTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    // Call the UpdatePatient method to update the patient record 
                    if (patientManager.UpdatePatient(patientId, FirstNameTextBox.Text, LastNameTextBox.Text, GenderComboBox.SelectedItem.ToString(), BirthdatePicker.Value, EmailTextBox.Text,
                    PhoneTextBox.Text, AddressTextBox.Text, MedicalHistoryTextBox.Text, AllergiesTextBox.Text,
                    PrimaryDoctorTextBox.Text, InsuranceProviderTextBox.Text))
                    {
                        MessageBox.Show("Patient Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update patient record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}