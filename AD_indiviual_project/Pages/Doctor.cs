using AD_indiviual_project.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Doctor : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public Doctor()
        {
            InitializeComponent();
            LoadDoctorRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoctors adddoctors = new AddDoctors();
            adddoctors.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDoctorRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Doctors"; // Change this query as needed

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Assuming dataGridView1 is the name of your DataGridView control
                }
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
