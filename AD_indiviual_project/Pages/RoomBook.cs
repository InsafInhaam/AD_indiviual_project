using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class RoomBook : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private BookRoomController bookRoomManager;

        public RoomBook()
        {
            InitializeComponent();
            bookRoomManager = new BookRoomController(connectionString);
            LoadBookRoomRecords();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BookRoom addbookroom = new BookRoom();
            addbookroom.Show();
        }

        public void LoadBookRoomRecords()
        {
            DataTable dataTable = bookRoomManager.GetBookRooms();
            dataGridView1.DataSource = dataTable;
        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = bookRoomManager.SearchBookRooms(searchText);
            dataGridView1.DataSource = dataTable;
        }

        private void RoomBook_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadBookRoomRecords();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int roomBookId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                UpdateRoomBook updateForm = new UpdateRoomBook(roomBookId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadBookRoomRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single roomBook record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int roomBookId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id"].Value);

                    if (bookRoomManager.DeleteBookRoom(roomBookId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookRoomRecords();
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
    }
}