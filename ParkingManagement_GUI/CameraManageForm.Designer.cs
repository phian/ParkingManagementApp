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
            this.SelectOutCamCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartOutCamButton
            // 
            this.StartOutCamButton.Location = new System.Drawing.Point(221, 122);
            this.StartOutCamButton.Name = "StartOutCamButton";
            this.StartOutCamButton.Size = new System.Drawing.Size(111, 50);
            this.StartOutCamButton.TabIndex = 25;
            this.StartOutCamButton.Text = "Start Out Camera";
            this.StartOutCamButton.UseVisualStyleBackColor = true;
            this.StartOutCamButton.Click += new System.EventHandler(this.StartOutCamButton_Click);
            // 
            // StartInCamButton
            // 
            this.StartInCamButton.Location = new System.Drawing.Point(221, 34);
            this.StartInCamButton.Name = "StartInCamButton";
            this.StartInCamButton.Size = new System.Drawing.Size(94, 50);
            this.StartInCamButton.TabIndex = 26;
            this.StartInCamButton.Text = "Start In Camera";
            this.StartInCamButton.UseVisualStyleBackColor = true;
            this.StartInCamButton.Click += new System.EventHandler(this.StartInCamButton_Click);
            // 
            // SelectInCamCB
            // 
            this.SelectInCamCB.FormattingEnabled = true;
            this.SelectInCamCB.Location = new System.Drawing.Point(58, 50);
            this.SelectInCamCB.Name = "SelectInCamCB";
            this.SelectInCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectInCamCB.TabIndex = 27;
            this.SelectInCamCB.SelectedIndexChanged += new System.EventHandler(this.SelectInCamCB_SelectedIndexChanged);
            // 
            // SelectOutCamCB
            // 
            this.SelectOutCamCB.FormattingEnabled = true;
            this.SelectOutCamCB.Location = new System.Drawing.Point(58, 138);
            this.SelectOutCamCB.Name = "SelectOutCamCB";
            this.SelectOutCamCB.Size = new System.Drawing.Size(121, 21);
            this.SelectOutCamCB.TabIndex = 28;
            this.SelectOutCamCB.SelectedIndexChanged += new System.EventHandler(this.SelectOutCamCB_SelectedIndexChanged);
            // 
            // CameraManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.SelectOutCamCB);
            this.Controls.Add(this.SelectInCamCB);
            this.Controls.Add(this.StartInCamButton);
            this.Controls.Add(this.StartOutCamButton);
            this.Name = "CameraManageForm";
            this.Text = "CameraManageForm";
            this.Load += new System.EventHandler(this.CameraManageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartOutCamButton;
        private System.Windows.Forms.Button StartInCamButton;
        private System.Windows.Forms.ComboBox SelectInCamCB;
        private System.Windows.Forms.ComboBox SelectOutCamCB;
    }
}