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
            SetupSidebar();
        }

        private void SetupSidebar()
        {
            if (Session.Role == "Admin")  
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else if (Session.Role == "Staff") 
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
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

                int roomId = Convert.ToInt32(selectedRow.Cells["RoomTheaterAvailabilityID"].Value);

                UpdateRoom updateForm = new UpdateRoom(roomId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadRoomRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single room record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadRoomRecords();

        }

        /* ----------------------------------------------------------
                 patienr_clear NULL
         ----------------------------------------------------------*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int room_theotor_id = (int)selectedRow.Cells["RoomTheaterAvailabilityID"].Value;

                object currentPatientValue = selectedRow.Cells["current_patient"].Value;

                if (currentPatientValue == null || currentPatientValue == DBNull.Value)
                {
                    MessageBox.Show("The current patient is already null.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool updateSuccess = roomManager.ClearCurrentPatient(room_theotor_id);

                    if (updateSuccess)
                    {
                        LoadRoomRecords();

                        MessageBox.Show("Current patient cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to clear current patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to clear the current patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
