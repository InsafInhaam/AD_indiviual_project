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
    public partial class UpdateRoom : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int roomId;
        private RoomController roomManager;

        public UpdateRoom(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
            roomManager = new RoomController(connectionString);
            LoadRoomDetails();
        }

        private void LoadRoomDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM RoomTheaterAvailability WHERE RoomTheaterAvailabilityID = @RoomId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomId", roomId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with patient details
                        roomTheaterNo.Text = reader["room_theater_number"].ToString();
                        roomtype.SelectedItem = reader["type"].ToString();
                        roomNotes.Text = reader["scheduled_procedures"].ToString();
                    }
                }
            }
        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(roomTheaterNo.Text) ||
                roomtype.SelectedItem == null ||
                string.IsNullOrWhiteSpace(roomNotes.Text))
            {
                MessageBox.Show("Please fill in all required fields for room theater availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    // Call the UpdateRoomTheaterAvailability method to update the Room/Theater availability record 
                    if (roomManager.UpdateRoomAvailability(roomId, roomTheaterNo.Text,
                        roomtype.SelectedItem.ToString(),
                        roomNotes.Text))
                    {
                        MessageBox.Show("Room/Theater availability updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Room/Theater availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating Room/Theater availability: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
