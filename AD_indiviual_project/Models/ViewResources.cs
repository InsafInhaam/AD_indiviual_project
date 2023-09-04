using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class ViewResources : Form
    {
        private string connectionString = Properties.Settings.Default.db_string;
        private int ResourceID;

        public ViewResources(int ResourceID)
        {
            InitializeComponent();
            this.ResourceID = ResourceID;
            LoadResourceDetails();
        }

        private void ViewResources_Load(object sender, EventArgs e)
        {

        }

        private void LoadResourceDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ResourceType, ResourceData, Description, PatientID FROM Resources WHERE ResourceID = @ResourceID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ResourceID", ResourceID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the controls with resource details
                        string resourceType = reader["ResourceType"].ToString();
                        string description = reader["Description"].ToString();
                        string PatientID = reader["PatientID"].ToString();

                        // Display the resource type and description in appropriate labels or textboxes
                        lblResourceType.Text = resourceType;
                        lblDescription.Text =  description;
                        lblPatientID.Text =  PatientID;

                        // Assuming the file content is stored in a byte array in the database
                        byte[] fileData = (byte[])reader["ResourceData"];

                        // Create a MemoryStream from the byte array
                        using (MemoryStream ms = new MemoryStream(fileData))
                        {
                            // Create an Image object from the MemoryStream
                            Image image = Image.FromStream(ms);

                            // Assign the Image object to the PictureBox control
                            pictureBox.Image = image;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Resource not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
