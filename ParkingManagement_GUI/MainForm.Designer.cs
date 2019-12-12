namespace ParkingManagement_GUI
{
    partial class Staff_Only
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
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Note_PB = new System.Windows.Forms.PictureBox();
            this.Staff_Account_PB = new System.Windows.Forms.PictureBox();
            this.Note_Btn = new System.Windows.Forms.Button();
            this.Staff_Acc_Btn = new System.Windows.Forms.Button();
            this.Staff_PictureBox = new System.Windows.Forms.PictureBox();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Staff_acti_Panel = new System.Windows.Forms.Panel();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Note_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Account_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).BeginInit();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Side_Panel.Controls.Add(this.Note_PB);
            this.Side_Panel.Controls.Add(this.Staff_Account_PB);
            this.Side_Panel.Controls.Add(this.Note_Btn);
            this.Side_Panel.Controls.Add(this.Staff_Acc_Btn);
            this.Side_Panel.Controls.Add(this.Staff_PictureBox);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(170, 450);
            this.Side_Panel.TabIndex = 0;
            // 
            // Note_PB
            // 
            this.Note_PB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Note_PB.Location = new System.Drawing.Point(3, 301);
            this.Note_PB.Name = "Note_PB";
            this.Note_PB.Size = new System.Drawing.Size(49, 50);
            this.Note_PB.TabIndex = 4;
            this.Note_PB.TabStop = false;
            // 
            // Staff_Account_PB
            // 
            this.Staff_Account_PB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Staff_Account_PB.Location = new System.Drawing.Point(3, 163);
            this.Staff_Account_PB.Name = "Staff_Account_PB";
            this.Staff_Account_PB.Size = new System.Drawing.Size(49, 50);
            this.Staff_Account_PB.TabIndex = 0;
            this.Staff_Account_PB.TabStop = false;
            // 
            // Note_Btn
            // 
            this.Note_Btn.Location = new System.Drawing.Point(58, 301);
            this.Note_Btn.Name = "Note_Btn";
            this.Note_Btn.Size = new System.Drawing.Size(106, 53);
            this.Note_Btn.TabIndex = 3;
            this.Note_Btn.Text = "Nhật ký giao ca";
            this.Note_Btn.UseVisualStyleBackColor = true;
            // 
            // Staff_Acc_Btn
            // 
            this.Staff_Acc_Btn.Location = new System.Drawing.Point(58, 163);
            this.Staff_Acc_Btn.Name = "Staff_Acc_Btn";
            this.Staff_Acc_Btn.Size = new System.Drawing.Size(106, 53);
            this.Staff_Acc_Btn.TabIndex = 2;
            this.Staff_Acc_Btn.Text = "Nhân viên";
            this.Staff_Acc_Btn.UseVisualStyleBackColor = true;
            // 
            // Staff_PictureBox
            // 
            this.Staff_PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Staff_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.Staff_PictureBox.Name = "Staff_PictureBox";
            this.Staff_PictureBox.Size = new System.Drawing.Size(152, 109);
            this.Staff_PictureBox.TabIndex = 0;
            this.Staff_PictureBox.TabStop = false;
            // 
            // Top_Panel
            // 
            this.Top_Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Top_Panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Top_Panel.Controls.Add(this.panel2);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(170, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(665, 41);
            this.Top_Panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // Staff_acti_Panel
            // 
            this.Staff_acti_Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Staff_acti_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Staff_acti_Panel.Location = new System.Drawing.Point(170, 41);
            this.Staff_acti_Panel.Name = "Staff_acti_Panel";
            this.Staff_acti_Panel.Size = new System.Drawing.Size(665, 409);
            this.Staff_acti_Panel.TabIndex = 2;
            // 
            // Staff_Only
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.Staff_acti_Panel);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Side_Panel);
            this.Name = "Staff_Only";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Side_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Note_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Account_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Staff_acti_Panel;
        private System.Windows.Forms.PictureBox Staff_PictureBox;
        private System.Windows.Forms.PictureBox Note_PB;
        private System.Windows.Forms.PictureBox Staff_Account_PB;
        private System.Windows.Forms.Button Note_Btn;
        private System.Windows.Forms.Button Staff_Acc_Btn;
    }
}