﻿using AD_indiviual_project.Models;
using System;
using System.Windows.Forms;

namespace AD_indiviual_project.Pages
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAppointment addappointment = new AddAppointment();
            addappointment.Show();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}
