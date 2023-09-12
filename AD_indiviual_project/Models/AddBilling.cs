using AD_indiviual_project.Controller;
using AD_indiviual_project.Pages;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddBilling : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private BillingController billingController;

        public AddBilling()
        {
            InitializeComponent();
            billingController = new BillingController(connectionString);
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Populate Billing Type ComboBox
            cmbBillingType.Items.Add("Procedure");
            cmbBillingType.Items.Add("Medication");
            cmbBillingType.Items.Add("Consultation");
            // Add more billing types as needed

            // Populate Payment Status ComboBox
            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.Items.Add("Paid");
            cmbPaymentStatus.Items.Add("Overdue");
            // Add more payment statuses as needed
        }

        private void LoadPatientNames()
        {
            DataTable patientsTable = billingController.GetPatients();
            if (patientsTable != null)
            {
                txtPatientID.DataSource = patientsTable;
                txtPatientID.DisplayMember = "first_name"; // Display the first name in the control
                txtPatientID.ValueMember = "patientid";   // Save the PatientID as the selected value
            }
        }

        private void AddBilling_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing
            {
                BillingType = cmbBillingType.SelectedItem.ToString(),
                PatientID = Convert.ToInt32(txtPatientID.Text),
                ProcedureID = string.IsNullOrEmpty(billingTypeId.Text) ? (int?)null : Convert.ToInt32(billingTypeId.Text),
                MedicationID = string.IsNullOrEmpty(billingTypeId.Text) ? (int?)null : Convert.ToInt32(billingTypeId.Text),
                ConsultationID = string.IsNullOrEmpty(billingTypeId.Text) ? (int?)null : Convert.ToInt32(billingTypeId.Text),
                BillingDate = dtpBillingDate.Value,
                Amount = decimal.Parse(txtAmount.Text),
                PaymentStatus = cmbPaymentStatus.SelectedItem.ToString(),
                PaymentDate = string.IsNullOrEmpty(txtPaymentDate.Text) ? (DateTime?)null : DateTime.Parse(txtPaymentDate.Text),
                Notes = txtNotes.Text
            };

            if (billingController.CreateBilling(billing))
            {
                MessageBox.Show("Billing record created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to create billing record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmbBillingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the selection change event.
            string selectedBillingType = cmbBillingType.SelectedItem.ToString();

            // Fetch data from the database based on the selected billing type.
            DataTable billingData = billingController.GetBillingData(selectedBillingType);

            // Display the fetched data in the dgvBillingData DataGridView.
            //dgvBillingData.DataSource = billingData;
            if (billingData != null)
            {
                switch (selectedBillingType)
                {
                    case "Procedure":
                        billingTypeId.DataSource = billingData;
                        billingTypeId.DisplayMember = "ProcedureName";
                        billingTypeId.ValueMember = "ProcedureId";
                        break;
                    case "Medication":
                        billingTypeId.DataSource = billingData;
                        billingTypeId.DisplayMember = "MedicationName";
                        billingTypeId.ValueMember = "MedicationId";
                        break;
                    case "Consultation":
                        billingTypeId.DataSource = billingData;
                        billingTypeId.DisplayMember = "ConsultationName";
                        billingTypeId.ValueMember = "ConsultationId";
                        break;
                    default:
                        // Handle invalid billing types.
                        break;
                }
            }
        }
    }
}
