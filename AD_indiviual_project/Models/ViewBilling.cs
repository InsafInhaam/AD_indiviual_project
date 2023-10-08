using AD_indiviual_project.Controller;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class ViewBilling : Form
    {
        private string connectionString = Properties.Settings.Default.db_string;
        private int billingId;
        private BillingController billingController;

        public ViewBilling(int billingId)
        {
            InitializeComponent();
            this.billingId = billingId;
            billingController = new BillingController(connectionString);
            LoadBillingDetails();
        }


        private void LoadBillingDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Billings WHERE billingid = @BillingId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BillingId", billingId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the form controls with billing details
                        cmbBillingType.Text = reader["BillingType"].ToString();
                        txtPatientID.Text = reader["PatientID"].ToString();
                        billingTypeId.Text = reader["BillingID"].ToString();
                        billingTypeId.Text = reader["MedicationID"].ToString();
                        billingTypeId.Text = reader["ConsultationID"].ToString();
                        dtpBillingDate.Text = reader["BillingDate"].ToString();
                        txtAmount.Text = reader["Amount"].ToString();
                        cmbPaymentStatus.Text = reader["PaymentStatus"].ToString();
                        txtPaymentDate.Text = reader["PaymentDate"].ToString();
                        txtNotes.Text = reader["Notes"].ToString();
                    }
                }
            }
        }

        private void Print_Invoice_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(billPrintDocument_PrintPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void billPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string currentDateAndTime = DateTime.Now.ToString("dd-MM-yyyy, HH:mm:ss");
            e.Graphics.DrawString("Invoice ID: #" + billingId, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(45, 220));
            e.Graphics.DrawString("Date: " + currentDateAndTime, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(580, 220));
            e.Graphics.DrawString("Patient ID: " + txtPatientID.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(45, 300));

            int verticalPosition = 420; // Initial vertical position
            int lineHeight = 30; // The height of each line
            int rightAlignmentPosition = 600; // The rightmost position where you want to draw the amounts.

            DrawStringAndMoveDown(ref verticalPosition, $"Billing Type:", cmbBillingType.Text, e.Graphics, lineHeight, rightAlignmentPosition);
            DrawStringAndMoveDown(ref verticalPosition, $"Appointment/Medication/ Procedure:", billingTypeId.Text, e.Graphics, lineHeight, rightAlignmentPosition);
            DrawStringAndMoveDown(ref verticalPosition, $"Billing Date:", dtpBillingDate.Text, e.Graphics, lineHeight, rightAlignmentPosition);
            DrawStringAndMoveDown(ref verticalPosition, $"Total Amount:", txtAmount.Text, e.Graphics, lineHeight, rightAlignmentPosition);
            DrawStringAndMoveDown(ref verticalPosition, $"Payment Status:", cmbPaymentStatus.Text, e.Graphics, lineHeight, rightAlignmentPosition);
            DrawStringAndMoveDown(ref verticalPosition, $"Payment Date:", txtPaymentDate.Text, e.Graphics, lineHeight, rightAlignmentPosition);
            DrawStringAndMoveDown(ref verticalPosition, $"Notes:", txtNotes.Text, e.Graphics, lineHeight, rightAlignmentPosition);

            e.Graphics.DrawString("                                  -------------", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(340, verticalPosition));

            // For total amount, align it similarly to other amounts
            string totalAmountStr = txtAmount.Text;
            SizeF totalAmountSize = e.Graphics.MeasureString(totalAmountStr, new Font("Arial", 13, FontStyle.Regular));
            e.Graphics.DrawString("Total Amount:", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(45, verticalPosition + lineHeight));
            e.Graphics.DrawString(totalAmountStr, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(rightAlignmentPosition - (int)totalAmountSize.Width, verticalPosition + lineHeight));
            e.Graphics.DrawString("                                  -------------", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(340, verticalPosition + 2 * lineHeight));
        }

        private void DrawStringAndMoveDown(ref int verticalPosition, string text, string amount, Graphics graphics, int lineHeight, int rightAlignmentPosition)
        {
            Font font = new Font("Arial", 13, FontStyle.Regular);
            graphics.DrawString(text, font, Brushes.Black, new Point(45, verticalPosition));

            // Calculate the size of the string amount to be drawn
            SizeF amountSize = graphics.MeasureString(amount, font);

            // Calculate the position to draw the amount such that it is right-aligned
            int amountPosition = rightAlignmentPosition - (int)amountSize.Width;

            graphics.DrawString(amount, font, Brushes.Black, new Point(amountPosition, verticalPosition));
            verticalPosition += lineHeight; // Move down the vertical position
        }

    }
}
