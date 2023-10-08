using AD_indiviual_project.Forms;
using System;
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
                Application.Run(new FrmMain()); 
            }
            else
            {
                Application.Run(new UserLogin()); 
            }
        }

        static bool IsUserLoggedIn()
        {
            
            return !string.IsNullOrEmpty(Session.Username) && !string.IsNullOrEmpty(Session.Role);
        }
    }
}
