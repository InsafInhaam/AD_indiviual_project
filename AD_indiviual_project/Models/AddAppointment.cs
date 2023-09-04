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
    public partial class AddAppointment : Form
    {
        private string connectionString = Properties.Settings.Default.db_string;

        public AddAppointment()
        {
            InitializeComponent();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            PopulateDoctorComboBox();
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

                            doctorComboBox.Items.Add(new DoctorItem(doctorID, doctorFullName));
                        }
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

        }
    }

    // Create a class to store doctor information along with their IDs
    public class DoctorItem
    {
        public int DoctorID { get; set; }
        public string DoctorFullName { get; set; }

        public DoctorItem(int id, string fullName)
        {
            DoctorID = id;
            DoctorFullName = fullName;
        }

        public override string ToString()
        {
            return DoctorFullName;
        }
    }
}
