using SimkapSmartServer.simkap.smart.server.view;
using System;
using System.Windows.Forms;

namespace SimkapSmartServer
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
            Application.Run(new FrmSettingServer());
        }
    }
}
