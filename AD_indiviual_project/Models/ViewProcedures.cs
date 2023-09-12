using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class ViewProcedures : Form
    {
        private string connectionString = Properties.Settings.Default.db_string;
        private int ProceduresID;

        public ViewProcedures(int ProceduresID)
        {
            InitializeComponent();
            this.ProceduresID = ProceduresID;
            LoadProceduresDetails();
        }

        private void LoadProceduresDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProceduresType, ProceduresData, Description, PatientID FROM Procedures WHERE ProcedureID = @ProceduresID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProceduresID", ProceduresID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the controls with procedures details
                        string proceduresType = reader["ProceduresType"].ToString();
                        string description = reader["Description"].ToString();
                        string PatientID = reader["PatientID"].ToString();

                        // Display the procedures type and description in appropriate labels or textboxes
                        lblProceduresType.Text = proceduresType;
                        lblDescription.Text =  description;
                        lblPatientID.Text =  PatientID;

                        // Assuming the file content is stored in a byte array in the database
                        byte[] fileData = (byte[])reader["ProceduresData"];

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
                        MessageBox.Show("Procedures not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
