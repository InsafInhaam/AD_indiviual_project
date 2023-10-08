using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_indiviual_project.Controller
{
    public class DoctorController
    {
        private string connectionString;

        public DoctorController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetDoctors()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Doctors";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }

        public bool DeleteDoctor(int doctorId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Manually delete related records in Availability table
                string deleteAvailabilityQuery = "DELETE FROM Availability WHERE DoctorID = @DoctorId";

                using (SqlCommand availabilityCommand = new SqlCommand(deleteAvailabilityQuery, connection))
                {
                    availabilityCommand.Parameters.AddWithValue("@DoctorId", doctorId);
                    availabilityCommand.ExecuteNonQuery();
                }

                // Now you can delete the doctor
                string deleteDoctorQuery = "DELETE FROM Doctors WHERE DoctorID = @DoctorId";

                using (SqlCommand command = new SqlCommand(deleteDoctorQuery, connection))
                {
                    command.Parameters.AddWithValue("@DoctorId", doctorId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable SearchDoctors(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Doctors WHERE FirstName LIKE @SearchText OR LastName LIKE @SearchText";
                    // You can modify the query to include additional search fields

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
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

        // Add the following method to insert availability
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

        // Add this method to your DoctorController class
        public bool UpdateDoctor(Doctor doctor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateDoctorQuery = @"
                UPDATE Doctors
                SET YearsOfExperience = @YearsOfExperience,
                    PreviousHospitals = @PreviousHospitals,
                    FirstName = @FirstName,
                    LastName = @LastName,
                    Gender = @Gender,
                    DateOfBirth = @DateOfBirth,
                    PhoneNumber = @PhoneNumber,
                    EmailAddress = @EmailAddress,
                    Address = @Address,
                    MedicalDegree = @MedicalDegree,
                    Specialization = @Specialization,
                    MedicalLicenseNumber = @MedicalLicenseNumber,
                    AvailableTime = @AvailableTime
                WHERE DoctorID = @DoctorID";

                    SqlCommand doctorCommand = new SqlCommand(updateDoctorQuery, connection);
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
                    doctorCommand.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);

                    int rowsAffected = doctorCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }
    }

    public class Doctor
    {
        public int DoctorID { get; set; }

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

    public class Availability
    {
        public int DoctorID { get; set; }
        public string DayOfWeek { get; set; }
        public bool IsAvailable { get; set; }
    }
}
