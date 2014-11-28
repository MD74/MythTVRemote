using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace MythTV_Remote
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

            //Retrieve Frontend IP and Port
            string serverchk = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverName", null);
            string serverIPchk = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverIP", null);
            string serverportchk = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverport", null);
            if (serverchk == null | serverportchk == null | serverIPchk == null)
            {
                Application.Run(new SetFrontend());
            }
            Application.Run(new MythMain());
        }
    }
}
