using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using Guna.UI2.WinForms;
using ServiceStack.OrmLite.Oracle;
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

namespace AD_indiviual_project.Pages
{
    public partial class Patient : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private PatientController patientManager;

        public Patient()
        {
            InitializeComponent();
            patientManager = new PatientController(connectionString);
            LoadPatientRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatient addpatient = new AddPatient();
            addpatient.Show();
        }

        public void LoadPatientRecords()
        {
            DataTable dataTable = patientManager.GetPatients();
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = patientManager.SearchPatients(searchText);
            dataGridView1.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int patientId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["patientid"].Value);

                    if (patientManager.DeletePatient(patientId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPatientRecords();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the patient ID from the selected row
                int patientId = Convert.ToInt32(selectedRow.Cells["patientid"].Value);

                // Open an update form or dialog to modify patient information
                // You can pass the patientId to the update form so it knows which record to update
                UpdatePatient updateForm = new UpdatePatient(patientId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the patient records after the update
                    LoadPatientRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single patient record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the patient ID from the selected row
                int patientId = Convert.ToInt32(selectedRow.Cells["patientid"].Value);

                // Create a new instance of the ViewProcedures form
                ViewPatient viewPatient = new ViewPatient(patientId);

                DialogResult result = viewPatient.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the patient records after the update
                    LoadPatientRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single patient record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}