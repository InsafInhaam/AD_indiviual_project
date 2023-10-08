using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AD_indiviual_project.Forms
{
    public partial class UserLogin : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);

        public UserLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {         
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM users WHERE Username=@Username";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    string username = UsernameTextBox.Text;
                    string password = PasswordTextBox.Text;

                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string role = dr["role"].ToString();
                            string storedHashedPassword = dr["Password"].ToString();
                            string enteredPassword = password;

                            // Hash the entered password using the same hash function
                            string enteredHashedPassword = HashPassword(password);

                            if (storedHashedPassword == enteredHashedPassword)
                            {
                                Session.Username = username;
                                Session.Role = role;

                                this.Hide();
                                FrmMain frmmain = new FrmMain();
                                frmmain.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        //hash password function 
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); 
                }

                return builder.ToString();
            }
        }
    }
}
