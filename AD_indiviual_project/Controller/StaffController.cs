using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_indiviual_project.Controller
{
    public class StaffController
    {
        private string connectionString;

        public StaffController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetStaffs()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM staffs";

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

        public bool DeleteStaff(int staffId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM staffs WHERE staffid = @StaffId";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@StaffId", staffId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable SearchStaffs(string searchText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM staffs WHERE first_name LIKE @SearchText OR gender LIKE @SearchText";

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
        public bool AddStaff(string firstName, string lastName, string gender, DateTime birthdate, string email, string phone,
       string address, string department, string position, decimal salary, DateTime hireDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                    INSERT INTO staffs (first_name, last_name, gender, birthdate, email, phone, address, department, position, salary, hire_date)
                    VALUES (@FirstName, @LastName, @Gender, @Birthdate, @Email, @Phone, @Address, @Department, @Position, @Salary, @HireDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Birthdate", birthdate);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Department", department);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@HireDate", hireDate);

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

        public bool UpdateStaff(int staffId, string firstName, string lastName, string gender, DateTime birthdate, string email, string phone,
       string address, string department, string position, decimal salary, DateTime hireDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @"
                        UPDATE staffs
                        SET
                            first_name = @FirstName,
                            last_name = @LastName,
                            gender = @Gender,
                            birthdate = @Birthdate,
                            email = @Email,
                            phone = @Phone,
                            address = @Address,
                            department = @Department,
                            position = @Position,
                            salary = @Salary,
                            hire_date = @HireDate
                        WHERE staffid = @StaffId";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Birthdate", birthdate);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Department", department);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@HireDate", hireDate);

                        command.Parameters.AddWithValue("@StaffId", staffId);

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
