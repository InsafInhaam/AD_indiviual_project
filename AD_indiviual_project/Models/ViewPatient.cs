using AD_indiviual_project.Controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class ViewPatient : Form
    {
        private string connectionString = Properties.Settings.Default.db_string;
        private int patientId;
        private PatientController patientManager;

        public ViewPatient(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            LoadPatientDetails();
            patientManager = new PatientController(connectionString);
            LoadPatientAppointmentRecords();
            LoadPatientMedicationsRecords();
            LoadPatientProceduresRecords();
        }

        private void LoadPatientDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM patients WHERE patientid = @PatientId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with patient details
                        FirstNameTextBox.Text = reader["first_name"].ToString();
                        LastNameTextBox.Text = reader["last_name"].ToString();
                        GenderComboBox.SelectedItem = reader["gender"].ToString();
                        BirthdatePicker.Text = reader["birthdate"].ToString();
                        EmailTextBox.Text = reader["email"].ToString();
                        PhoneTextBox.Text = reader["phone"].ToString();
                        AddressTextBox.Text = reader["address"].ToString();
                        MedicalHistoryTextBox.Text = reader["medical_history"].ToString();
                        AllergiesTextBox.Text = reader["allergies"].ToString();
                        PrimaryDoctorTextBox.Text = reader["primary_doctor"].ToString();
                        InsuranceProviderTextBox.Text = reader["insurance_provider"].ToString();
                    }
                }
            }
        }

        private void LoadPatientAppointmentRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Appointments where PatientID = @PatientId"; // Change this query as needed

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    AppointmentsDataGridView.DataSource = dataTable; // Assuming dataGridView1 is the name of your DataGridView control
                }
            }
        }

        private void LoadPatientMedicationsRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Medications where PatientId = @PatientId"; // Change this query as needed

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    MeditationsDataGridView.DataSource = dataTable; // Assuming dataGridView1 is the name of your DataGridView control
                }
            }
        }

        private void LoadPatientProceduresRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Procedures where PatientID = @PatientId"; // Change this query as needed

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    ProceduresDataGridView.DataSource = dataTable; // Assuming dataGridView1 is the name of your DataGridView control
                }
            }
        }

        private void ViewPatient_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void PrimaryDoctorTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void InsuranceProviderTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void MeditationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
