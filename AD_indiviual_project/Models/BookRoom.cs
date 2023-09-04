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

        public BookRoom()
        {
            InitializeComponent();
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

                RecordRoomBooking(roomTheaterId, patientId, bookingFromDate, bookingToDate);
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

        private void RecordRoomBooking(int roomTheaterId, int patientId, DateTime bookingFromDate, DateTime bookingToDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Begin a transaction to ensure atomic updates
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Update RoomTheaterAvailability to mark the room as booked
                    string updateQuery = @"
                UPDATE RoomTheaterAvailability
                SET status = 'Booked', current_patient = @PatientId
                WHERE RoomTheaterAvailabilityID = @RoomTheaterId";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@RoomTheaterId", roomTheaterId);
                        updateCommand.Parameters.AddWithValue("@PatientId", patientId);

                        int updateRowsAffected = updateCommand.ExecuteNonQuery();

                        if (updateRowsAffected <= 0)
                        {
                            // If the update fails, roll back the transaction and show an error message
                            transaction.Rollback();
                            MessageBox.Show("Failed to update room/theater availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Record the room booking in the RoomBookings table
                    string insertQuery = @"
                INSERT INTO RoomBookings (room_theater_id, patient_id, booking_from_date, booking_to_date)
                VALUES (@RoomTheaterId, @PatientId, @BookingFromDate, @BookingToDate)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@RoomTheaterId", roomTheaterId);
                        insertCommand.Parameters.AddWithValue("@PatientId", patientId);
                        insertCommand.Parameters.AddWithValue("@BookingFromDate", bookingFromDate);
                        insertCommand.Parameters.AddWithValue("@BookingToDate", bookingToDate);

                        int insertRowsAffected = insertCommand.ExecuteNonQuery();

                        if (insertRowsAffected > 0)
                        {
                            // If everything is successful, commit the transaction
                            transaction.Commit();
                            MessageBox.Show("Room booking recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // If the insert fails, roll back the transaction and show an error message
                            transaction.Rollback();
                            MessageBox.Show("Failed to record room booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the transaction
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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