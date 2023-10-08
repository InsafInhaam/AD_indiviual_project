using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_indiviual_project.Controller
{
    public class GenarateReportController
    {
        private string connectionString;

        public GenarateReportController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetGenarateReport(string query)
        {
            try
            {
                // Assuming you have a database connection
                using (SqlConnection connection = new SqlConnection("YourConnectionString"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }
    }
}
