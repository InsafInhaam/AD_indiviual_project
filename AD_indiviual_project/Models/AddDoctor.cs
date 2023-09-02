using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Models
{
    public partial class AddDoctor : Form
    {
        private string connectionString = (Properties.Settings.Default.db_string);
        private int fieldCounter = 0; // To track the number of fields

        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddNewInputField();
        }

        private void AddNewInputField()
        {
            // Create a new container for each set of inputs (GunaComboBox, Start Time, End Time)
            GroupBox inputGroupBox = new GroupBox();
            inputGroupBox.Name = "inputGroupBox" + fieldCounter;
            inputGroupBox.Width = 600;
            inputGroupBox.Height = 100; // Adjust the height as needed
            inputGroupBox.Top = fieldCounter * 110 + 10; // Adjust the vertical spacing
            inputGroupBox.Left = 10;

            // Create a GunaComboBox
            Guna2ComboBox gunaComboBox = new Guna2ComboBox();
            gunaComboBox.Name = "gunaComboBox" + fieldCounter;
            gunaComboBox.Items.AddRange(new string[] { "Option 1", "Option 2" });
            gunaComboBox.Width = 150;
            gunaComboBox.Location = new Point(10, 30); // Horizontal position

            // Create Start Time input (DateTimePicker)
            DateTimePicker startTimePicker = new DateTimePicker();
            startTimePicker.Name = "startTimePicker" + fieldCounter;
            startTimePicker.Format = DateTimePickerFormat.Time;
            startTimePicker.Width = 150;
            startTimePicker.Location = new Point(gunaComboBox.Right + 10, 30); // Right of the ComboBox

            // Create End Time input (DateTimePicker)
            DateTimePicker endTimePicker = new DateTimePicker();
            endTimePicker.Name = "endTimePicker" + fieldCounter;
            endTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Width = 150;
            endTimePicker.Location = new Point(startTimePicker.Right + 10, 30); // Right of the StartTimePicker


            // Add the controls to the group box
            inputGroupBox.Controls.Add(gunaComboBox);
            inputGroupBox.Controls.Add(startTimePicker);
            inputGroupBox.Controls.Add(endTimePicker);

            // Add the group box to the main container (panel in this case)
            inputFieldsPanel.Controls.Add(inputGroupBox);

            fieldCounter++;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            RemoveLastInputField();
        }

        private void RemoveLastInputField()
        {
            if (fieldCounter > 0)
            {
                fieldCounter--;

                GroupBox lastGroupBox = (GroupBox)inputFieldsPanel.Controls["inputGroupBox" + fieldCounter];

                // Remove the event handlers from the controls within the group
                Guna2ComboBox lastComboBox = (Guna2ComboBox)lastGroupBox.Controls["gunaComboBox" + fieldCounter];
                DateTimePicker lastStartTimePicker = (DateTimePicker)lastGroupBox.Controls["startTimePicker" + fieldCounter];
                DateTimePicker lastEndTimePicker = (DateTimePicker)lastGroupBox.Controls["endTimePicker" + fieldCounter];


                lastComboBox.TextChanged -= guna2ComboBox1_SelectedIndexChanged;
                lastStartTimePicker.ValueChanged -= dateTimePicker1_ValueChanged;
                lastEndTimePicker.ValueChanged -= dateTimePicker1_ValueChanged;

                inputFieldsPanel.Controls.Remove(lastGroupBox);
            }
        }

        private void PositionTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert into Doctor table
                string doctorInsertQuery = "INSERT INTO Doctor (FirstName, LastName, Gender, DateOfBirth, PhoneNumber, EmailAddress, Address, YearsOfExperience, AreasOfExpertise, PreviousHospitals, MedicalDegree, Specialization, MedicalLicenseNumber) " +
                                           "VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @PhoneNumber, @EmailAddress, @Address, @YearsOfExperience, @AreasOfExpertise, @PreviousHospitals, @MedicalDegree, @Specialization, @MedicalLicenseNumber)";

                using (SqlCommand command = new SqlCommand(doctorInsertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                    command.Parameters.AddWithValue("@Gender", genderComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirthPicker.Value);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddressTextBox.Text);
                    command.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    command.Parameters.AddWithValue("@YearsOfExperience", yearsOfExperienceTextBox.Text);
                    command.Parameters.AddWithValue("@PreviousHospitals", previousHospitalsTextBox.Text);
                    command.Parameters.AddWithValue("@MedicalDegree", degreeTextBox.Text);
                    command.Parameters.AddWithValue("@Specialization", specializationTextBox.Text);
                    command.Parameters.AddWithValue("@MedicalLicenseNumber", licenseTextBox.Text);

                    command.ExecuteNonQuery(); // Execute the insert query
                }

                // Get the last inserted DoctorID
                string selectIdentityQuery = "SELECT SCOPE_IDENTITY()";
                using (SqlCommand identityCommand = new SqlCommand(selectIdentityQuery, connection))
                {
                    int doctorID = Convert.ToInt32(identityCommand.ExecuteScalar());

                    // Insert into Availability table

                    /*foreach (var availabilityItem in availabilityList)
                    {
                        string availabilityInsertQuery = "INSERT INTO Availability (DoctorID, DayOfWeek, StartTime, EndTime) " +
                                                        "VALUES (@DoctorID, @DayOfWeek, @StartTime, @EndTime)";

                        using (SqlCommand availabilityCommand = new SqlCommand(availabilityInsertQuery, connection))
                        {
                            availabilityCommand.Parameters.AddWithValue("@DoctorID", doctorID);
                            availabilityCommand.Parameters.AddWithValue("@DayOfWeek", availabilityItem.DayOfWeek);
                            availabilityCommand.Parameters.AddWithValue("@StartTime", availabilityItem.StartTime);
                            availabilityCommand.Parameters.AddWithValue("@EndTime", availabilityItem.EndTime);

                            availabilityCommand.ExecuteNonQuery(); // Execute the insert query
                        }
                    }*/
                }
            }

            MessageBox.Show("Doctor and availability information saved successfully.");

            // Clear the input fields and availability list as needed
        
        }
    }
}
