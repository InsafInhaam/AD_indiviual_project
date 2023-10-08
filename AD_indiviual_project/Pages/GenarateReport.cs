using AD_indiviual_project.Controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;

namespace AD_indiviual_project.Pages
{
    public partial class GenarateReport : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private GenarateReportController genarateReportManager;

        public GenarateReport()
        {
            InitializeComponent();
            genarateReportManager = new GenarateReportController(connectionString);
            comboBox1.Items.AddRange(new object[] { "patients", "staffs", "Doctors", "Billings", "Availability", "Appointments", "HealthcareResources", "users", "RoomTheaterAvailability", "RoomBookings", "Procedures", "Medications" });
        }

        private bool ValidateInputFieldsForReportGeneration()
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show("Invalid date range. Please select a valid date range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFieldsForReportGeneration())
            {
                return;
            }

            string selectedTable = comboBox1.SelectedItem.ToString();
            DateTime fromDate = dateTimePickerFrom.Value;
            DateTime toDate = dateTimePickerTo.Value;

            string query = $"SELECT * FROM {selectedTable} WHERE created_at >=  '{fromDate:yyyy-MM-dd}' AND created_at < '{toDate:yyyy-MM-dd}'";

            Console.WriteLine("SQL Query: " + query);

            DataTable dataTable = ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;


        }

        private DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);

                    // Adding headers
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    // Adding data
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    MExcel.Columns.AutoFit();
                    MExcel.Rows.AutoFit();
                    MExcel.Columns.Font.Size = 12;
                    MExcel.Visible = true;
                }
                else
                {
                    MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
