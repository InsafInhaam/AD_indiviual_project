using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_indiviual_project.Controller
{
    public class ResourcesController
    {
        private string connectionString;

        public ResourcesController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetResources()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM HealthcareResources";

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

        public bool DeleteResource(int resourceId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM HealthcareResources WHERE resourceid = @ResourceId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ResourceId", resourceId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable SearchResources(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM HealthcareResources WHERE ResourceName LIKE @SearchText OR SerialNumber LIKE @SearchText";

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

        public bool AddHealthcareResource(string resourceName, string resourceType, string serialNumber, string manufacturer, string model, string status, string notes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
            INSERT INTO HealthcareResources (ResourceName, ResourceType, SerialNumber, Manufacturer, Model, Status, Notes, created_at)
            VALUES (@ResourceName, @ResourceType, @SerialNumber, @Manufacturer, @Model, @Status, @Notes, @created_at)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ResourceName", resourceName);
                        command.Parameters.AddWithValue("@ResourceType", resourceType);
                        command.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@Notes", notes);
                        command.Parameters.AddWithValue("@created_at", DateTime.Now);

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

        public bool UpdateHealthcareResource(int resourceId, string resourceName, string resourceType, string serialNumber, string manufacturer, string model, string status, string notes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @" UPDATE HealthcareResources SET ResourceName = @ResourceName, ResourceType = @ResourceType, SerialNumber = @SerialNumber, Manufacturer = @Manufacturer, Model = @Model, Status = @Status, Notes = @Notes WHERE ResourceID = @ResourceID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ResourceName", resourceName);
                        command.Parameters.AddWithValue("@ResourceType", resourceType);
                        command.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@Notes", notes);
                        command.Parameters.AddWithValue("@ResourceID", resourceId);

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
