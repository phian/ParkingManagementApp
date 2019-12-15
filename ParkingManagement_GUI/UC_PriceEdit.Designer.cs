namespace ParkingManagement_GUI
{
    partial class UC_PriceEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceDay_TxtB = new System.Windows.Forms.TextBox();
            this.priceNight_TxtB = new System.Windows.Forms.TextBox();
            this.savePrice_Btn = new System.Windows.Forms.Button();
            this.editPrice_Btn = new System.Windows.Forms.Button();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá qua đêm";
            // 
            // priceDay_TxtB
            // 
            this.priceDay_TxtB.Location = new System.Drawing.Point(271, 134);
            this.priceDay_TxtB.Name = "priceDay_TxtB";
            this.priceDay_TxtB.Size = new System.Drawing.Size(100, 20);
            this.priceDay_TxtB.TabIndex = 2;
            // 
            // priceNight_TxtB
            // 
            this.priceNight_TxtB.Location = new System.Drawing.Point(271, 224);
            this.priceNight_TxtB.Name = "priceNight_TxtB";
            this.priceNight_TxtB.Size = new System.Drawing.Size(100, 20);
            this.priceNight_TxtB.TabIndex = 3;
            // 
            // savePrice_Btn
            // 
            this.savePrice_Btn.Location = new System.Drawing.Point(398, 213);
            this.savePrice_Btn.Name = "savePrice_Btn";
            this.savePrice_Btn.Size = new System.Drawing.Size(75, 41);
            this.savePrice_Btn.TabIndex = 5;
            this.savePrice_Btn.Text = "Lưu";
            this.savePrice_Btn.UseVisualStyleBackColor = true;
            this.savePrice_Btn.Click += new System.EventHandler(this.savePrice_Btn_Click);
            // 
            // editPrice_Btn
            // 
            this.editPrice_Btn.Location = new System.Drawing.Point(29, 54);
            this.editPrice_Btn.Name = "editPrice_Btn";
            this.editPrice_Btn.Size = new System.Drawing.Size(75, 23);
            this.editPrice_Btn.TabIndex = 6;
            this.editPrice_Btn.Text = "Chỉnh sửa";
            this.editPrice_Btn.UseVisualStyleBackColor = true;
            this.editPrice_Btn.Click += new System.EventHandler(this.editPrice_Btn_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.Location = new System.Drawing.Point(490, 213);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(75, 41);
            this.cancel_Btn.TabIndex = 8;
            this.cancel_Btn.Text = "Quay lại";
            this.cancel_Btn.UseVisualStyleBackColor = true;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // UC_PriceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.editPrice_Btn);
            this.Controls.Add(this.savePrice_Btn);
            this.Controls.Add(this.priceNight_TxtB);
            this.Controls.Add(this.priceDay_TxtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_PriceEdit";
            this.Size = new System.Drawing.Size(665, 450);
            this.Load += new System.EventHandler(this.UC_PriceEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceDay_TxtB;
        private System.Windows.Forms.TextBox priceNight_TxtB;
        private System.Windows.Forms.Button savePrice_Btn;
        private System.Windows.Forms.Button editPrice_Btn;
        private System.Windows.Forms.Button cancel_Btn;
    }
}
