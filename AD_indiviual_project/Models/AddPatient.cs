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
    public partial class AddPatient : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private PatientController patientManager;

        public AddPatient()
        {
            InitializeComponent();
            patientManager = new PatientController(connectionString);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                GenderComboBox.SelectedItem == null ||
                BirthdatePicker.Value == default ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(MedicalHistoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(AllergiesTextBox.Text) ||
                string.IsNullOrWhiteSpace(PrimaryDoctorTextBox.Text) ||
                string.IsNullOrWhiteSpace(InsuranceProviderTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    if (patientManager.AddPatient(FirstNameTextBox.Text, LastNameTextBox.Text, GenderComboBox.SelectedItem.ToString(), BirthdatePicker.Value, EmailTextBox.Text,
                        PhoneTextBox.Text, AddressTextBox.Text, MedicalHistoryTextBox.Text, AllergiesTextBox.Text,
                        PrimaryDoctorTextBox.Text, InsuranceProviderTextBox.Text))
                    {
                        MessageBox.Show("Patient Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while saving patient data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
