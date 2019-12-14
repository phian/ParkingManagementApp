namespace ParkingManagement_GUI
{
    partial class UC_StaffMana
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
            this.AccountInfo_Dtgrv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sex_CBB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountType_Cbb = new System.Windows.Forms.ComboBox();
            this.Birth_DT = new System.Windows.Forms.DateTimePicker();
            this.FullName_Txtb = new System.Windows.Forms.TextBox();
            this.ConfirmPass_Txtb = new System.Windows.Forms.TextBox();
            this.PassWord_Txtb = new System.Windows.Forms.TextBox();
            this.UserName_Txtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccounType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AccountInfo_Dtgrv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountInfo_Dtgrv
            // 
            this.AccountInfo_Dtgrv.AllowUserToAddRows = false;
            this.AccountInfo_Dtgrv.AllowUserToDeleteRows = false;
            this.AccountInfo_Dtgrv.AllowUserToResizeColumns = false;
            this.AccountInfo_Dtgrv.AllowUserToResizeRows = false;
            this.AccountInfo_Dtgrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountInfo_Dtgrv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.AccountInfo_Dtgrv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.AccountInfo_Dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountInfo_Dtgrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Name,
            this.Birth,
            this.Sex,
            this.AccounType});
            this.AccountInfo_Dtgrv.Location = new System.Drawing.Point(0, 210);
            this.AccountInfo_Dtgrv.Name = "AccountInfo_Dtgrv";
            this.AccountInfo_Dtgrv.ReadOnly = true;
            this.AccountInfo_Dtgrv.Size = new System.Drawing.Size(659, 196);
            this.AccountInfo_Dtgrv.TabIndex = 0;
            this.AccountInfo_Dtgrv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountInfo_Dtgrv_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sex_CBB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AccountType_Cbb);
            this.panel1.Controls.Add(this.Birth_DT);
            this.panel1.Controls.Add(this.FullName_Txtb);
            this.panel1.Controls.Add(this.ConfirmPass_Txtb);
            this.panel1.Controls.Add(this.PassWord_Txtb);
            this.panel1.Controls.Add(this.UserName_Txtb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 201);
            this.panel1.TabIndex = 1;
            // 
            // Sex_CBB
            // 
            this.Sex_CBB.FormattingEnabled = true;
            this.Sex_CBB.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.Sex_CBB.Location = new System.Drawing.Point(463, 107);
            this.Sex_CBB.Name = "Sex_CBB";
            this.Sex_CBB.Size = new System.Drawing.Size(52, 21);
            this.Sex_CBB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(353, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giới tính";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AccountType_Cbb
            // 
            this.AccountType_Cbb.FormattingEnabled = true;
            this.AccountType_Cbb.Location = new System.Drawing.Point(463, 149);
            this.AccountType_Cbb.Name = "AccountType_Cbb";
            this.AccountType_Cbb.Size = new System.Drawing.Size(186, 21);
            this.AccountType_Cbb.TabIndex = 11;
            // 
            // Birth_DT
            // 
            this.Birth_DT.Location = new System.Drawing.Point(463, 66);
            this.Birth_DT.Name = "Birth_DT";
            this.Birth_DT.Size = new System.Drawing.Size(186, 20);
            this.Birth_DT.TabIndex = 10;
            // 
            // FullName_Txtb
            // 
            this.FullName_Txtb.Location = new System.Drawing.Point(463, 23);
            this.FullName_Txtb.Name = "FullName_Txtb";
            this.FullName_Txtb.Size = new System.Drawing.Size(186, 20);
            this.FullName_Txtb.TabIndex = 9;
            // 
            // ConfirmPass_Txtb
            // 
            this.ConfirmPass_Txtb.Location = new System.Drawing.Point(139, 150);
            this.ConfirmPass_Txtb.Name = "ConfirmPass_Txtb";
            this.ConfirmPass_Txtb.Size = new System.Drawing.Size(143, 20);
            this.ConfirmPass_Txtb.TabIndex = 8;
            // 
            // PassWord_Txtb
            // 
            this.PassWord_Txtb.Location = new System.Drawing.Point(139, 86);
            this.PassWord_Txtb.Name = "PassWord_Txtb";
            this.PassWord_Txtb.Size = new System.Drawing.Size(143, 20);
            this.PassWord_Txtb.TabIndex = 7;
            // 
            // UserName_Txtb
            // 
            this.UserName_Txtb.Location = new System.Drawing.Point(139, 19);
            this.UserName_Txtb.Name = "UserName_Txtb";
            this.UserName_Txtb.Size = new System.Drawing.Size(168, 20);
            this.UserName_Txtb.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Xác nhận mật khẩu(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại tài khoản(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập(*)";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã nhân viên";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên đăng nhập";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Ten";
            this.Name.HeaderText = "Họ và tên";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Birth
            // 
            this.Birth.DataPropertyName = "NGAYSINH";
            this.Birth.HeaderText = "Ngày sinh";
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "GIOITINH";
            this.Sex.HeaderText = "Giới tính";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // AccounType
            // 
            this.AccounType.DataPropertyName = "LoaiTaiKhoan";
            this.AccounType.HeaderText = "Loại tài khoản";
            this.AccounType.Name = "AccounType";
            this.AccounType.ReadOnly = true;
            // 
            // UC_StaffMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AccountInfo_Dtgrv);
            this.Name.Name = "UC_StaffMana";
            this.Size = new System.Drawing.Size(665, 409);
            ((System.ComponentModel.ISupportInitialize)(this.AccountInfo_Dtgrv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountInfo_Dtgrv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox AccountType_Cbb;
        private System.Windows.Forms.DateTimePicker Birth_DT;
        private System.Windows.Forms.TextBox FullName_Txtb;
        private System.Windows.Forms.TextBox ConfirmPass_Txtb;
        private System.Windows.Forms.TextBox PassWord_Txtb;
        private System.Windows.Forms.TextBox UserName_Txtb;
        private System.Windows.Forms.ComboBox Sex_CBB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccounType;
    }
}
