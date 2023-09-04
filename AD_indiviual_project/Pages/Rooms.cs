using AD_indiviual_project.Models;
using System;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Rooms : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public Rooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRooms addrooms = new AddRooms();
            addrooms.Show();
        }
    }
}
