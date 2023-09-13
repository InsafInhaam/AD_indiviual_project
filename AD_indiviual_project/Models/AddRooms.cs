using AD_indiviual_project.Controller;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddRooms : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private RoomController roomManager;

        public AddRooms()
        {
            InitializeComponent();
            roomManager = new RoomController(connectionString);
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
                string roomTheaterNumber = roomTheaterNo.Text;
                string type = roomtype.SelectedItem.ToString();
                string status = "Available";
                string roomNote = roomNotes.Text;

                roomManager.AddRoomTheaterAvailability(roomTheaterNumber, type, status, roomNote);
            }
        }
    }
}