using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Controller
{
    public class DashboardController
    {
        private string connectionString;

        public DashboardController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //  Get Staff's Total Save Count Display Method
        public int GetStaffTotalCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM staffs";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int staffCount = (int)command.ExecuteScalar();
                        return staffCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching staff count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }




        // Get Doctor's Total Save Count Display Method
        public int GetDoctorsTotalCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Doctors";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int doctorCount = (int)command.ExecuteScalar();
                        return doctorCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching doctors count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; 
            }

        }

        // Get Patient's Total Save Count Display Method
        public int GetPatientsCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM patients";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int patientsCount = (int)command.ExecuteScalar();
                        return patientsCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching patients count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; 
            }
        }

        public int GetResourceTotalCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM HealthcareResources";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int resourceCount = (int)command.ExecuteScalar();
                        return resourceCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching resource count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; 
            }
        }

        public int GetAppointmentTotalCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Appointments";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int appointmentCount = (int)command.ExecuteScalar();
                        return appointmentCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching resource count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; 
            }
        }

        public int GetRoomsTotalCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM RoomTheaterAvailability";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int roomsCount = (int)command.ExecuteScalar();
                        return roomsCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching resource count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}