using AD_indiviual_project.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_indiviual_project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FrmMain());

            if (IsUserLoggedIn())
            {
                Application.Run(new FrmMain()); // Show the main form
            }
            else
            {
                Application.Run(new Login()); // Redirect to the login form
            }
        }

        static bool IsUserLoggedIn()
        {
            // Add your logic here to check if the user is logged in
            // For example, you could check if the session has a valid username
            // and role stored in it.
            return !string.IsNullOrEmpty(Session.Username);
        }
    }
}
