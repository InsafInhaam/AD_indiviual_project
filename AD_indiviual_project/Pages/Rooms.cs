using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Rooms : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private RoomController roomManager;

        public Rooms()
        {
            InitializeComponent();
            roomManager = new RoomController(connectionString);
            LoadRoomRecords();
        }

        public void LoadRoomRecords()
        {
            DataTable dataTable = roomManager.GetRooms();
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRooms addrooms = new AddRooms();
            addrooms.Show();
        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = roomManager.SearchRooms(searchText);
            dataGridView1.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int roomId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["RoomTheaterAvailabilityID"].Value);

                    if (roomManager.DeleteRoom(roomId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomRecords();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the room ID from the selected row
                int roomId = Convert.ToInt32(selectedRow.Cells["RoomTheaterAvailabilityID"].Value);

                // Open an update form or dialog to modify room information
                // You can pass the roomId to the update form so it knows which record to update
                UpdateRoom updateForm = new UpdateRoom(roomId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the room records after the update
                    LoadRoomRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single room record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
