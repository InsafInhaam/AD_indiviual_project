using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using Kimtoo.Reports;
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

namespace AD_indiviual_project.Pages
{
    public partial class Staff : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private StaffController staffManager;

        public Staff()
        {
            InitializeComponent();
            staffManager = new StaffController(connectionString);
            LoadStaffRecords();
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

        private void button6_Click(object sender, EventArgs e)
        {
            AddStaff addstaff = new AddStaff();
            addstaff.Show();
        }  

        private void LoadStaffRecords()
        {
            DataTable dataTable = staffManager.GetStaffs();
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int staffId = Convert.ToInt32(selectedRow.Cells["staffid"].Value);

                UpdateStaff updateForm = new UpdateStaff(staffId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadStaffRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single staff record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = staffManager.SearchStaffs(searchText);
            dataGridView1.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int staffId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["staffid"].Value);

                    if (staffManager.DeleteStaff(staffId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaffRecords();
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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadStaffRecords();
        }
    }
}
