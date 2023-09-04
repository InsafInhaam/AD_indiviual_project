using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddDoctors : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private DoctorRepository doctorRepository;
        private AvailabilityRepository availabilityRepository;

        public AddDoctors()
        {
            InitializeComponent();
            doctorRepository = new DoctorRepository(connectionString);
            availabilityRepository = new AvailabilityRepository(connectionString);
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

                int doctorID = doctorRepository.InsertDoctor(newDoctor);

                foreach (var day in newDoctor.Availability.Keys)
                {
                    Availability availability = new Availability
                    {
                        DoctorID = doctorID,
                        DayOfWeek = day,
                        IsAvailable = newDoctor.Availability[day]
                    };
                    availabilityRepository.InsertAvailability(availability);
                }

                MessageBox.Show("Doctor information and availability inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Doctor
        {
            public int YearsOfExperience { get; set; }
            public string PreviousHospitals { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }
            public string Address { get; set; }
            public string MedicalDegree { get; set; }
            public string Specialization { get; set; }
            public string MedicalLicenseNumber { get; set; }
            public string AvailableTime { get; set; }

            public Dictionary<string, bool> Availability { get; set; }
        }
 
        public class DoctorRepository
        {
            private string connectionString;

            public DoctorRepository(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public int InsertDoctor(Doctor doctor)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertDoctorQuery = "INSERT INTO Doctors (YearsOfExperience, PreviousHospitals, FirstName, LastName, Gender, DateOfBirth, PhoneNumber, EmailAddress, Address, MedicalDegree, Specialization, MedicalLicenseNumber, AvailableTime) " +
                        "VALUES (@YearsOfExperience, @PreviousHospitals, @FirstName, @LastName, @Gender, @DateOfBirth, @PhoneNumber, @EmailAddress, @Address, @MedicalDegree, @Specialization, @MedicalLicenseNumber, @AvailableTime); " +
                        "SELECT SCOPE_IDENTITY();";

                    SqlCommand doctorCommand = new SqlCommand(insertDoctorQuery, connection);
                    doctorCommand.Parameters.AddWithValue("@YearsOfExperience", doctor.YearsOfExperience);
                    doctorCommand.Parameters.AddWithValue("@PreviousHospitals", doctor.PreviousHospitals);
                    doctorCommand.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                    doctorCommand.Parameters.AddWithValue("@LastName", doctor.LastName);
                    doctorCommand.Parameters.AddWithValue("@Gender", doctor.Gender);
                    doctorCommand.Parameters.AddWithValue("@DateOfBirth", doctor.DateOfBirth);
                    doctorCommand.Parameters.AddWithValue("@PhoneNumber", doctor.PhoneNumber);
                    doctorCommand.Parameters.AddWithValue("@EmailAddress", doctor.EmailAddress);
                    doctorCommand.Parameters.AddWithValue("@Address", doctor.Address);
                    doctorCommand.Parameters.AddWithValue("@MedicalDegree", doctor.MedicalDegree);
                    doctorCommand.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    doctorCommand.Parameters.AddWithValue("@MedicalLicenseNumber", doctor.MedicalLicenseNumber);
                    doctorCommand.Parameters.AddWithValue("@AvailableTime", doctor.AvailableTime);

                    int insertedDoctorID = Convert.ToInt32(doctorCommand.ExecuteScalar());
                    return insertedDoctorID;
                }
            }
        }

        public class Availability
        {
            public int DoctorID { get; set; }
            public string DayOfWeek { get; set; }
            public bool IsAvailable { get; set; }
        }

        public class AvailabilityRepository
        {
            private string connectionString;

            public AvailabilityRepository(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public void InsertAvailability(Availability availability)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertAvailabilityQuery = "INSERT INTO Availability (DoctorID, DayOfWeek, IsAvailable) VALUES (@DoctorID, @DayOfWeek, @IsAvailable)";

                    SqlCommand availabilityCommand = new SqlCommand(insertAvailabilityQuery, connection);
                    availabilityCommand.Parameters.AddWithValue("@DoctorID", availability.DoctorID);
                    availabilityCommand.Parameters.AddWithValue("@DayOfWeek", availability.DayOfWeek);
                    availabilityCommand.Parameters.AddWithValue("@IsAvailable", availability.IsAvailable);

                    availabilityCommand.ExecuteNonQuery();
                }
            }
        }
    }        
}