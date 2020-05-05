using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1chuong4
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
            // Application.Run(new Chaomung());
           // Application.Run(new Tinhtong());
           //  Application.Run(new menu());
            Application.Run(new chuongtrinhtinhtong());
        }
    }
}
