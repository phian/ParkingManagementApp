namespace ParkingManagement_GUI
{
    partial class Staff_Only_Form
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
            this.Staff_Acc_Btn = new System.Windows.Forms.Button();
            this.Note_Btn = new System.Windows.Forms.Button();
            this.Staff_PictureBox = new System.Windows.Forms.PictureBox();
            this.Staff_acti_Panel = new System.Windows.Forms.Panel();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Side_Panel.Controls.Add(this.Staff_Acc_Btn);
            this.Side_Panel.Controls.Add(this.Note_Btn);
            this.Side_Panel.Controls.Add(this.Staff_PictureBox);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(170, 450);
            this.Side_Panel.TabIndex = 0;
            // 
            // Staff_Acc_Btn
            // 
            this.Staff_Acc_Btn.Location = new System.Drawing.Point(0, 168);
            this.Staff_Acc_Btn.Name = "Staff_Acc_Btn";
            this.Staff_Acc_Btn.Size = new System.Drawing.Size(170, 53);
            this.Staff_Acc_Btn.TabIndex = 2;
            this.Staff_Acc_Btn.Text = "Nhân viên";
            this.Staff_Acc_Btn.UseVisualStyleBackColor = true;
            this.Staff_Acc_Btn.Click += new System.EventHandler(this.Staff_Acc_Btn_Click);
            // 
            // Note_Btn
            // 
            this.Note_Btn.Location = new System.Drawing.Point(0, 287);
            this.Note_Btn.Name = "Note_Btn";
            this.Note_Btn.Size = new System.Drawing.Size(170, 53);
            this.Note_Btn.TabIndex = 3;
            this.Note_Btn.Text = "Nhật ký giao ca";
            this.Note_Btn.UseVisualStyleBackColor = true;
            // 
            // Staff_PictureBox
            // 
            this.Staff_PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Staff_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Staff_PictureBox.Name = "Staff_PictureBox";
            this.Staff_PictureBox.Size = new System.Drawing.Size(170, 121);
            this.Staff_PictureBox.TabIndex = 0;
            this.Staff_PictureBox.TabStop = false;
            // 
            // Staff_acti_Panel
            // 
            this.Staff_acti_Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Staff_acti_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Staff_acti_Panel.Location = new System.Drawing.Point(170, 0);
            this.Staff_acti_Panel.Name = "Staff_acti_Panel";
            this.Staff_acti_Panel.Size = new System.Drawing.Size(665, 450);
            this.Staff_acti_Panel.TabIndex = 2;
       
            // 
            // Staff_Only_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.Staff_acti_Panel);
            this.Controls.Add(this.Side_Panel);
            this.Name = "Staff_Only_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Staff_Only_Form_Load);
            this.Side_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Panel Staff_acti_Panel;
        private System.Windows.Forms.PictureBox Staff_PictureBox;
        private System.Windows.Forms.Button Note_Btn;
        private System.Windows.Forms.Button Staff_Acc_Btn;
    }
}