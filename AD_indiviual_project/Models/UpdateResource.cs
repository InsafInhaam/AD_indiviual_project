using AD_indiviual_project.Controller;
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

namespace AD_indiviual_project.Models
{
    public partial class UpdateResource : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private ResourcesController resourceManager;
        private int resourceId;

        public UpdateResource(int resourceId)
        {
            InitializeComponent();
            this.resourceId = resourceId;
            // Load resource details using resourceId
            LoadHealthcareResourceDetails();
            resourceManager = new ResourcesController(connectionString);
        }

        private void LoadHealthcareResourceDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM HealthcareResources WHERE ResourceID = @ResourceID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ResourceID", resourceId); // Assuming resourceId is defined elsewhere

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with healthcare resource details
                        ResourceNameTextBox.Text = reader["ResourceName"].ToString();
                        ResourceTypeComboBox.SelectedItem = reader["ResourceType"].ToString(); // Assuming ResourceTypeComboBox is the combo box
                        SerialNumberTextBox.Text = reader["SerialNumber"].ToString();
                        ManufacturerTextBox.Text = reader["Manufacturer"].ToString();
                        ModelTextBox.Text = reader["Model"].ToString();
                        StatusTextBox.Text = reader["Status"].ToString();
                        NotesTextBox.Text = reader["Notes"].ToString();
                    }
                }
            }
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    // Call the UpdateResource method to update the resource record 
                    if (resourceManager.UpdateHealthcareResource(resourceId, ResourceNameTextBox.Text,
                ResourceTypeComboBox.Text,
                SerialNumberTextBox.Text,
                ManufacturerTextBox.Text,
                ModelTextBox.Text,
                StatusTextBox.Text,
                NotesTextBox.Text))
                    {
                        MessageBox.Show("Resource Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update resource record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating resource record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
