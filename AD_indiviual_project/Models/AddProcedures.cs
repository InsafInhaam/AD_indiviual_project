﻿using System;
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
    public partial class AddProcedures : Form
    {
        private string connectionString = Properties.Settings.Default.db_string;
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public AddProcedures()
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
                string filePath = openFileDialog.FileName;
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string proceduresType = cmbProceduresType.SelectedItem.ToString();

            // Get the selected file path (assuming it's assigned to filePath)
            string filePath = openFileDialog.FileName;

            if (string.IsNullOrEmpty(proceduresType) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select a procedures type and upload a file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            INSERT INTO Procedures (PatientID, ProceduresType, ProceduresData, Description)
            VALUES (@PatientID, @ProceduresType, @ProceduresData, @Description)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", selectedPatientID);
                    command.Parameters.AddWithValue("@ProceduresType", proceduresType);
                    command.Parameters.AddWithValue("@ProceduresData", fileData);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text); // Add a description field if needed

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Procedures information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save procedures information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
