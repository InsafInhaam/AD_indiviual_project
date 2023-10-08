using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Billing : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private BillingController billingController;
        public Billing()
        {
            InitializeComponent();
            billingController = new BillingController(connectionString);
            LoadBillingRecords();
        }

        public string BillingType { get; internal set; }
        public int PatientID { get; internal set; }
        public int? ProcedureID { get; internal set; }
        public string Notes { get; internal set; }
        public int? MedicationID { get; internal set; }
        public int? ConsultationID { get; internal set; }
        public DateTime BillingDate { get; internal set; }
        public string PaymentStatus { get; internal set; }
        public decimal Amount { get; internal set; }
        public DateTime? PaymentDate { get; internal set; }
        public object PdfToImageConverter { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBilling addbilling = new AddBilling();
            addbilling.Show();
        }

        public void LoadBillingRecords()
        {
            DataTable dataTable = billingController.GetBillings();
            dataGridView1.DataSource = dataTable;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadBillingRecords();
        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = billingController.SearchBillings(searchText);
            dataGridView1.DataSource = dataTable;
        }

        private void print_invoice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract the patient ID from the selected row
                int billingId = Convert.ToInt32(selectedRow.Cells["BillingID"].Value);

                // Create a new instance of the ViewProcedures form
                ViewBilling viewForm = new ViewBilling(billingId);
                DialogResult result = viewForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the patient records after the update
                    LoadBillingRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single patient record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
