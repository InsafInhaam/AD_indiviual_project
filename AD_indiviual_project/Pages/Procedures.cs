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

                string query = "SELECT * FROM Procedures"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; 
                }
            }
        }

        private void ViewResoucres_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int ProcedureID = Convert.ToInt32(selectedRow.Cells["ProcedureID"].Value);

                ViewProcedures viewForm = new ViewProcedures(ProcedureID);
                DialogResult result = viewForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadProceduresRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single patient record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadProceduresRecords();

        }
    }
}
