using AD_indiviual_project.Controller;
using AD_indiviual_project.Pages;
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
    public partial class UpdateAppointment : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int appointmentId;
        private AppointmentController appointmentController;

        public UpdateAppointment(int appointmentId)
        {
            InitializeComponent();
            this.appointmentId = appointmentId;
            appointmentController = new AppointmentController(connectionString);
        }

        private void UpdateAppointment_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateInputFields()
        {
            // Validate input fields for the appointment
            if (txtPatientId.SelectedValue == null ||
                doctorComboBox.SelectedValue == null ||
                doctorAppointmentTime.SelectedItem == null ||
                yourDateTimePicker.Value == null || // Replace with your DateTimePicker control
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all required fields for the appointment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // You can add more validation logic as needed

            return true;
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                try
                {
                    int patientId = (int)txtPatientId.SelectedValue;
                    int doctorId = (int)doctorComboBox.SelectedValue;
                    DateTime appointmentDate = yourDateTimePicker.Value;
                    string appointmentTime = doctorAppointmentTime.SelectedItem.ToString();
                    string description = txtDescription.Text;

                    if (appointmentController.UpdateAppointment(appointmentId, patientId, doctorId, appointmentDate, appointmentTime, description))
                    {
                        MessageBox.Show("Appointment Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update appointment record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating appointment record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
