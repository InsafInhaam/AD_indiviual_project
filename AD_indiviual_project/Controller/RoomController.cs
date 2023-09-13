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
    public class RoomController
    {
        private string connectionString;

        public RoomController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetRooms()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM RoomTheaterAvailability";

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

        public bool DeleteRoom(int roomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM RoomTheaterAvailability WHERE RoomTheaterAvailabilityID = @RoomId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable SearchRooms(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM RoomTheaterAvailability WHERE room_theater_number LIKE @SearchText OR type LIKE @SearchText";
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

        public void AddRoomTheaterAvailability(string roomTheaterNumber, string type, string status, string roomNote)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO RoomTheaterAvailability (room_theater_number, type, status, scheduled_procedures)
            VALUES (@RoomTheaterNumber, @Type, @Status, @roomNote)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@RoomTheaterNumber", roomTheaterNumber);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@roomNote", roomNote);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room/Theater availability added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add room/theater availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool UpdateRoomAvailability(int roomTheaterId, string roomTheaterNumber, string type, string roomNote)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @"
                UPDATE RoomTheaterAvailability
                SET room_theater_number = @RoomTheaterNumber,
                    type = @Type,
                    scheduled_procedures = @RoomNote
                WHERE RoomTheaterAvailabilityID = @RoomTheaterId";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@RoomTheaterNumber", roomTheaterNumber);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@RoomNote", roomNote);
                        command.Parameters.AddWithValue("@RoomTheaterId", roomTheaterId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the Room/Theater availability: " + ex.Message);
                return false;
            }
        }

    }
}
