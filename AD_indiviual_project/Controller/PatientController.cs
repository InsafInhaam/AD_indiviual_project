using System;
using System.Data.SqlClient;
using System.Data;
using AD_indiviual_project.Pages;

namespace AD_indiviual_project.Controller
{
    public class PatientController
    {
        private string connectionString;

        public PatientController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetPatients()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM patients";

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

        public bool DeletePatient(int patientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string deleteAppointmentsQuery = "DELETE FROM Appointments WHERE PatientID = @PatientId";
                        using (SqlCommand appointmentsCommand = new SqlCommand(deleteAppointmentsQuery, connection, transaction))
                        {
                            appointmentsCommand.Parameters.AddWithValue("@PatientId", patientId);
                            appointmentsCommand.ExecuteNonQuery();
                        }

                        // Delete records from Billings table
                        string deleteBillingsQuery = "DELETE FROM Billings WHERE PatientID = @PatientId";
                        using (SqlCommand billingsCommand = new SqlCommand(deleteBillingsQuery, connection, transaction))
                        {
                            billingsCommand.Parameters.AddWithValue("@PatientId", patientId);
                            billingsCommand.ExecuteNonQuery();
                        }

                        //Delete records from Medications table
                        string deleteMedicationsQuery = "DELETE FROM Medications WHERE PatientId = @PatientId";
                        using (SqlCommand medicationsCommand = new SqlCommand(deleteMedicationsQuery, connection, transaction))
                        {
                            medicationsCommand.Parameters.AddWithValue("@PatientId", patientId);
                            medicationsCommand.ExecuteNonQuery();
                        }

                        //  Delete records from Procedures table
                        string deleteProceduresQuery = "DELETE FROM Procedures WHERE PatientID = @PatientId";
                        using (SqlCommand proceduresCommand = new SqlCommand(deleteProceduresQuery, connection, transaction))
                        {
                            proceduresCommand.Parameters.AddWithValue("@PatientId", patientId);
                            proceduresCommand.ExecuteNonQuery();
                        }

                        //  Delete records from RoomBookings table
                        string deleteRoomBookingsQuery = "DELETE FROM RoomBookings WHERE patient_id = @PatientId";
                        using (SqlCommand roomBookingsCommand = new SqlCommand(deleteRoomBookingsQuery, connection, transaction))
                        {
                            roomBookingsCommand.Parameters.AddWithValue("@PatientId", patientId);
                            roomBookingsCommand.ExecuteNonQuery();
                        }

                        // Now delete the patient record
                        string deletePatientQuery = "DELETE FROM patients WHERE patientid = @PatientId";
                        using (SqlCommand patientCommand = new SqlCommand(deletePatientQuery, connection, transaction))
                        {
                            patientCommand.Parameters.AddWithValue("@PatientId", patientId);
                            int rowsAffected = patientCommand.ExecuteNonQuery();

                            // Commit the transaction if successful
                            if (rowsAffected > 0)
                            {
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
                                // Rollback the transaction if patient deletion fails
                                transaction.Rollback();
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while deleting the patient: " + ex.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public DataTable SearchPatients(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM patients WHERE first_name LIKE @SearchText OR gender LIKE @SearchText";

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

        public bool AddPatient(string firstname, string lastname, string gender, DateTime dob, string email, string phone, string address, string medicalhistory, string allergies, string primarydoctor, string insuranceprovider)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                    INSERT INTO patients (first_name, last_name, gender, birthdate, email, phone, address, medical_history, allergies, primary_doctor, insurance_provider)
                    VALUES (@FirstName, @LastName, @Gender, @Birthdate, @Email, @Phone, @Address, @MedicalHistory, @Allergies, @PrimaryDoctor, @InsuranceProvider)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstname);
                        command.Parameters.AddWithValue("@LastName", lastname);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Birthdate", dob);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@MedicalHistory", medicalhistory);
                        command.Parameters.AddWithValue("@Allergies", allergies);
                        command.Parameters.AddWithValue("@PrimaryDoctor", primarydoctor);
                        command.Parameters.AddWithValue("@InsuranceProvider", insuranceprovider);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false; // Handle the error as needed
            }
        }

        public bool UpdatePatient(int patientId, string firstname, string lastname, string gender, DateTime dob, string email, string phone, string address, string medicalhistory, string allergies, string primarydoctor, string insuranceprovider)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @" UPDATE patients SET first_name = @FirstName, last_name = @LastName, gender = @Gender, birthdate = @Birthdate, email = @Email, phone = @Phone, address = @Address, medical_history = @MedicalHistory, allergies = @Allergies, primary_doctor = @PrimaryDoctor, insurance_provider = @InsuranceProvider WHERE patientid = @PatientId";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstname);
                        command.Parameters.AddWithValue("@LastName", lastname);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Birthdate", dob);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@MedicalHistory", medicalhistory);
                        command.Parameters.AddWithValue("@Allergies", allergies);
                        command.Parameters.AddWithValue("@PrimaryDoctor", primarydoctor);
                        command.Parameters.AddWithValue("@InsuranceProvider", insuranceprovider);

                        command.Parameters.AddWithValue("@PatientId", patientId);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

    }
}
