namespace ParkingManagement_GUI
{
    partial class CameraManageForm
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
            this.StartOutCamButton = new System.Windows.Forms.Button();
            this.StartInCamButton = new System.Windows.Forms.Button();
            this.SelectInCamCB = new System.Windows.Forms.ComboBox();
            this.StartScanCamBut = new System.Windows.Forms.Button();
            this.SelectScanCamCB = new System.Windows.Forms.ComboBox();
            this.SelectOutCamCB = new System.Windows.Forms.ComboBox();
            this.SelectInCamLB = new System.Windows.Forms.Label();
            this.SelectOutCamLB = new System.Windows.Forms.Label();
            this.SelectScanCamLB = new System.Windows.Forms.Label();
            this.StopInCamButton = new System.Windows.Forms.Button();
            this.StopOutCamBut = new System.Windows.Forms.Button();
            this.StopScanCamBut = new System.Windows.Forms.Button();
            this.InCamIPAddTxb = new System.Windows.Forms.TextBox();
            this.InCamIPAddLB = new System.Windows.Forms.Label();
            this.OutCamIPAddTxb = new System.Windows.Forms.TextBox();
            this.ScanCamIPAddTxb = new System.Windows.Forms.TextBox();
            this.OutCamIPAddLB = new System.Windows.Forms.Label();
            this.ScanCamIPAddLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartOutCamButton
            // 
            this.StartOutCamButton.Location = new System.Drawing.Point(326, 108);
            this.StartOutCamButton.Name = "StartOutCamButton";
            this.StartOutCamButton.Size = new System.Drawing.Size(111, 50);
            this.StartOutCamButton.TabIndex = 25;
            this.StartOutCamButton.Text = "Start Out Camera";
            this.StartOutCamButton.UseVisualStyleBackColor = true;
            this.StartOutCamButton.Click += new System.EventHandler(this.StartOutCamButton_Click);
            // 
            // StartInCamButton
            // 
            this.StartInCamButton.Location = new System.Drawing.Point(326, 24);
            this.StartInCamButton.Name = "StartInCamButton";
            this.StartInCamButton.Size = new System.Drawing.Size(111, 50);
            this.StartInCamButton.TabIndex = 26;
            this.StartInCamButton.Text = "Start In Camera";
            this.StartInCamButton.UseVisualStyleBackColor = true;
            this.StartInCamButton.Click += new System.EventHandler(this.StartInCamButton_Click);
            // 
            // SelectInCamCB
            // 
            this.SelectInCamCB.FormattingEnabled = true;
            this.SelectInCamCB.Location = new System.Drawing.Point(132, 26);
            this.SelectInCamCB.Name = "SelectInCamCB";
            this.SelectInCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectInCamCB.TabIndex = 27;
            this.SelectInCamCB.SelectedIndexChanged += new System.EventHandler(this.SelectInCamCB_SelectedIndexChanged);
            // 
            // StartScanCamBut
            // 
            this.StartScanCamBut.Location = new System.Drawing.Point(326, 186);
            this.StartScanCamBut.Name = "StartScanCamBut";
            this.StartScanCamBut.Size = new System.Drawing.Size(111, 50);
            this.StartScanCamBut.TabIndex = 29;
            this.StartScanCamBut.Text = "Start Scan Camera";
            this.StartScanCamBut.UseVisualStyleBackColor = true;
            this.StartScanCamBut.Click += new System.EventHandler(this.StartScanCamBut_Click);
            // 
            // SelectScanCamCB
            // 
            this.SelectScanCamCB.FormattingEnabled = true;
            this.SelectScanCamCB.Location = new System.Drawing.Point(132, 186);
            this.SelectScanCamCB.Name = "SelectScanCamCB";
            this.SelectScanCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectScanCamCB.TabIndex = 30;
            this.SelectScanCamCB.SelectedIndexChanged += new System.EventHandler(this.SelectScanCamCB_SelectedIndexChanged);
            // 
            // SelectOutCamCB
            // 
            this.SelectOutCamCB.FormattingEnabled = true;
            this.SelectOutCamCB.Location = new System.Drawing.Point(132, 108);
            this.SelectOutCamCB.Name = "SelectOutCamCB";
            this.SelectOutCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectOutCamCB.TabIndex = 28;
            this.SelectOutCamCB.SelectedIndexChanged += new System.EventHandler(this.SelectOutCamCB_SelectedIndexChanged);
            // 
            // SelectInCamLB
            // 
            this.SelectInCamLB.AutoSize = true;
            this.SelectInCamLB.Location = new System.Drawing.Point(18, 29);
            this.SelectInCamLB.Name = "SelectInCamLB";
            this.SelectInCamLB.Size = new System.Drawing.Size(104, 13);
            this.SelectInCamLB.TabIndex = 31;
            this.SelectInCamLB.Text = "Select input camera:";
            // 
            // SelectOutCamLB
            // 
            this.SelectOutCamLB.AutoSize = true;
            this.SelectOutCamLB.Location = new System.Drawing.Point(18, 111);
            this.SelectOutCamLB.Name = "SelectOutCamLB";
            this.SelectOutCamLB.Size = new System.Drawing.Size(111, 13);
            this.SelectOutCamLB.TabIndex = 32;
            this.SelectOutCamLB.Text = "Select output camera:";
            // 
            // SelectScanCamLB
            // 
            this.SelectScanCamLB.AutoSize = true;
            this.SelectScanCamLB.Location = new System.Drawing.Point(18, 189);
            this.SelectScanCamLB.Name = "SelectScanCamLB";
            this.SelectScanCamLB.Size = new System.Drawing.Size(104, 13);
            this.SelectScanCamLB.TabIndex = 33;
            this.SelectScanCamLB.Text = "Select scan camera:";
            // 
            // StopInCamButton
            // 
            this.StopInCamButton.Location = new System.Drawing.Point(443, 24);
            this.StopInCamButton.Name = "StopInCamButton";
            this.StopInCamButton.Size = new System.Drawing.Size(111, 50);
            this.StopInCamButton.TabIndex = 34;
            this.StopInCamButton.Text = "Stop In Camera";
            this.StopInCamButton.UseVisualStyleBackColor = true;
            // 
            // StopOutCamBut
            // 
            this.StopOutCamBut.Location = new System.Drawing.Point(443, 108);
            this.StopOutCamBut.Name = "StopOutCamBut";
            this.StopOutCamBut.Size = new System.Drawing.Size(111, 50);
            this.StopOutCamBut.TabIndex = 35;
            this.StopOutCamBut.Text = "Stop Out Camera";
            this.StopOutCamBut.UseVisualStyleBackColor = true;
            // 
            // StopScanCamBut
            // 
            this.StopScanCamBut.Location = new System.Drawing.Point(443, 186);
            this.StopScanCamBut.Name = "StopScanCamBut";
            this.StopScanCamBut.Size = new System.Drawing.Size(111, 50);
            this.StopScanCamBut.TabIndex = 36;
            this.StopScanCamBut.Text = "Stop Scan Camera";
            this.StopScanCamBut.UseVisualStyleBackColor = true;
            // 
            // InCamIPAddTxb
            // 
            this.InCamIPAddTxb.Location = new System.Drawing.Point(132, 54);
            this.InCamIPAddTxb.Name = "InCamIPAddTxb";
            this.InCamIPAddTxb.Size = new System.Drawing.Size(179, 20);
            this.InCamIPAddTxb.TabIndex = 37;
            this.InCamIPAddTxb.Visible = false;
            // 
            // InCamIPAddLB
            // 
            this.InCamIPAddLB.AutoSize = true;
            this.InCamIPAddLB.Location = new System.Drawing.Point(18, 58);
            this.InCamIPAddLB.Name = "InCamIPAddLB";
            this.InCamIPAddLB.Size = new System.Drawing.Size(99, 13);
            this.InCamIPAddLB.TabIndex = 38;
            this.InCamIPAddLB.Text = "Camera IP address:";
            this.InCamIPAddLB.Visible = false;
            // 
            // OutCamIPAddTxb
            // 
            this.OutCamIPAddTxb.Location = new System.Drawing.Point(132, 138);
            this.OutCamIPAddTxb.Name = "OutCamIPAddTxb";
            this.OutCamIPAddTxb.Size = new System.Drawing.Size(179, 20);
            this.OutCamIPAddTxb.TabIndex = 39;
            this.OutCamIPAddTxb.Visible = false;
            // 
            // ScanCamIPAddTxb
            // 
            this.ScanCamIPAddTxb.Location = new System.Drawing.Point(132, 216);
            this.ScanCamIPAddTxb.Name = "ScanCamIPAddTxb";
            this.ScanCamIPAddTxb.Size = new System.Drawing.Size(179, 20);
            this.ScanCamIPAddTxb.TabIndex = 40;
            this.ScanCamIPAddTxb.Visible = false;
            // 
            // OutCamIPAddLB
            // 
            this.OutCamIPAddLB.AutoSize = true;
            this.OutCamIPAddLB.Location = new System.Drawing.Point(18, 141);
            this.OutCamIPAddLB.Name = "OutCamIPAddLB";
            this.OutCamIPAddLB.Size = new System.Drawing.Size(99, 13);
            this.OutCamIPAddLB.TabIndex = 41;
            this.OutCamIPAddLB.Text = "Camera IP address:";
            this.OutCamIPAddLB.Visible = false;
            // 
            // ScanCamIPAddLB
            // 
            this.ScanCamIPAddLB.AutoSize = true;
            this.ScanCamIPAddLB.Location = new System.Drawing.Point(18, 219);
            this.ScanCamIPAddLB.Name = "ScanCamIPAddLB";
            this.ScanCamIPAddLB.Size = new System.Drawing.Size(99, 13);
            this.ScanCamIPAddLB.TabIndex = 42;
            this.ScanCamIPAddLB.Text = "Camera IP address:";
            this.ScanCamIPAddLB.Visible = false;
            // 
            // CameraManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(572, 263);
            this.Controls.Add(this.ScanCamIPAddLB);
            this.Controls.Add(this.OutCamIPAddLB);
            this.Controls.Add(this.ScanCamIPAddTxb);
            this.Controls.Add(this.OutCamIPAddTxb);
            this.Controls.Add(this.InCamIPAddLB);
            this.Controls.Add(this.InCamIPAddTxb);
            this.Controls.Add(this.StopScanCamBut);
            this.Controls.Add(this.StopOutCamBut);
            this.Controls.Add(this.StopInCamButton);
            this.Controls.Add(this.SelectScanCamLB);
            this.Controls.Add(this.SelectOutCamLB);
            this.Controls.Add(this.SelectInCamLB);
            this.Controls.Add(this.SelectScanCamCB);
            this.Controls.Add(this.StartScanCamBut);
            this.Controls.Add(this.SelectOutCamCB);
            this.Controls.Add(this.SelectInCamCB);
            this.Controls.Add(this.StartInCamButton);
            this.Controls.Add(this.StartOutCamButton);
            this.Name = "CameraManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraManageForm";
            this.Load += new System.EventHandler(this.CameraManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartOutCamButton;
        private System.Windows.Forms.Button StartInCamButton;
        private System.Windows.Forms.ComboBox SelectInCamCB;
        private System.Windows.Forms.ComboBox SelectOutCamCB;
        private System.Windows.Forms.Button StartScanCamBut;
        private System.Windows.Forms.ComboBox SelectScanCamCB;
        private System.Windows.Forms.Label SelectInCamLB;
        private System.Windows.Forms.Label SelectOutCamLB;
        private System.Windows.Forms.Label SelectScanCamLB;
        private System.Windows.Forms.Button StopInCamButton;
        private System.Windows.Forms.Button StopOutCamBut;
        private System.Windows.Forms.Button StopScanCamBut;
        private System.Windows.Forms.TextBox InCamIPAddTxb;
        private System.Windows.Forms.Label InCamIPAddLB;
        private System.Windows.Forms.TextBox OutCamIPAddTxb;
        private System.Windows.Forms.TextBox ScanCamIPAddTxb;
        private System.Windows.Forms.Label OutCamIPAddLB;
        private System.Windows.Forms.Label ScanCamIPAddLB;
    }
}