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

        public Medication()
        {
            InitializeComponent();
            medicationController = new MedicationController(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMedication addmedication = new AddMedication();
            addmedication.Show();
        }
    }
}
