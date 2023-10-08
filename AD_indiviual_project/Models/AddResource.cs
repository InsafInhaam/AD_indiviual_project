using AD_indiviual_project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddResource : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private ResourcesController resourceManager;

        public AddResource()
        {
            InitializeComponent();
            resourceManager = new ResourcesController(connectionString);
        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(ResourceNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ResourceTypeComboBox.Text) ||
                string.IsNullOrWhiteSpace(SerialNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(ManufacturerTextBox.Text) ||
                string.IsNullOrWhiteSpace(ModelTextBox.Text) ||
                string.IsNullOrWhiteSpace(StatusTextBox.Text) ||
                string.IsNullOrWhiteSpace(NotesTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddResource_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    if (resourceManager.AddHealthcareResource(ResourceNameTextBox.Text,
                ResourceTypeComboBox.SelectedItem.ToString(),
                SerialNumberTextBox.Text,
                ManufacturerTextBox.Text,
                ModelTextBox.Text,
                StatusTextBox.Text,
                NotesTextBox.Text))
                    {
                        MessageBox.Show("Healthcare Resource Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while saving Healthcare Resource data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
