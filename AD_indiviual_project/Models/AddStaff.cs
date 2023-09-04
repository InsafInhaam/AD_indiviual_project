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
    public partial class AddStaff : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        public AddStaff()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                    INSERT INTO staffs (first_name, last_name, gender, birthdate, email, phone, address, department, position, salary, hire_date)
                    VALUES (@FirstName, @LastName, @Gender, @Birthdate, @Email, @Phone, @Address, @Department, @Position, @Salary, @HireDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", staffFirstnameTextBox.Text);
                        command.Parameters.AddWithValue("@LastName", staffLastnameTextBox.Text);
                        command.Parameters.AddWithValue("@Gender", GenderComboBox.SelectedItem.ToString()); 
                        command.Parameters.AddWithValue("@Birthdate", BirthdatePicker.Value);
                        command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        command.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                        command.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                        command.Parameters.AddWithValue("@Department", DepartmentTextBox.Text);
                        command.Parameters.AddWithValue("@Position", PositionTextBox.Text);
                        command.Parameters.AddWithValue("@Salary", Convert.ToDecimal(SalaryTextBox.Text));
                        command.Parameters.AddWithValue("@HireDate", HireDatePicker.Value);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Staff record inserted successfully.");
                            MessageBox.Show("Staff record inserted successfully.");
                            Close();
                        }
                        else
                        {
                            Console.WriteLine("Failed to insert staff record.");
                            MessageBox.Show("Failed to insert staff record.");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputFields()
        {
            return
                   !string.IsNullOrWhiteSpace(staffFirstnameTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(staffLastnameTextBox.Text) &&
                   GenderComboBox.SelectedItem != null &&
                   BirthdatePicker.Value != default &&
                   !string.IsNullOrWhiteSpace(EmailTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(PhoneTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(AddressTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(DepartmentTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(PositionTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(SalaryTextBox.Text); // Adjust this validation based on your needs
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
