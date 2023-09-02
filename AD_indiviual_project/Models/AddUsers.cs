using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddUsers : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public AddUsers()
        {
            InitializeComponent();
            PopulateStaffIDs();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateStaffIDs()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT staffid FROM staffs";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int staffID = reader.GetInt32(0);
                            staffIDTextBox.Items.Add(staffID);
                        }
                    }
                }
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
            INSERT INTO users (username, password, staffid, role)
            VALUES (@Username, @Password, @StaffID, @Role)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                        // Encrypt the password using SHA-256 hash
                        string hashedPassword = HashPassword(passwordTextBox.Text);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@StaffID", Convert.ToInt32(staffIDTextBox.SelectedItem));
                        command.Parameters.AddWithValue("@Role", roleTextBox.SelectedItem);
                        // Console.WriteLine(staffIDTextBox.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("User record inserted successfully.");
                            MessageBox.Show("User record inserted successfully.");
                            Close();
                        }
                        else
                        {
                            Console.WriteLine("Failed to insert user record.");
                            MessageBox.Show("Failed to insert user record.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //define  the hash password function 
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); // Convert to hexadecimal format
                }

                return builder.ToString();
            }
        }

        private bool ValidateInputFields()
        {
            return
                !string.IsNullOrWhiteSpace(usernameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(passwordTextBox.Text) &&
                !string.IsNullOrWhiteSpace(staffIDTextBox.Text) &&
                !string.IsNullOrWhiteSpace(roleTextBox.Text);
        }
    }
}