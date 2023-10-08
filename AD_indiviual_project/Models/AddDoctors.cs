using AD_indiviual_project.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddDoctors : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private DoctorController doctorManager;

        public AddDoctors()
        {
            InitializeComponent();
            doctorManager = new DoctorController(connectionString);
        }

        private void AddDoctors_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor newDoctor = new Doctor
                {
                    YearsOfExperience = int.Parse(yearsOfExperienceTextBox.Text),
                    PreviousHospitals = previousHospitalsTextBox.Text,
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Gender = genderComboBox.SelectedItem.ToString(),
                    DateOfBirth = dateOfBirthPicker.Value,
                    PhoneNumber = phoneNumberTextBox.Text,
                    EmailAddress = emailAddressTextBox.Text,
                    Address = addressTextBox.Text,
                    MedicalDegree = degreeTextBox.Text,
                    Specialization = specializationTextBox.SelectedItem.ToString(),
                    MedicalLicenseNumber = licenseTextBox.Text,
                    AvailableTime = availableTimeTextBox.Text,

                    Availability = new Dictionary<string, bool>
                    {
                        { "Mon", chkMon.Checked },
                        { "Tue", chkTue.Checked },
                        { "Wed", chkWed.Checked },
                        { "Thu", chkThu.Checked },
                        { "Fri", chkFri.Checked },
                        { "Sat", chkSat.Checked },
                        { "Sun", chkSun.Checked }
                    }
                };

                int doctorID = doctorManager.InsertDoctor(newDoctor);

                foreach (var day in newDoctor.Availability.Keys)
                {
                    Availability availability = new Availability
                    {
                        DoctorID = doctorID,
                        DayOfWeek = day,
                        IsAvailable = newDoctor.Availability[day]
                    };
                    doctorManager.InsertAvailability(availability);
                }

                MessageBox.Show("Doctor information and availability inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }        
}