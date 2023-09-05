using System;
using System.Collections.Generic;
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
                            INSERT INTO Medication (
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
    
    }
}
