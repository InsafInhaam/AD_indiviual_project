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
    public class BillingController
    {
        private string connectionString;

        public BillingController(string dbConnectionString)
        {
            connectionString = dbConnectionString;
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

        public DataTable GetBillingData(string billingType)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = string.Empty;

                // Determine the SQL query based on the selected billing type.
                switch (billingType)
                {
                    case "Procedure":
                        query = "SELECT ProcedureName FROM ProceduresTable"; // Replace with your actual table and column names.
                        break;
                    case "Medication":
                        query = "SELECT MedicationId, MedicationName FROM Medications"; // Replace with your actual table and column names.
                        break;
                    case "Consultation":
                        query = "SELECT ConsultationName FROM Appointments"; // Replace with your actual table and column names.
                        break;
                    default:
                        // Handle invalid billing types.
                        break;
                }

                if (!string.IsNullOrEmpty(query))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public bool CreateBilling(Billing billing)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                    INSERT INTO Billings (BillingType, PatientID, ProcedureID, MedicationID, ConsultationID, BillingDate, Amount, PaymentStatus, PaymentDate, Notes)
                    VALUES (@BillingType, @PatientID, @ProcedureID, @MedicationID, @ConsultationID, @BillingDate, @Amount, @PaymentStatus, @PaymentDate, @Notes);";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BillingType", billing.BillingType);
                        command.Parameters.AddWithValue("@PatientID", billing.PatientID);
                        command.Parameters.AddWithValue("@ProcedureID", billing.ProcedureID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MedicationID", billing.MedicationID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ConsultationID", billing.ConsultationID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@BillingDate", billing.BillingDate);
                        command.Parameters.AddWithValue("@Amount", billing.Amount);
                        command.Parameters.AddWithValue("@PaymentStatus", billing.PaymentStatus);
                        command.Parameters.AddWithValue("@PaymentDate", billing.PaymentDate ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Notes", billing.Notes);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating billing record: " + ex.Message);
                return false;
            }
        }

    }
}
