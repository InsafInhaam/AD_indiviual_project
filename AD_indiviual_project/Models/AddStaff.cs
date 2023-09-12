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
    public partial class AddStaff : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private StaffController staffManager;

        public AddStaff()
        {
            InitializeComponent();
            staffManager = new StaffController(connectionString);
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
                try
                {
                    if (staffManager.AddStaff(staffFirstnameTextBox.Text, staffLastnameTextBox.Text, GenderComboBox.SelectedItem.ToString(),
                        BirthdatePicker.Value, EmailTextBox.Text, PhoneTextBox.Text, AddressTextBox.Text,
                        DepartmentTextBox.Text, PositionTextBox.Text, Convert.ToDecimal(SalaryTextBox.Text), HireDatePicker.Value))
                    {
                        MessageBox.Show("Staff Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while saving staff data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(staffFirstnameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(staffLastnameTextBox.Text) ||
                    GenderComboBox.SelectedItem == null ||
                    BirthdatePicker.Value == default ||
                    string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                    string.IsNullOrWhiteSpace(PhoneTextBox.Text) ||
                    string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                    string.IsNullOrWhiteSpace(DepartmentTextBox.Text) ||
                    string.IsNullOrWhiteSpace(PositionTextBox.Text) ||
                    string.IsNullOrWhiteSpace(SalaryTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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
