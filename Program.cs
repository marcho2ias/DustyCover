using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DustyCover
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Launch the Welcome page on startup
            Application.Run(new Dashboard());
        }
    }
}