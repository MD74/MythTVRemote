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
        string server = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "server", null);
        string serverport = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "serverport", null);
        string straction;

        

        public MythMain()
        {
            InitializeComponent();
            
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


        private void submiturl(string server, string serverport, string straction )
        {
            try
            {
                toolStripStatusLabel1.Text = "";
                server = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "server", null);
                serverport = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MythRemote", "serverport", null);

                WebRequest request = WebRequest.Create("http://" + server + ":" + serverport + "/Frontend/SendAction?Action=" + straction);
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
            submiturl(server, serverport, straction);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            straction = "RIGHT";
            submiturl(server, serverport, straction); 
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            straction = "UP";
            submiturl(server, serverport, straction);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            straction = "LEFT";
            submiturl(server, serverport, straction);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            straction = "DOWN";
            submiturl(server, serverport, straction);
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            straction = "Program Guide";
            submiturl(server, serverport, straction);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            straction = "INFO";
            submiturl(server, serverport, straction);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            straction = "ESCAPE";
            submiturl(server, serverport, straction);            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            straction = "MENU";
            submiturl(server, serverport, straction);
        }

        private void btnPageUp_Click(object sender, EventArgs e)
        {
            straction = "PAGEUP";
            submiturl(server, serverport, straction);
        }

        private void btnPageDown_Click(object sender, EventArgs e)
        {
            straction = "PAGEDOWN";
            submiturl(server, serverport, straction);
        }

        private void btnChannelUp_Click(object sender, EventArgs e)
        {
            straction = "CHANNELUP";
            submiturl(server, serverport, straction);
        }

        private void btnChannelDown_Click(object sender, EventArgs e)
        {
            straction = "CHANNELDOWN";
            submiturl(server, serverport, straction);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            straction = "1";
            submiturl(server, serverport, straction);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            straction = "2";
            submiturl(server, serverport, straction);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            straction = "3";
            submiturl(server, serverport, straction);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            straction = "4";
            submiturl(server, serverport, straction);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            straction = "5";
            submiturl(server, serverport, straction);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            straction = "6";
            submiturl(server, serverport, straction);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            straction = "7";
            submiturl(server, serverport, straction);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            straction = "8";
            submiturl(server, serverport, straction);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            straction = "9";
            submiturl(server, serverport, straction);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            straction = "0";
            submiturl(server, serverport, straction);
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            straction = "VOLUMEUP";
            submiturl(server, serverport, straction);
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            straction = "VOLUMEDOWN";
            submiturl(server, serverport, straction);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            straction = "SEEKRWND";
            submiturl(server, serverport, straction);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            straction = "PLAY";
            submiturl(server, serverport, straction);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            straction = "PAUSE";
            submiturl(server, serverport, straction);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            straction = "SEEKFFWD";
            submiturl(server, serverport, straction);
        }

        private void btnBigJumpRew_Click(object sender, EventArgs e)
        {
            straction = "CHANNELUP";
            submiturl(server, serverport, straction);
        }

        private void btnToggleRecord_Click(object sender, EventArgs e)
        {
            straction = "TOGGLERECORD";
            submiturl(server, serverport, straction);
        }

        private void btnBigJumpFwd_Click(object sender, EventArgs e)
        {
            straction = "CHANNELDOWN";
            submiturl(server, serverport, straction);
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
    }
}
