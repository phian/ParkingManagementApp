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
            this.Note_Btn = new System.Windows.Forms.Button();
            this.Staff_Acc_Btn = new System.Windows.Forms.Button();
            this.Staff_PictureBox = new System.Windows.Forms.PictureBox();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.AddSaveDe_Panel = new System.Windows.Forms.Panel();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Staff_acti_Panel = new System.Windows.Forms.Panel();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).BeginInit();
            this.Top_Panel.SuspendLayout();
            this.AddSaveDe_Panel.SuspendLayout();
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
            // Note_Btn
            // 
            this.Note_Btn.Location = new System.Drawing.Point(0, 287);
            this.Note_Btn.Name = "Note_Btn";
            this.Note_Btn.Size = new System.Drawing.Size(170, 53);
            this.Note_Btn.TabIndex = 3;
            this.Note_Btn.Text = "Nhật ký giao ca";
            this.Note_Btn.UseVisualStyleBackColor = true;
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
            // Staff_PictureBox
            // 
            this.Staff_PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Staff_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Staff_PictureBox.Name = "Staff_PictureBox";
            this.Staff_PictureBox.Size = new System.Drawing.Size(170, 121);
            this.Staff_PictureBox.TabIndex = 0;
            this.Staff_PictureBox.TabStop = false;
            // 
            // Top_Panel
            // 
            this.Top_Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Top_Panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Top_Panel.Controls.Add(this.AddSaveDe_Panel);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(170, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(665, 41);
            this.Top_Panel.TabIndex = 1;
            // 
            // AddSaveDe_Panel
            // 
            this.AddSaveDe_Panel.Controls.Add(this.Save_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Cancel_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Delete_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Edit_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Add_Btn);
            this.AddSaveDe_Panel.Location = new System.Drawing.Point(0, 0);
            this.AddSaveDe_Panel.Name = "AddSaveDe_Panel";
            this.AddSaveDe_Panel.Size = new System.Drawing.Size(665, 41);
            this.AddSaveDe_Panel.TabIndex = 0;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(485, 3);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(81, 32);
            this.Save_Btn.TabIndex = 3;
            this.Save_Btn.Text = "Lưu ";
            this.Save_Btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(572, 3);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(81, 32);
            this.Cancel_Btn.TabIndex = 1;
            this.Cancel_Btn.Text = "Quay lại";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(174, 3);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(81, 32);
            this.Delete_Btn.TabIndex = 2;
            this.Delete_Btn.Text = "Xoá";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(87, 3);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(81, 32);
            this.Edit_Btn.TabIndex = 1;
            this.Edit_Btn.Text = "Sửa";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(0, 3);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(81, 32);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Thêm ";
            this.Add_Btn.UseVisualStyleBackColor = true;
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
            // Staff_Only_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.Staff_acti_Panel);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Side_Panel);
            this.Name = "Staff_Only_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Staff_Only_Form_Load);
            this.Side_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            this.AddSaveDe_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel Staff_acti_Panel;
        private System.Windows.Forms.PictureBox Staff_PictureBox;
        private System.Windows.Forms.Button Note_Btn;
        private System.Windows.Forms.Button Staff_Acc_Btn;
        private System.Windows.Forms.Panel AddSaveDe_Panel;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Add_Btn;
    }
}