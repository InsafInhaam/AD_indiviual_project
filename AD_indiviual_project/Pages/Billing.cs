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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddBilling addbilling = new AddBilling();
            addbilling.Show();
        }

    }
}
