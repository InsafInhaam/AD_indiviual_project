using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Controller
{
    public class BookRoomController
    {
        private string connectionString;

        public BookRoomController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetBookRooms()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM RoomBookings";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }

        public bool DeleteBookRoom(int bookroomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM RoomBookings WHERE id = @BookRoomId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookRoomId", bookroomId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable SearchBookRooms(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM RoomBookings WHERE patient_id LIKE @SearchText OR room_theater_id LIKE @SearchText";
                    // You can modify the query to include additional search fields

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }

        public void RecordRoomBooking(int roomTheaterId, int patientId, DateTime bookingFromDate, DateTime bookingToDate)
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
    }
}
