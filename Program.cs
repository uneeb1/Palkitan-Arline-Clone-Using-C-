using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakistan_International_Airlines
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new UserandAdminLogin());
           // Application.Run(new Registration());
           // Application.Run(new MainPage());
            Application.Run(new OnlineCheckIn());
      // Application.Run(new BookaFlight());
           //Application.Run(new FlightStatus());
            //    Application.Run(new ContactUs());
      // Application.Run(new AdminAddFLight());
        }
    }
}
