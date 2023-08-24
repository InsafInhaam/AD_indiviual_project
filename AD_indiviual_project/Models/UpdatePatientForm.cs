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
    public partial class UpdatePatientForm : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int patientId;
        public UpdatePatientForm(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            // Load patient details using patientId
            LoadPatientDetails();
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @" UPDATE patients SET first_name = @FirstName, last_name = @LastName, gender = @Gender, birthdate = @Birthdate, email = @Email, phone = @Phone, address = @Address, medical_history = @MedicalHistory, allergies = @Allergies, primary_doctor = @PrimaryDoctor, insurance_provider = @InsuranceProvider WHERE patientid = @PatientId";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        command.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                        command.Parameters.AddWithValue("@Gender", GenderComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Birthdate", BirthdatePicker.Value);
                        command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                        command.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                        command.Parameters.AddWithValue("@MedicalHistory", MedicalHistoryTextBox.Text);
                        command.Parameters.AddWithValue("@Allergies", AllergiesTextBox.Text);
                        command.Parameters.AddWithValue("@PrimaryDoctor", PrimaryDoctorTextBox.Text);
                        command.Parameters.AddWithValue("@InsuranceProvider", InsuranceProviderTextBox.Text);

                        command.Parameters.AddWithValue("@PatientId", patientId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update patient details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
