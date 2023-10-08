using AD_indiviual_project.Controller;
using AD_indiviual_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Medication : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private MedicationController medicationController;

        public int MedicationID { get; internal set; }
        public int PatientID { get; internal set; }
        public string MedicationName { get; internal set; }
        public string Dosage { get; internal set; }
        public string Frequency { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public string Notes { get; internal set; }
        public DateTime? EndDate { get; internal set; }
        public string Instructions { get; internal set; }
        public int PrescribingDoctorID { get; internal set; }

        public Medication()
        {
            InitializeComponent();
            medicationController = new MedicationController(connectionString);
            LoadMedicationRecords();
        }

        public void LoadMedicationRecords()
        {
            DataTable dataTable = medicationController.GetMedications();
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMedication addmedication = new AddMedication();
            addmedication.Show();
        }

        private void Medication_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    int MedicationId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["MedicationId"].Value);

                    if (medicationController.DeleteMedication(MedicationId))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMedicationRecords();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int MedicationId = Convert.ToInt32(selectedRow.Cells["MedicationId"].Value);

                UpdateMedication updateForm = new UpdateMedication(MedicationId);
                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadMedicationRecords();
                }
            }
            else
            {
                MessageBox.Show("Please select a single patient record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchTerm_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTerm.Text.Trim();

            DataTable dataTable = medicationController.SearchMedications(searchText);
            dataGridView1.DataSource = dataTable;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LoadMedicationRecords();
        }
    }
}
