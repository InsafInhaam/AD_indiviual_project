using AD_indiviual_project.Models;
using Guna.UI2.WinForms;
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
        private string connectionString = Properties.Settings.Default.db_string;
        private DataAccess dataAccess;

        public Patient()
        {
            InitializeComponent();
            dataAccess = new DataAccess(connectionString);
            LoadPatientRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatient addpatient = new AddPatient();
            addpatient.Show();
        }

        private void LoadPatientRecords()
        {
            List<PatientData> patients = dataAccess.GetPatients();
            dataGridView1.DataSource = patients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            List<PatientData> patients = dataAccess.SearchPatients(searchText);
            dataGridView1.DataSource = patients;
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

                    if (dataAccess.DeletePatient(patientId))
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
                    UpdatePatientForm updateForm = new UpdatePatientForm(patientId);
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
    }

    public class PatientData
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }

        public PatientData(int patientId, string firstName, string gender)
        {
            PatientId = patientId;
            FirstName = firstName;
            Gender = gender;
        }
    }

    public class DataAccess
    {
        private string connectionString;

        public DataAccess(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<PatientData> GetPatients()
        {
            List<PatientData> patients = new List<PatientData>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM patients";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int patientId = (int)reader["patientid"];
                            string firstName = reader["first_name"].ToString();
                            string gender = reader["gender"].ToString();

                            patients.Add(new PatientData(patientId, firstName, gender));
                        }
                    }
                }
            }

            return patients;
        }

        public List<PatientData> SearchPatients(string searchText)
        {
            List<PatientData> patients = new List<PatientData>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM patients WHERE first_name LIKE @SearchText OR gender LIKE @SearchText";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int patientId = (int)reader["patientid"];
                            string firstName = reader["first_name"].ToString();
                            string gender = reader["gender"].ToString();

                            patients.Add(new PatientData(patientId, firstName, gender));
                        }
                    }
                }
            }

            return patients;
        }

        public bool DeletePatient(int patientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM patients WHERE patientid = @PatientId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
