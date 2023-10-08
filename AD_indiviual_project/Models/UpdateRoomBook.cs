using AD_indiviual_project.Controller;
using AD_indiviual_project.Pages;
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
    public partial class UpdateRoomBook : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private BookRoomController bookRoomManager;
        private int roomBookId;

        public UpdateRoomBook(int roomBookId)
        {
            InitializeComponent();
            bookRoomManager = new BookRoomController(connectionString);
            this.roomBookId = roomBookId;
            LoadPatientNames();
            LoadRoomTheaterNumbers();
        }


        private void LoadRoomTheaterNumbers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT RoomTheaterAvailabilityID, room_theater_number FROM RoomTheaterAvailability WHERE status = 'Available'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable roomTheaterTable = new DataTable();
                        adapter.Fill(roomTheaterTable);

                        // Assuming you have a ComboBox named 'roomTheaterComboBox'
                        roomTheaterComboBox.DataSource = roomTheaterTable;
                        roomTheaterComboBox.DisplayMember = "room_theater_number";
                        roomTheaterComboBox.ValueMember = "RoomTheaterAvailabilityID";
                    }
                }
            }
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
    }
}
