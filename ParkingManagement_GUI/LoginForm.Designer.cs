namespace ParkingManagement_GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.PasswordPB = new System.Windows.Forms.PictureBox();
            this.UserNamePB = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTxb = new System.Windows.Forms.TextBox();
            this.UserNameTxb = new System.Windows.Forms.TextBox();
            this.LoginHeaderImage = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginHeaderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordPB
            // 
            this.PasswordPB.Image = ((System.Drawing.Image)(resources.GetObject("PasswordPB.Image")));
            this.PasswordPB.Location = new System.Drawing.Point(56, 223);
            this.PasswordPB.Name = "PasswordPB";
            this.PasswordPB.Size = new System.Drawing.Size(38, 31);
            this.PasswordPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordPB.TabIndex = 15;
            this.PasswordPB.TabStop = false;
            // 
            // UserNamePB
            // 
            this.UserNamePB.Image = ((System.Drawing.Image)(resources.GetObject("UserNamePB.Image")));
            this.UserNamePB.Location = new System.Drawing.Point(56, 166);
            this.UserNamePB.Name = "UserNamePB";
            this.UserNamePB.Size = new System.Drawing.Size(38, 31);
            this.UserNamePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserNamePB.TabIndex = 14;
            this.UserNamePB.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(116, 284);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(139, 58);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxb.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTxb.Location = new System.Drawing.Point(94, 223);
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.Size = new System.Drawing.Size(203, 31);
            this.PasswordTxb.TabIndex = 12;
            this.PasswordTxb.Text = "Password";
            this.PasswordTxb.Enter += new System.EventHandler(this.PasswordTxb_Enter);
            this.PasswordTxb.Leave += new System.EventHandler(this.PasswordTxb_Leave);
            // 
            // UserNameTxb
            // 
            this.UserNameTxb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxb.ForeColor = System.Drawing.Color.DarkGray;
            this.UserNameTxb.Location = new System.Drawing.Point(94, 166);
            this.UserNameTxb.Name = "UserNameTxb";
            this.UserNameTxb.Size = new System.Drawing.Size(203, 31);
            this.UserNameTxb.TabIndex = 11;
            this.UserNameTxb.Text = "User name";
            this.UserNameTxb.Enter += new System.EventHandler(this.UserNameTxb_Enter);
            this.UserNameTxb.Leave += new System.EventHandler(this.UserNameTxb_Leave);
            // 
            // LoginHeaderImage
            // 
            this.LoginHeaderImage.Image = ((System.Drawing.Image)(resources.GetObject("LoginHeaderImage.Image")));
            this.LoginHeaderImage.Location = new System.Drawing.Point(133, 23);
            this.LoginHeaderImage.Name = "LoginHeaderImage";
            this.LoginHeaderImage.Size = new System.Drawing.Size(100, 100);
            this.LoginHeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginHeaderImage.TabIndex = 10;
            this.LoginHeaderImage.TabStop = false;
            this.LoginHeaderImage.Click += new System.EventHandler(this.LoginHeaderImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(327, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.PasswordPB);
            this.Controls.Add(this.UserNamePB);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTxb);
            this.Controls.Add(this.UserNameTxb);
            this.Controls.Add(this.LoginHeaderImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Click += new System.EventHandler(this.LoginForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginHeaderImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PasswordPB;
        private System.Windows.Forms.PictureBox UserNamePB;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTxb;
        private System.Windows.Forms.TextBox UserNameTxb;
        private System.Windows.Forms.PictureBox LoginHeaderImage;
        private System.Windows.Forms.Button btnExit;
    }
}

