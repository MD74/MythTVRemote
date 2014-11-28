using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.Win32;


namespace MythTV_Remote
{
    public partial class MythMain : Form
    {
        //Retrieve Frontend IP and Port
        //string server = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverName", null);
        //string serverIP = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverIP", null);
        //string serverport = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverport", null);
        
        string straction;
       
        

        public MythMain()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnSelect.PerformClick();
                    break;
                case Keys.Right:
                    btnRight.PerformClick();
                    break;
                case Keys.Up:
                    btnUp.PerformClick();
                    break;
                case Keys.Left:
                    btnLeft.PerformClick();
                    break;
                case Keys.Down:
                    btnDown.PerformClick();
                    break;
                case Keys.G:
                    btnGuide.PerformClick();
                    break;
                case Keys.I:
                    btnInfo.PerformClick();
                    break;
                case Keys.Escape:
                    btnBack.PerformClick();
                    break;
                case Keys.M:
                    btnMenu.PerformClick();
                    break;
                case Keys.PageUp:
                    btnPageUp.PerformClick();
                    break;
                case Keys.PageDown:
                    btnPageDown.PerformClick();
                    break;
                case Keys.Add:
                    btnChannelUp.PerformClick();
                    break;
                case Keys.Subtract:
                    btnChannelDown.PerformClick();
                    break;
                case Keys.NumPad1:
                    btnNum1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btnNum2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btnNum3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btnNum4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btnNum5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btnNum6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btnNum7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btnNum8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btnNum9.PerformClick();
                    break;
                case Keys.NumPad0:
                    btnNum0.PerformClick();
                    break;
                case Keys.F11:
                    btnVolumeUp.PerformClick();
                    break;
                case Keys.F10:
                    btnVolumeDown.PerformClick();
                    break;
                case Keys.P:
                    btnPause.PerformClick();
                    break;
                case Keys.R:
                    btnToggleRecord.PerformClick();
                    break;
                case Keys.Oemcomma:
                    btnRewind.PerformClick();
                    break;
                case Keys.OemPeriod:
                    btnForward.PerformClick();
                    break;
                default:
                    break;
            }
            return true;
        }


        private void submiturl(string straction )
        {
            try
            {
                
                toolStripStatusLabel1.Text = "";
                int intfrontend = cboxFrontend.SelectedIndex;
                intfrontend = intfrontend + 1;
                string strFrontend = intfrontend.ToString();

                string server = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "0" + strFrontend + "_serverName", null);
                string serverIP = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "0" + strFrontend + "_serverIP", null);
                string serverport = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "0" + strFrontend + "_serverport", null);
                //MessageBox.Show("http://" + serverIP + ":" + serverport + "/Frontend/SendAction?Action=" + straction);

                WebRequest request = WebRequest.Create("http://" + serverIP + ":" + serverport + "/Frontend/SendAction?Action=" + straction);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                toolStripStatusLabel1.Text = (((HttpWebResponse)response).StatusDescription);
                response.Close();

            }
            catch
            {
                MessageBox.Show("Are you sure you can connect to the frontend?", "Failed to Connect!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                toolStripStatusLabel1.Text = "Failed to Connect";
            }
                
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            straction = "SELECT";
            submiturl(straction);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            straction = "RIGHT";
            submiturl(straction); 
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            straction = "UP";
            submiturl(straction);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            straction = "LEFT";
            submiturl(straction);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            straction = "DOWN";
            submiturl(straction);
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            straction = "Program Guide";
            submiturl(straction);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            straction = "INFO";
            submiturl(straction);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            straction = "ESCAPE";
            submiturl(straction);            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            straction = "MENU";
            submiturl(straction);
        }

        private void btnPageUp_Click(object sender, EventArgs e)
        {
            straction = "PAGEUP";
            submiturl(straction);
        }

        private void btnPageDown_Click(object sender, EventArgs e)
        {
            straction = "PAGEDOWN";
            submiturl(straction);
        }

        private void btnChannelUp_Click(object sender, EventArgs e)
        {
            straction = "CHANNELUP";
            submiturl(straction);
        }

        private void btnChannelDown_Click(object sender, EventArgs e)
        {
            straction = "CHANNELDOWN";
            submiturl(straction);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            straction = "1";
            submiturl(straction);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            straction = "2";
            submiturl(straction);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            straction = "3";
            submiturl(straction);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            straction = "4";
            submiturl(straction);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            straction = "5";
            submiturl(straction);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            straction = "6";
            submiturl(straction);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            straction = "7";
            submiturl(straction);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            straction = "8";
            submiturl(straction);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            straction = "9";
            submiturl(straction);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            straction = "0";
            submiturl(straction);
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            straction = "VOLUMEUP";
            submiturl(straction);
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            straction = "VOLUMEDOWN";
            submiturl(straction);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            straction = "SEEKRWND";
            submiturl(straction);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            straction = "PLAY";
            submiturl(straction);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            straction = "PAUSE";
            submiturl(straction);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            straction = "SEEKFFWD";
            submiturl(straction);
        }

        private void btnBigJumpRew_Click(object sender, EventArgs e)
        {
            straction = "CHANNELUP";
            submiturl(straction);
        }

        private void btnToggleRecord_Click(object sender, EventArgs e)
        {
            straction = "TOGGLERECORD";
            submiturl(straction);
        }

        private void btnBigJumpFwd_Click(object sender, EventArgs e)
        {
            straction = "CHANNELDOWN";
            submiturl(straction);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void setFrontendIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFrontend frm2 = new SetFrontend();
            frm2.Show();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm3 = new About();
            frm3.Show();
        }

        private void cboxFrontend_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cboxFrontend_DropDown(object sender, System.EventArgs e)
        {
            cboxFrontend.Items.Clear();

            InitializeComboBox();
        }


        private void InitializeComboBox()
        {
            string strserver01 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverName", null);
            string strserver02 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "02_serverName", null);
            string strserver03 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "03_serverName", null);
            string strserver04 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "04_serverName", null);
            string strserver05 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "05_serverName", null);
            string strserver06 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "06_serverName", null);
            string strserver07 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "07_serverName", null);
            string strserver08 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "08_serverName", null);
            string strserver09 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "09_serverName", null);
            string strserver10 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "10_serverName", null);
            string strserver11 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "11_serverName", null);
            string strserver12 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "12_serverName", null);
            string strserver13 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "13_serverName", null);
            string strserver14 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "14_serverName", null);
            string strserver15 = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "15_serverName", null);



            if (strserver01 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "01_serverName", null));
            }
            if (strserver02 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "02_serverName", null));
            }
            if (strserver03 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "03_serverName", null));
            }
            if (strserver04 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "04_serverName", null));
            }
            if (strserver05 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "05_serverName", null));
            }
            if (strserver06 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "06_serverName", null));
            }
            if (strserver07 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "07_serverName", null));
            }
            if (strserver08 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "08_serverName", null));
            }
            if (strserver09 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "09_serverName", null));
            }
            if (strserver10 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "10_serverName", null));
            }
            if (strserver11 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "11_serverName", null));
            }
            if (strserver12 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "12_serverName", null));
            }
            if (strserver13 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "13_serverName", null));
            }
            if (strserver14 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "14_serverName", null));
            }
            if (strserver15 != "")
            {
                cboxFrontend.Items.Add((string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "15_serverName", null));
            }

            cboxFrontend.SelectedIndex = 0;
         
        }
    }
}
