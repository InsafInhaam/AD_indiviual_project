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
    public partial class BookRoom : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private BookRoomController bookRoomManager;

        public BookRoom()
        {
            InitializeComponent();
            bookRoomManager = new BookRoomController(connectionString);
            LoadPatientNames();
            LoadRoomTheaterNumbers();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (roomTheaterComboBox.SelectedItem is DataRowView roomTheaterItem &&
        patientComboBox.SelectedItem is DataRowView patientItem &&
        roomTheaterItem.Row["RoomTheaterAvailabilityID"] is int roomTheaterId &&
        patientItem.Row["patientid"] is int patientId)
            {
                DateTime bookingFromDate = BookingFromDate.Value;
                DateTime bookingToDate = BookingToDate.Value;

                bookRoomManager.RecordRoomBooking(roomTheaterId, patientId, bookingFromDate, bookingToDate);
            }
            else
            {
                MessageBox.Show("Invalid selection. Please choose valid room and patient.");
            }
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

        private void BookRoom_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}