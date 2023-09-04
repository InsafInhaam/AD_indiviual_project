using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddRooms : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public AddRooms()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomTheaterNumber = roomTheaterNo.Text;
            string type = roomtype.SelectedItem.ToString();
            string status = "Available";
            string scheduledProcedures = ScheduledProcedures.Text;

            AddRoomTheaterAvailability(roomTheaterNumber, type, status, scheduledProcedures);
        }


        private void AddRoomTheaterAvailability(string roomTheaterNumber, string type, string status, string scheduledProcedures)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO RoomTheaterAvailability (room_theater_number, type, status, scheduled_procedures)
            VALUES (@RoomTheaterNumber, @Type, @Status, @ScheduledProcedures)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@RoomTheaterNumber", roomTheaterNumber);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ScheduledProcedures", scheduledProcedures);

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

        private void AddRooms_Load(object sender, EventArgs e)
        {

        }

        private void roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
