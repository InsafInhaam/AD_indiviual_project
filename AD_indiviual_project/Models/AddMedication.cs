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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectDoctorsQuery = "SELECT DoctorID, FirstName, LastName FROM Doctors";

                    SqlCommand command = new SqlCommand(selectDoctorsQuery, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int doctorID = reader.GetInt32(0);
                            string firstName = reader.GetString(1);
                            string lastName = reader.GetString(2);

                            string doctorFullName = $"{firstName} {lastName}";

                            txtPrescribingDoctorId.Items.Add(new DoctorItem(doctorID, doctorFullName));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPatientNames()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch patient names and IDs from the Patients table
                    string query = "SELECT patientid, first_name, last_name FROM patients";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Bind the ComboBox or DropDownList with patient names and IDs
                        txtPatientId.DataSource = dataTable;
                        txtPatientId.DisplayMember = "first_name"; // Display the first name in the control
                        txtPatientId.ValueMember = "patientid";   // Save the PatientID as the selected value
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int patientId = int.Parse(txtPatientId.Text);
            string medicationName = txtMedicationName.Text;
            string dosage = txtDosage.Text;
            string frequency = txtFrequency.Text;
            DateTime startDate = startDatePicker.Value;
            DateTime? endDate = endDatePicker.Checked ? endDatePicker.Value : (DateTime?)null; // Nullable DateTime
            string instructions = txtInstructions.Text;
            int prescribingDoctorId = int.Parse(txtPrescribingDoctorId.Text);
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

            if (string.IsNullOrWhiteSpace(txtPatientId.Text) ||
                string.IsNullOrWhiteSpace(txtMedicationName.Text) ||
                string.IsNullOrWhiteSpace(txtDosage.Text) ||
                string.IsNullOrWhiteSpace(txtFrequency.Text) ||
                string.IsNullOrWhiteSpace(txtPrescribingDoctorId.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // You can add more validation logic as needed

            return true;
        }
    }
}
