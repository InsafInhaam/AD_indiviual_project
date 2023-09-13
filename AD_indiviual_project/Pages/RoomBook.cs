using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
