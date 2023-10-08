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
    public partial class Resources : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private ResourcesController resourceManager;

        public Resources()
        {
            InitializeComponent();
            resourceManager = new ResourcesController(connectionString);
            LoadResourceRecords();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadResourceRecords();
        }

        public void LoadResourceRecords()
        {
            DataTable dataTable = resourceManager.GetResources();
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddResource addresource = new AddResource();
            addresource.Show();
        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = resourceManager.SearchResources(searchText);
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
                    int resourceId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["resourceid"].Value);

                    if (resourceManager.DeleteResource(resourceId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadResourceRecords();
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

                int resourceId = Convert.ToInt32(selectedRow.Cells["resourceid"].Value);

                UpdateResource updateForm = new UpdateResource(resourceId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadResourceRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single resource record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
