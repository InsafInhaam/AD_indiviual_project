using AD_indiviual_project.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_indiviual_project.Controller
{
    public class MedicationController
    {
        private string connectionString;

        public MedicationController(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public bool InsertMedicationRecord(
                int patientId,
                string medicationName,
                string dosage,
                string frequency,
                DateTime startDate,
                DateTime? endDate,
                string instructions,
                int prescribingDoctorId,
                string notes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                            INSERT INTO Medications (
                                PatientId,
                                MedicationName,
                                Dosage,
                                Frequency,
                                StartDate,
                                EndDate,
                                Instructions,
                                PrescribingDoctorId,
                                Notes
                            )
                            VALUES (
                                @PatientId,
                                @MedicationName,
                                @Dosage,
                                @Frequency,
                                @StartDate,
                                @EndDate,
                                @Instructions,
                                @PrescribingDoctorId,
                                @Notes
                            )";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientId", patientId);
                        command.Parameters.AddWithValue("@MedicationName", medicationName);
                        command.Parameters.AddWithValue("@Dosage", dosage);
                        command.Parameters.AddWithValue("@Frequency", frequency);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Instructions", instructions);
                        command.Parameters.AddWithValue("@PrescribingDoctorId", prescribingDoctorId);
                        command.Parameters.AddWithValue("@Notes", notes);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log or display an error message).
                Console.WriteLine("Error inserting medication record: " + ex.Message);
                return false;
            }
        }

        public DataTable GetMedications()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Medications";

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

        public DataTable SearchMedications(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Medications WHERE MedicationName LIKE @SearchText OR PatientId LIKE @SearchText";
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

        public bool UpdateMedication(Medication medication)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @"
                        UPDATE Medications
                        SET PatientID = @PatientID, MedicationName = @MedicationName, Dosage = @Dosage,
                            Frequency = @Frequency, StartDate = @StartDate, EndDate = @EndDate,
                            Instructions = @Instructions, PrescribingDoctorID = @PrescribingDoctorID, Notes = @Notes
                        WHERE MedicationID = @MedicationID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MedicationID", medication.MedicationID);
                        command.Parameters.AddWithValue("@PatientID", medication.PatientID);
                        command.Parameters.AddWithValue("@MedicationName", medication.MedicationName);
                        command.Parameters.AddWithValue("@Dosage", medication.Dosage);
                        command.Parameters.AddWithValue("@Frequency", medication.Frequency);
                        command.Parameters.AddWithValue("@StartDate", medication.StartDate);
                        command.Parameters.AddWithValue("@EndDate", (object)medication.EndDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Instructions", medication.Instructions);
                        command.Parameters.AddWithValue("@PrescribingDoctorID", medication.PrescribingDoctorID);
                        command.Parameters.AddWithValue("@Notes", medication.Notes);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating medication record: {ex.Message}");
                return false;
            }
        }

        public bool DeleteMedication(int medicationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Medications WHERE MedicationID = @MedicationID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MedicationID", medicationID);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting medication record: {ex.Message}");
                return false;
            }
        }

        public DataTable GetDoctors()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectDoctorsQuery = "SELECT DoctorID, FirstName, LastName FROM Doctors";

                    using (SqlCommand command = new SqlCommand(selectDoctorsQuery, connection))
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
                // Handle the exception (e.g., log or display an error message).
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
                // Handle the exception (e.g., log or display an error message).
                Console.WriteLine("An error occurred while fetching patients: " + ex.Message);
                return null;
            }
        }
    }
}
