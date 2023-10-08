using System;
using System.Data.SqlClient;
using System.Data;

namespace AD_indiviual_project.Controller
{
    public class AppointmentController
    {
        private string connectionString;

        public AppointmentController(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
        public DataTable GetDoctors(string specialization)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectDoctorsQuery = "SELECT DoctorID, FirstName, LastName FROM Doctors WHERE Specialization = @Specialization";

                    using (SqlCommand command = new SqlCommand(selectDoctorsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Specialization", specialization);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching doctors: " + ex.Message);
                return null;
            }
        }

        public DataTable GetPatients()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT patientid, first_name, last_name FROM patients";

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
                Console.WriteLine("An error occurred while fetching patients: " + ex.Message);
                return null;
            }
        }

        public DataTable GetAppointmentTimes(int doctorID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectDoctorAvailabilityQuery = "SELECT AvailableTime FROM Doctors WHERE DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(selectDoctorAvailabilityQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", doctorID);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching appointment times: " + ex.Message);
                return null;
            }
        }

        public DataTable GetAppointments()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Appointments";

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

        public DataTable SearchAppointments(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Appointments WHERE AppointmentName LIKE @SearchText OR PatientId LIKE @SearchText";

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

        public bool DeleteAppointment(int appointmentId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the appointment: " + ex.Message);
                return false;
            }
        }


        public bool AddAppointment(int patientID, int doctorID, DateTime appointmentDate, string appointmentTime, string description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertAppointmentQuery = "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, Description) " +
                                           "VALUES (@PatientID, @DoctorID, @AppointmentDate, @AppointmentTime, @Description)";

                    using (SqlCommand command = new SqlCommand(insertAppointmentQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientID);
                        command.Parameters.AddWithValue("@DoctorID", doctorID);
                        command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                        command.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
                        command.Parameters.AddWithValue("@Description", description);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding the appointment: " + ex.Message);
                return false;
            }
        }

        public bool UpdateAppointment(int appointmentId, int patientId, int doctorId, DateTime appointmentDate, string appointmentTime, string description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @"
                UPDATE Appointments
                SET PatientID = @PatientID,
                    DoctorID = @DoctorID,
                    AppointmentDate = @AppointmentDate,
                    AppointmentTime = @AppointmentTime,
                    Description = @Description
                WHERE AppointmentID = @AppointmentID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientId);
                        command.Parameters.AddWithValue("@DoctorID", doctorId);
                        command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                        command.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@AppointmentID", appointmentId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the appointment: " + ex.Message);
                return false;
            }
        }
    }
}
