using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmSite
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
            Login login = new Login();
            login.ShowDialog();

            // Keep the application running until all forms are closed
            while (Application.OpenForms.Count > 0)
            {
                Application.DoEvents();
            }
        }
    }
}
