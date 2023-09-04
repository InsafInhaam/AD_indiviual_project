using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddResources : Form
    {
        private string connectionString = Properties.Settings.Default.db_string;
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public AddResources()
        {
            InitializeComponent();
            LoadPatientNames();
        }

        private void LoadPatientNames()
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
                    patientComboBox.DataSource = dataTable;
                    patientComboBox.DisplayMember = "first_name"; // Display the first name in the control
                    patientComboBox.ValueMember = "patientid";   // Save the PatientID as the selected value
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                // You can display the file name or other information to the user
                // For example: lblSelectedFile.Text = Path.GetFileName(filePath);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string resourceType = cmbResourceType.SelectedItem.ToString();

            // Get the selected file path (assuming it's assigned to filePath)
            string filePath = openFileDialog.FileName;

            if (string.IsNullOrEmpty(resourceType) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select a resource type and upload a file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Read the file into a byte array
            byte[] fileData = File.ReadAllBytes(filePath);

            int selectedPatientID = (int)patientComboBox.SelectedValue;

            // Insert data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO Resources (PatientID, ResourceType, ResourceData, UploadDate, Description)
            VALUES (@PatientID, @ResourceType, @ResourceData, GETDATE(), @Description)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", selectedPatientID);
                    command.Parameters.AddWithValue("@ResourceType", resourceType);
                    command.Parameters.AddWithValue("@ResourceData", fileData);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text); // Add a description field if needed

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Resource information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save resource information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void AddResources_Load(object sender, EventArgs e)
        {

        }

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (patientComboBox.SelectedItem != null)
            {
                if (int.TryParse(patientComboBox.SelectedValue.ToString(), out int selectedPatientID))
                {
                    // You can now safely use the selectedPatientID as an integer.
                }
                else
                {
                    // Handle the case where the conversion to int failed.
                    // For example, display an error message or provide a default value.
                    MessageBox.Show("Invalid selected patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
