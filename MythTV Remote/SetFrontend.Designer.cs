namespace MythTV_Remote
{
    partial class SetFrontend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetFrontend));
            this.txtBFrontendIP = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblFrontendPort = new System.Windows.Forms.Label();
            this.txtBFrontendPort = new System.Windows.Forms.TextBox();
            this.btnIPOK = new System.Windows.Forms.Button();
            this.btnIPCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBFrontendIP
            // 
            this.txtBFrontendIP.Location = new System.Drawing.Point(134, 58);
            this.txtBFrontendIP.Name = "txtBFrontendIP";
            this.txtBFrontendIP.Size = new System.Drawing.Size(121, 20);
            this.txtBFrontendIP.TabIndex = 0;
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(36, 65);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(62, 13);
            this.lblServerIP.TabIndex = 1;
            this.lblServerIP.Text = "Frontend IP";
            // 
            // lblFrontendPort
            // 
            this.lblFrontendPort.AutoSize = true;
            this.lblFrontendPort.Location = new System.Drawing.Point(36, 102);
            this.lblFrontendPort.Name = "lblFrontendPort";
            this.lblFrontendPort.Size = new System.Drawing.Size(71, 13);
            this.lblFrontendPort.TabIndex = 2;
            this.lblFrontendPort.Text = "Frontend Port";
            // 
            // txtBFrontendPort
            // 
            this.txtBFrontendPort.Location = new System.Drawing.Point(134, 102);
            this.txtBFrontendPort.Name = "txtBFrontendPort";
            this.txtBFrontendPort.Size = new System.Drawing.Size(121, 20);
            this.txtBFrontendPort.TabIndex = 3;
            // 
            // btnIPOK
            // 
            this.btnIPOK.Location = new System.Drawing.Point(112, 162);
            this.btnIPOK.Name = "btnIPOK";
            this.btnIPOK.Size = new System.Drawing.Size(75, 23);
            this.btnIPOK.TabIndex = 4;
            this.btnIPOK.Text = "&Save";
            this.btnIPOK.UseVisualStyleBackColor = true;
            this.btnIPOK.Click += new System.EventHandler(this.btnIPOK_Click);
            // 
            // btnIPCancel
            // 
            this.btnIPCancel.Location = new System.Drawing.Point(205, 162);
            this.btnIPCancel.Name = "btnIPCancel";
            this.btnIPCancel.Size = new System.Drawing.Size(75, 23);
            this.btnIPCancel.TabIndex = 5;
            this.btnIPCancel.Text = "&Cancel";
            this.btnIPCancel.UseVisualStyleBackColor = true;
            this.btnIPCancel.Click += new System.EventHandler(this.btnIPCancel_Click);
            // 
            // SetFrontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 197);
            this.Controls.Add(this.btnIPCancel);
            this.Controls.Add(this.btnIPOK);
            this.Controls.Add(this.txtBFrontendPort);
            this.Controls.Add(this.lblFrontendPort);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.txtBFrontendIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetFrontend";
            this.Text = "SetFrontend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBFrontendIP;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblFrontendPort;
        private System.Windows.Forms.TextBox txtBFrontendPort;
        private System.Windows.Forms.Button btnIPOK;
        private System.Windows.Forms.Button btnIPCancel;
    }
}