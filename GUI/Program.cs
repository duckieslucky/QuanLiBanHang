using DTO;
using GUI.Resources.CustomComponent;
using GUI.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
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
            //Application.Run(new testAPi());
            Application.Run(new Login_GUI());
            //Application.Run(new Dashboard_GUI());
        }
    }
}
