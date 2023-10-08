using AD_indiviual_project.Controller;
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
    public partial class UpdateDoctor : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int doctorId;
        private DoctorController doctorManager;

        public UpdateDoctor(int doctorId)
        {
            InitializeComponent();
            this.doctorId = doctorId;
            doctorManager = new DoctorController(connectionString);
            LoadDoctorDetails();
        }

        private void LoadDoctorDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Doctors WHERE DoctorID = @DoctorId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorId", doctorId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with doctor details
                        yearsOfExperienceTextBox.Text = reader["YearsOfExperience"].ToString();
                        previousHospitalsTextBox.Text = reader["PreviousHospitals"].ToString();
                        firstNameTextBox.Text = reader["FirstName"].ToString();
                        lastNameTextBox.Text = reader["LastName"].ToString();
                        genderComboBox.SelectedItem = reader["Gender"].ToString();
                        dateOfBirthPicker.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                        phoneNumberTextBox.Text = reader["PhoneNumber"].ToString();
                        emailAddressTextBox.Text = reader["EmailAddress"].ToString();
                        addressTextBox.Text = reader["Address"].ToString();
                        degreeTextBox.Text = reader["MedicalDegree"].ToString();
                        specializationTextBox.SelectedItem = reader["Specialization"].ToString();
                        licenseTextBox.Text = reader["MedicalLicenseNumber"].ToString();
                        availableTimeTextBox.Text = reader["AvailableTime"].ToString();

                        // You might want to load and display the doctor's availability here
                       // LoadDoctorAvailability();
                    }
                }
            }
        }

        

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(yearsOfExperienceTextBox.Text) ||
                string.IsNullOrWhiteSpace(previousHospitalsTextBox.Text) ||
                string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                genderComboBox.SelectedItem == null ||
                dateOfBirthPicker.Value == default ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(degreeTextBox.Text) ||
                specializationTextBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(licenseTextBox.Text) ||
                string.IsNullOrWhiteSpace(availableTimeTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields and ensure valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // You can add additional validation logic as needed

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    // Create a Doctor object with the updated information
                    Doctor updatedDoctor = new Doctor
                    {
                        DoctorID = doctorId, // You need to capture the DoctorID from your form
                        YearsOfExperience = int.Parse(yearsOfExperienceTextBox.Text),
                        PreviousHospitals = previousHospitalsTextBox.Text,
                        FirstName = firstNameTextBox.Text,
                        LastName = lastNameTextBox.Text,
                        Gender = genderComboBox.SelectedItem.ToString(),
                        DateOfBirth = dateOfBirthPicker.Value,
                        PhoneNumber = phoneNumberTextBox.Text,
                        EmailAddress = emailAddressTextBox.Text,
                        Address = addressTextBox.Text,
                        MedicalDegree = degreeTextBox.Text,
                        Specialization = specializationTextBox.SelectedItem.ToString(),
                        MedicalLicenseNumber = licenseTextBox.Text,
                        AvailableTime = availableTimeTextBox.Text
                        // Add other properties as needed
                    };

                    if (doctorManager.UpdateDoctor(updatedDoctor))
                    {
                        MessageBox.Show("Doctor information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Close the form or perform any other necessary actions
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while updating doctor information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}