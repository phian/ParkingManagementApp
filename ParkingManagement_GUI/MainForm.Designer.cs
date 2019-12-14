namespace ParkingManagement_GUI
{
    partial class MainForm
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
            this.Staff_Only_Form_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Staff_Only_Form_Btn
            // 
            this.Staff_Only_Form_Btn.Location = new System.Drawing.Point(267, 112);
            this.Staff_Only_Form_Btn.Name = "Staff_Only_Form_Btn";
            this.Staff_Only_Form_Btn.Size = new System.Drawing.Size(222, 218);
            this.Staff_Only_Form_Btn.TabIndex = 0;
            this.Staff_Only_Form_Btn.Text = "Quản lý nhân viên";
            this.Staff_Only_Form_Btn.UseVisualStyleBackColor = true;
            this.Staff_Only_Form_Btn.Click += new System.EventHandler(this.Staff_Only_Form_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Staff_Only_Form_Btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Staff_Only_Form_Btn;
    }
}