﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace AD_indiviual_project.Forms
{
    public partial class Login : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (IsValidUser(username, password, out string name, out string role))
            {       

                Session.Username = username;
                Session.Role = role;

                FrmMain mainForm = new FrmMain();               mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
        private bool IsValidUser(string username, string password, out string name, out string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM users WHERE Username=@Username";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string storedHashedPassword = dr["Password"].ToString();
                            string enteredPassword = password;

                            // Hash the entered password using the same hash function
                            string enteredHashedPassword = HashPassword(password);

                            if (storedHashedPassword == enteredHashedPassword)
                            {
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
            name = null;
            role = null;
            return false;
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
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
