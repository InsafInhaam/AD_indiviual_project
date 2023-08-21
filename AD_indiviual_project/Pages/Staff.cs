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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddStaff addstaff = new AddStaff();
            addstaff.Show();
        }
    }
}
