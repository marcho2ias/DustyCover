using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DustyCover
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



            // Launch the Welcome page on startup
            Application.Run(new Dashboardv2());


            Application.Run(new WelcomePage());

            Application.Run(new UserAccount("TestUser"));


            Application.Run(new SignupForm());
        }
    }
}
