using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width >= 700)
            {
                timer1.Stop();

                FrmMain frmMain = new FrmMain();
                frmMain.Closed += (s, args) => this.Close(); // Properly dispose of Splash form
                frmMain.Show();

                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
