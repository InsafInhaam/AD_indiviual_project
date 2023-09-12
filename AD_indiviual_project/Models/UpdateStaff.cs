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
    public partial class UpdateStaff : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int staffId;
        private StaffController staffManager;

        public UpdateStaff(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
            // Load staff details using staffId
            LoadPatientDetails();
            staffManager = new StaffController(connectionString);
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {

        }

        private void LoadPatientDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM staffs WHERE staffid = @PatientId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", staffId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with staff details
                        staffFirstnameTextBox.Text = reader["first_name"].ToString();
                        staffLastnameTextBox.Text = reader["last_name"].ToString();
                        GenderComboBox.SelectedItem = reader["gender"].ToString();
                        BirthdatePicker.Value = Convert.ToDateTime(reader["birthdate"]);
                        EmailTextBox.Text = reader["email"].ToString();
                        PhoneTextBox.Text = reader["phone"].ToString();
                        AddressTextBox.Text = reader["address"].ToString();
                        DepartmentTextBox.Text = reader["department"].ToString();
                        PositionTextBox.Text = reader["position"].ToString();
                        SalaryTextBox.Text = reader["salary"].ToString();
                        HireDatePicker.Value = Convert.ToDateTime(reader["hire_date"]);

                    }
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    // Call the UpdatePatient method to update the staff record 
                    if (staffManager.UpdateStaff(staffId, staffFirstnameTextBox.Text, staffLastnameTextBox.Text, GenderComboBox.SelectedItem.ToString(),
                        BirthdatePicker.Value, EmailTextBox.Text, PhoneTextBox.Text, AddressTextBox.Text,
                        DepartmentTextBox.Text, PositionTextBox.Text, Convert.ToDecimal(SalaryTextBox.Text), HireDatePicker.Value))
                    {
                        MessageBox.Show("Staff Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update staff record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating staff record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
