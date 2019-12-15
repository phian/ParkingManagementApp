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
            this.Staff_acti_Panel = new System.Windows.Forms.Panel();
            this.analytic_Btn = new System.Windows.Forms.Button();
            this.priceEdit_Btn = new System.Windows.Forms.Button();
            this.Staff_Btn = new System.Windows.Forms.Button();
            this.Note_Btn = new System.Windows.Forms.Button();
            this.Staff_PictureBox = new System.Windows.Forms.PictureBox();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Side_Panel.Controls.Add(this.analytic_Btn);
            this.Side_Panel.Controls.Add(this.priceEdit_Btn);
            this.Side_Panel.Controls.Add(this.Staff_Btn);
            this.Side_Panel.Controls.Add(this.Note_Btn);
            this.Side_Panel.Controls.Add(this.Staff_PictureBox);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(170, 450);
            this.Side_Panel.TabIndex = 0;
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
            // analytic_Btn
            // 
            this.analytic_Btn.BackColor = System.Drawing.Color.White;
            this.analytic_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.analytic_Btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analytic_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.analytic_Btn.Image = global::ParkingManagement_GUI.Properties.Resources.icons8_pie_chart_52px;
            this.analytic_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analytic_Btn.Location = new System.Drawing.Point(0, 347);
            this.analytic_Btn.Name = "analytic_Btn";
            this.analytic_Btn.Size = new System.Drawing.Size(170, 61);
            this.analytic_Btn.TabIndex = 6;
            this.analytic_Btn.Text = "Doanh thu ";
            this.analytic_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analytic_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.analytic_Btn.UseVisualStyleBackColor = false;
            // 
            // priceEdit_Btn
            // 
            this.priceEdit_Btn.BackColor = System.Drawing.Color.White;
            this.priceEdit_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.priceEdit_Btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceEdit_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.priceEdit_Btn.Image = global::ParkingManagement_GUI.Properties.Resources.icons8_money_52px;
            this.priceEdit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceEdit_Btn.Location = new System.Drawing.Point(0, 274);
            this.priceEdit_Btn.Name = "priceEdit_Btn";
            this.priceEdit_Btn.Size = new System.Drawing.Size(170, 53);
            this.priceEdit_Btn.TabIndex = 5;
            this.priceEdit_Btn.Text = "Chỉnh sửa giá";
            this.priceEdit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.priceEdit_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.priceEdit_Btn.UseVisualStyleBackColor = false;
            this.priceEdit_Btn.Click += new System.EventHandler(this.priceEdit_Btn_Click);
            // 
            // Staff_Btn
            // 
            this.Staff_Btn.BackColor = System.Drawing.Color.White;
            this.Staff_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Staff_Btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Staff_Btn.Image = global::ParkingManagement_GUI.Properties.Resources.icons8_user_male_52px;
            this.Staff_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Staff_Btn.Location = new System.Drawing.Point(0, 128);
            this.Staff_Btn.Name = "Staff_Btn";
            this.Staff_Btn.Size = new System.Drawing.Size(170, 53);
            this.Staff_Btn.TabIndex = 4;
            this.Staff_Btn.Text = "Quản lý";
            this.Staff_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Staff_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Staff_Btn.UseVisualStyleBackColor = false;
            this.Staff_Btn.Click += new System.EventHandler(this.Staff_Btn_Click);
            // 
            // Note_Btn
            // 
            this.Note_Btn.BackColor = System.Drawing.Color.White;
            this.Note_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Note_Btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Note_Btn.Image = global::ParkingManagement_GUI.Properties.Resources.icons8_edit_property_52px_2;
            this.Note_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Note_Btn.Location = new System.Drawing.Point(0, 201);
            this.Note_Btn.Name = "Note_Btn";
            this.Note_Btn.Size = new System.Drawing.Size(170, 53);
            this.Note_Btn.TabIndex = 3;
            this.Note_Btn.Text = "Nhật ký giao ca";
            this.Note_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Note_Btn.UseVisualStyleBackColor = false;
            this.Note_Btn.Click += new System.EventHandler(this.Note_Btn_Click);
            // 
            // Staff_PictureBox
            // 
            this.Staff_PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Staff_PictureBox.Location = new System.Drawing.Point(6, 3);
            this.Staff_PictureBox.Name = "Staff_PictureBox";
            this.Staff_PictureBox.Size = new System.Drawing.Size(158, 112);
            this.Staff_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Staff_PictureBox.TabIndex = 0;
            this.Staff_PictureBox.TabStop = false;
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
        private System.Windows.Forms.Button Staff_Btn;
        private System.Windows.Forms.Button analytic_Btn;
        private System.Windows.Forms.Button priceEdit_Btn;
    }
}