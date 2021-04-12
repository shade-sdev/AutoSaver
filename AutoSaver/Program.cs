using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaver
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

            if (misc.checkIfPathExists(constants.autosaverpath) == true)
            {
                Application.Run(new Settings());
            } else
            {
                Application.Run(new AutoSaver());
            }

            
        }
    }
}
