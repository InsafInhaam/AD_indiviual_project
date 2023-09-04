using AD_indiviual_project.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Resources : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public Resources()
        {
            InitializeComponent();
            LoadResourcesRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddResources addresources = new AddResources();
            addresources.Show();
        }

        private void LoadResourcesRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Resources"; // Change this query as needed

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Assuming dataGridView1 is the name of your DataGridView control
                }
            }
        }

        private void ViewResoucres_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the patient ID from the selected row
                int ResourceID = Convert.ToInt32(selectedRow.Cells["ResourceID"].Value);

                // Create a new instance of the ViewResources form
                ViewResources viewForm = new ViewResources(ResourceID);
                DialogResult result = viewForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the patient records after the update
                    LoadResourcesRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single patient record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
