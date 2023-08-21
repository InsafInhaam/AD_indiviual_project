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
    public partial class AddPatient : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public AddPatient()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO patients (first_name, last_name, gender, birthdate, email, phone, address, medical_history, allergies, primary_doctor, insurance_provider)
                    VALUES (@FirstName, @LastName, @Gender, @Birthdate, @Email, @Phone, @Address, @MedicalHistory, @Allergies, @PrimaryDoctor, @InsuranceProvider)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
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

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Patient record inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert patient record.");
                    }
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
