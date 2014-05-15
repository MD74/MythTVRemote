using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace MythTV_Remote
{
    public partial class SetFrontend : Form
    {
        

        public SetFrontend()
        {
            InitializeComponent();
            RegistryKey MyReg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MythRemote");
            if (MyReg == null)
            {
                RegistryKey MyReg2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\MythRemote");
                MyReg2.Close();
            }
            
            RegistryKey MyReg3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MythRemote");
            string strsvr = (string)MyReg3.GetValue("server");
            string strsvrprt = (string)MyReg3.GetValue("serverport");
            txtBFrontendIP.Text = strsvr;
            txtBFrontendPort.Text = strsvrprt;
            MyReg3.Close(); 

        }

        private void btnIPOK_Click(object sender, EventArgs e)
        {
            if (txtBFrontendIP.Text == null | txtBFrontendPort.Text == null)
            {
                MessageBox.Show("Warning", "Set and ip address", MessageBoxButtons.OK);
            }
            else
            {
               RegistryKey MyReg4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MythRemote", true);
               MyReg4.SetValue("server", txtBFrontendIP.Text);
               MyReg4.SetValue("serverport", txtBFrontendPort.Text);
               MyReg4.Close();
               SetFrontend.ActiveForm.Close();          
            } 
        }

        private void btnIPCancel_Click(object sender, EventArgs e)
        {
            SetFrontend.ActiveForm.Close();

        }
    }
}
