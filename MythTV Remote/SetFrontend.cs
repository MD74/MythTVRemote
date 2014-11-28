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
            string strsvrname01 = (string)MyReg3.GetValue("01_serverName");
            string strsvrip01 = (string)MyReg3.GetValue("01_serverIP");
            string strsvrprt01 = (string)MyReg3.GetValue("01_serverport");
            tbFrontendName1.Text = strsvrname01;
            txtBFrontendIP1.Text = strsvrip01;
            txtBFrontendPort1.Text = strsvrprt01;

            string strsvrname02 = (string)MyReg3.GetValue("02_serverName");
            string strsvrip02 = (string)MyReg3.GetValue("02_serverIP");
            string strsvrprt02 = (string)MyReg3.GetValue("02_serverport");
            tbFrontendName2.Text = strsvrname02;
            txtBFrontendIP2.Text = strsvrip02;
            txtBFrontendPort2.Text = strsvrprt02;

            string strsvrname03 = (string)MyReg3.GetValue("03_serverName");
            string strsvrip03 = (string)MyReg3.GetValue("03_serverIP");
            string strsvrprt03 = (string)MyReg3.GetValue("03_serverport");
            tbFrontendName3.Text = strsvrname03;
            txtBFrontendIP3.Text = strsvrip03;
            txtBFrontendPort3.Text = strsvrprt03;

            string strsvrname04 = (string)MyReg3.GetValue("04_serverName");
            string strsvrip04 = (string)MyReg3.GetValue("04_serverIP");
            string strsvrprt04 = (string)MyReg3.GetValue("04_serverport");
            tbFrontendName4.Text = strsvrname04;
            txtBFrontendIP4.Text = strsvrip04;
            txtBFrontendPort4.Text = strsvrprt04;

            string strsvrname05 = (string)MyReg3.GetValue("05_serverName");
            string strsvrip05 = (string)MyReg3.GetValue("05_serverIP");
            string strsvrprt05 = (string)MyReg3.GetValue("05_serverport");
            tbFrontendName5.Text = strsvrname05;
            txtBFrontendIP5.Text = strsvrip05;
            txtBFrontendPort5.Text = strsvrprt05;

            string strsvrname06 = (string)MyReg3.GetValue("06_serverName");
            string strsvrip06 = (string)MyReg3.GetValue("06_serverIP");
            string strsvrprt06 = (string)MyReg3.GetValue("06_serverport");
            tbFrontendName6.Text = strsvrname06;
            txtBFrontendIP6.Text = strsvrip06;
            txtBFrontendPort6.Text = strsvrprt06;

            string strsvrname07 = (string)MyReg3.GetValue("07_serverName");
            string strsvrip07 = (string)MyReg3.GetValue("07_serverIP");
            string strsvrprt07 = (string)MyReg3.GetValue("07_serverport");
            tbFrontendName7.Text = strsvrname07;
            txtBFrontendIP7.Text = strsvrip07;
            txtBFrontendPort7.Text = strsvrprt07;

            string strsvrname08 = (string)MyReg3.GetValue("08_serverName");
            string strsvrip08 = (string)MyReg3.GetValue("08_serverIP");
            string strsvrprt08 = (string)MyReg3.GetValue("08_serverport");
            tbFrontendName8.Text = strsvrname08;
            txtBFrontendIP8.Text = strsvrip08;
            txtBFrontendPort8.Text = strsvrprt08;

            string strsvrname09 = (string)MyReg3.GetValue("09_serverName");
            string strsvrip09 = (string)MyReg3.GetValue("09_serverIP");
            string strsvrprt09 = (string)MyReg3.GetValue("09_serverport");
            tbFrontendName9.Text = strsvrname09;
            txtBFrontendIP9.Text = strsvrip09;
            txtBFrontendPort9.Text = strsvrprt09;

            string strsvrname10 = (string)MyReg3.GetValue("10_serverName");
            string strsvrip10 = (string)MyReg3.GetValue("10_serverIP");
            string strsvrprt10 = (string)MyReg3.GetValue("10_serverport");
            tbFrontendName10.Text = strsvrname10;
            txtBFrontendIP10.Text = strsvrip10;
            txtBFrontendPort10.Text = strsvrprt10;

            string strsvrname11 = (string)MyReg3.GetValue("11_serverName");
            string strsvrip11 = (string)MyReg3.GetValue("11_serverIP");
            string strsvrprt11 = (string)MyReg3.GetValue("11_serverport");
            tbFrontendName11.Text = strsvrname11;
            txtBFrontendIP11.Text = strsvrip11;
            txtBFrontendPort11.Text = strsvrprt11;

            string strsvrname12 = (string)MyReg3.GetValue("12_serverName");
            string strsvrip12 = (string)MyReg3.GetValue("12_serverIP");
            string strsvrprt12 = (string)MyReg3.GetValue("12_serverport");
            tbFrontendName12.Text = strsvrname12;
            txtBFrontendIP12.Text = strsvrip12;
            txtBFrontendPort12.Text = strsvrprt12;

            string strsvrname13 = (string)MyReg3.GetValue("13_serverName");
            string strsvrip13 = (string)MyReg3.GetValue("13_serverIP");
            string strsvrprt13 = (string)MyReg3.GetValue("13_serverport");
            tbFrontendName13.Text = strsvrname13;
            txtBFrontendIP13.Text = strsvrip13;
            txtBFrontendPort13.Text = strsvrprt13;

            string strsvrname14 = (string)MyReg3.GetValue("14_serverName");
            string strsvrip14 = (string)MyReg3.GetValue("14_serverIP");
            string strsvrprt14 = (string)MyReg3.GetValue("14_serverport");
            tbFrontendName14.Text = strsvrname14;
            txtBFrontendIP14.Text = strsvrip14;
            txtBFrontendPort14.Text = strsvrprt14;

            string strsvrname15 = (string)MyReg3.GetValue("15_serverName");
            string strsvrip15 = (string)MyReg3.GetValue("15_serverIP");
            string strsvrprt15 = (string)MyReg3.GetValue("15_serverport");
            tbFrontendName15.Text = strsvrname15;
            txtBFrontendIP15.Text = strsvrip15;
            txtBFrontendPort15.Text = strsvrprt15;

            
            MyReg3.Close(); 

        }

        private void btnIPOK_Click(object sender, EventArgs e)
        {
            if (txtBFrontendIP1.Text == "")

            {
                MessageBox.Show("You must at least set 'Frontend 1' to a valid MythTV Frontend", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
               RegistryKey MyReg4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MythRemote", true);
               MyReg4.SetValue("01_serverName", tbFrontendName1.Text);
               MyReg4.SetValue("01_serverIP", txtBFrontendIP1.Text);
               MyReg4.SetValue("01_serverport", txtBFrontendPort1.Text);
               
               MyReg4.SetValue("02_serverName", tbFrontendName2.Text);
               MyReg4.SetValue("02_serverIP", txtBFrontendIP2.Text);
               MyReg4.SetValue("02_serverport", txtBFrontendPort2.Text); 
               
               MyReg4.SetValue("03_serverName", tbFrontendName3.Text);
               MyReg4.SetValue("03_serverIP", txtBFrontendIP3.Text);
               MyReg4.SetValue("03_serverport", txtBFrontendPort3.Text); 
               
               MyReg4.SetValue("04_serverName", tbFrontendName4.Text);
               MyReg4.SetValue("04_serverIP", txtBFrontendIP4.Text);
               MyReg4.SetValue("04_serverport", txtBFrontendPort4.Text); 
               
               MyReg4.SetValue("05_serverName", tbFrontendName5.Text);
               MyReg4.SetValue("05_serverIP", txtBFrontendIP5.Text);
               MyReg4.SetValue("05_serverport", txtBFrontendPort5.Text); 
               
               MyReg4.SetValue("06_serverName", tbFrontendName6.Text);
               MyReg4.SetValue("06_serverIP", txtBFrontendIP6.Text);
               MyReg4.SetValue("06_serverport", txtBFrontendPort6.Text); 
               
               MyReg4.SetValue("07_serverName", tbFrontendName7.Text);
               MyReg4.SetValue("07_serverIP", txtBFrontendIP7.Text);
               MyReg4.SetValue("07_serverport", txtBFrontendPort7.Text); 
               
               MyReg4.SetValue("08_serverName", tbFrontendName8.Text);
               MyReg4.SetValue("08_serverIP", txtBFrontendIP8.Text);
               MyReg4.SetValue("08_serverport", txtBFrontendPort8.Text); 
               
               MyReg4.SetValue("09_serverName", tbFrontendName9.Text);
               MyReg4.SetValue("09_serverIP", txtBFrontendIP9.Text);
               MyReg4.SetValue("09_serverport", txtBFrontendPort9.Text); 
               
               MyReg4.SetValue("10_serverName", tbFrontendName10.Text);
               MyReg4.SetValue("10_serverIP", txtBFrontendIP10.Text);
               MyReg4.SetValue("10_serverport", txtBFrontendPort10.Text); 
               
               MyReg4.SetValue("11_serverName", tbFrontendName11.Text);
               MyReg4.SetValue("11_serverIP", txtBFrontendIP11.Text);
               MyReg4.SetValue("11_serverport", txtBFrontendPort11.Text); 
               
               MyReg4.SetValue("12_serverName", tbFrontendName12.Text);
               MyReg4.SetValue("12_serverIP", txtBFrontendIP12.Text);
               MyReg4.SetValue("12_serverport", txtBFrontendPort12.Text); 
               
               MyReg4.SetValue("13_serverName", tbFrontendName13.Text);
               MyReg4.SetValue("13_serverIP", txtBFrontendIP13.Text);
               MyReg4.SetValue("13_serverport", txtBFrontendPort13.Text);

               MyReg4.SetValue("14_serverName", tbFrontendName14.Text);
               MyReg4.SetValue("14_serverIP", txtBFrontendIP14.Text);
               MyReg4.SetValue("14_serverport", txtBFrontendPort14.Text);
               
               MyReg4.SetValue("15_serverName", tbFrontendName15.Text);
               MyReg4.SetValue("15_serverIP", txtBFrontendIP15.Text);
               MyReg4.SetValue("15_serverport", txtBFrontendPort15.Text);
               MyReg4.Close();

               SetFrontend.ActiveForm.Close();          
            } 
        }

    }
}
