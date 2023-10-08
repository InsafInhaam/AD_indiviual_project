using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Doctor : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private DoctorController doctorManager;

        public Doctor()
        {
            InitializeComponent();
            doctorManager = new DoctorController(connectionString);
            LoadDoctorRecords();
            SetupSidebar();
        }
        private void SetupSidebar()
        {
            // Check the user's role from the session
            if (Session.Role == "Admin")  // 1 is for admin
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else if (Session.Role == "Staff")  // 0 is for staffs
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoctors adddoctors = new AddDoctors();
            adddoctors.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDoctorRecords()
        {
            DataTable dataTable = doctorManager.GetDoctors();
            dataGridView1.DataSource = dataTable;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = doctorManager.SearchDoctors(searchText);
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
                    int doctorId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["doctorid"].Value);

                    if (doctorManager.DeleteDoctor(doctorId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoctorRecords();
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

                // Extract the doctor ID from the selected row
                int doctorId = Convert.ToInt32(selectedRow.Cells["doctorid"].Value);

                // You can pass the doctorId to the update form so it knows which record to update
                UpdateDoctor updateForm = new UpdateDoctor(doctorId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the doctor records after the update
                    LoadDoctorRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single doctor record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadDoctorRecords();
        }
    }
}
