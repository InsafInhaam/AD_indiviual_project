using AD_indiviual_project.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Procedures : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public Procedures()
        {
            InitializeComponent();
            LoadProceduresRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProcedures addprocedures = new AddProcedures();
            addprocedures.Show();
        }

        private void LoadProceduresRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Procedures"; // Change this query as needed

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
                int ProcedureID = Convert.ToInt32(selectedRow.Cells["ProcedureID"].Value);

                // Create a new instance of the ViewProcedures form
                ViewProcedures viewForm = new ViewProcedures(ProcedureID);
                DialogResult result = viewForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the patient records after the update
                    LoadProceduresRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single patient record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
