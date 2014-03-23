using System;
using System.Collections.Generic;
using System.Windows.Forms;
using components.Public;

namespace testApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Instance.LoadConfigurationData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new wndSettings());
        }
    }
}
