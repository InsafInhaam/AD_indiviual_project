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
                Console.WriteLine("An error occurred while fetching patients: " + ex.Message);
                return null;
            }
        }

        public DataTable GetBillingData(string billingType, int selectedPatientID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = string.Empty;

                switch (billingType)
                {
                    case "Procedure":
                        query = "SELECT ProcedureID, ProceduresType FROM Procedures WHERE PatientID = @PatientID";
                        break;
                    case "Medication":
                        query = "SELECT MedicationId, MedicationName FROM Medications WHERE PatientID = @PatientID";
                        break;
                    case "Appointments":
                        query = "SELECT AppointmentID, Description FROM Appointments WHERE PatientID = @PatientID";
                        break;
                    default:
                        break;
                }

                if (!string.IsNullOrEmpty(query))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", selectedPatientID);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetBillings()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Billings";

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

        public bool DeleteBilling(int billingid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Billings WHERE billingid = @BillingId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@BillingId", billingid);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable SearchBillings(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Billing WHERE PatientID LIKE @SearchText OR ConsultationID LIKE @SearchText OR MedicationID LIKE @SearchText";
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

        public DataTable GetBillingDetails(int billingId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Billings WHERE BillingID = @BillingID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillingID", billingId);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching billing details: " + ex.Message);
                return null;
            }
        }


    }
}
