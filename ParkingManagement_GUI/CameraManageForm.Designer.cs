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
            this.SelectInCamCB = new System.Windows.Forms.ComboBox();
            this.SelectScanCamCB = new System.Windows.Forms.ComboBox();
            this.SelectOutCamCB = new System.Windows.Forms.ComboBox();
            this.SelectInCamLB = new System.Windows.Forms.Label();
            this.SelectOutCamLB = new System.Windows.Forms.Label();
            this.SelectScanCamLB = new System.Windows.Forms.Label();
            this.HideFormButton = new System.Windows.Forms.Button();
            this.StopInCamButton = new System.Windows.Forms.Button();
            this.StartCamButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectInCamCB
            // 
            this.SelectInCamCB.FormattingEnabled = true;
            this.SelectInCamCB.Location = new System.Drawing.Point(147, 61);
            this.SelectInCamCB.Name = "SelectInCamCB";
            this.SelectInCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectInCamCB.TabIndex = 27;
            // 
            // SelectScanCamCB
            // 
            this.SelectScanCamCB.FormattingEnabled = true;
            this.SelectScanCamCB.Location = new System.Drawing.Point(147, 115);
            this.SelectScanCamCB.Name = "SelectScanCamCB";
            this.SelectScanCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectScanCamCB.TabIndex = 30;
            // 
            // SelectOutCamCB
            // 
            this.SelectOutCamCB.FormattingEnabled = true;
            this.SelectOutCamCB.Location = new System.Drawing.Point(147, 88);
            this.SelectOutCamCB.Name = "SelectOutCamCB";
            this.SelectOutCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectOutCamCB.TabIndex = 28;
            // 
            // SelectInCamLB
            // 
            this.SelectInCamLB.AutoSize = true;
            this.SelectInCamLB.Location = new System.Drawing.Point(33, 61);
            this.SelectInCamLB.Name = "SelectInCamLB";
            this.SelectInCamLB.Size = new System.Drawing.Size(104, 13);
            this.SelectInCamLB.TabIndex = 31;
            this.SelectInCamLB.Text = "Select input camera:";
            // 
            // SelectOutCamLB
            // 
            this.SelectOutCamLB.AutoSize = true;
            this.SelectOutCamLB.Location = new System.Drawing.Point(33, 91);
            this.SelectOutCamLB.Name = "SelectOutCamLB";
            this.SelectOutCamLB.Size = new System.Drawing.Size(111, 13);
            this.SelectOutCamLB.TabIndex = 32;
            this.SelectOutCamLB.Text = "Select output camera:";
            // 
            // SelectScanCamLB
            // 
            this.SelectScanCamLB.AutoSize = true;
            this.SelectScanCamLB.Location = new System.Drawing.Point(33, 120);
            this.SelectScanCamLB.Name = "SelectScanCamLB";
            this.SelectScanCamLB.Size = new System.Drawing.Size(104, 13);
            this.SelectScanCamLB.TabIndex = 33;
            this.SelectScanCamLB.Text = "Select scan camera:";
            // 
            // HideFormButton
            // 
            this.HideFormButton.Location = new System.Drawing.Point(238, 158);
            this.HideFormButton.Name = "HideFormButton";
            this.HideFormButton.Size = new System.Drawing.Size(111, 32);
            this.HideFormButton.TabIndex = 43;
            this.HideFormButton.Text = "Finish set up";
            this.HideFormButton.UseVisualStyleBackColor = true;
            this.HideFormButton.Click += new System.EventHandler(this.HideFormButton_Click);
            // 
            // StopInCamButton
            // 
            this.StopInCamButton.Location = new System.Drawing.Point(394, 61);
            this.StopInCamButton.Name = "StopInCamButton";
            this.StopInCamButton.Size = new System.Drawing.Size(100, 75);
            this.StopInCamButton.TabIndex = 34;
            this.StopInCamButton.Text = "Stop";
            this.StopInCamButton.UseVisualStyleBackColor = true;
            this.StopInCamButton.Click += new System.EventHandler(this.StopInCamButton_Click);
            // 
            // StartCamButton
            // 
            this.StartCamButton.Location = new System.Drawing.Point(288, 61);
            this.StartCamButton.Name = "StartCamButton";
            this.StartCamButton.Size = new System.Drawing.Size(100, 75);
            this.StartCamButton.TabIndex = 26;
            this.StartCamButton.Text = "Start";
            this.StartCamButton.UseVisualStyleBackColor = true;
            this.StartCamButton.Click += new System.EventHandler(this.StartCamButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "THIẾT LẬP";
            // 
            // CameraManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(518, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HideFormButton);
            this.Controls.Add(this.StopInCamButton);
            this.Controls.Add(this.SelectScanCamLB);
            this.Controls.Add(this.SelectOutCamLB);
            this.Controls.Add(this.SelectInCamLB);
            this.Controls.Add(this.SelectScanCamCB);
            this.Controls.Add(this.SelectOutCamCB);
            this.Controls.Add(this.SelectInCamCB);
            this.Controls.Add(this.StartCamButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CameraManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraManageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SelectInCamCB;
        private System.Windows.Forms.ComboBox SelectOutCamCB;
        private System.Windows.Forms.ComboBox SelectScanCamCB;
        private System.Windows.Forms.Label SelectInCamLB;
        private System.Windows.Forms.Label SelectOutCamLB;
        private System.Windows.Forms.Label SelectScanCamLB;
        private System.Windows.Forms.Button HideFormButton;
        private System.Windows.Forms.Button StopInCamButton;
        private System.Windows.Forms.Button StartCamButton;
        private System.Windows.Forms.Label label1;
    }
}