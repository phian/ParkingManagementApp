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
            this.ToolBox_Panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
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
            this.AddSaveDe_Panel = new System.Windows.Forms.Panel();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AccountInfo_Dtgrv)).BeginInit();
            this.ToolBox_Panel.SuspendLayout();
            this.AddSaveDe_Panel.SuspendLayout();
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
            this.FullName,
            this.Birth,
            this.Sex,
            this.AccountType,
            this.Password,
            this.ConfirmPass});
            this.AccountInfo_Dtgrv.Location = new System.Drawing.Point(0, 245);
            this.AccountInfo_Dtgrv.Name = "AccountInfo_Dtgrv";
            this.AccountInfo_Dtgrv.ReadOnly = true;
            this.AccountInfo_Dtgrv.Size = new System.Drawing.Size(659, 196);
            this.AccountInfo_Dtgrv.TabIndex = 0;
            this.AccountInfo_Dtgrv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountInfo_Dtgrv_RowEnter);
            // 
            // ToolBox_Panel
            // 
            this.ToolBox_Panel.Controls.Add(this.label8);
            this.ToolBox_Panel.Controls.Add(this.Sex_CBB);
            this.ToolBox_Panel.Controls.Add(this.label7);
            this.ToolBox_Panel.Controls.Add(this.button2);
            this.ToolBox_Panel.Controls.Add(this.button1);
            this.ToolBox_Panel.Controls.Add(this.AccountType_Cbb);
            this.ToolBox_Panel.Controls.Add(this.Birth_DT);
            this.ToolBox_Panel.Controls.Add(this.FullName_Txtb);
            this.ToolBox_Panel.Controls.Add(this.ConfirmPass_Txtb);
            this.ToolBox_Panel.Controls.Add(this.PassWord_Txtb);
            this.ToolBox_Panel.Controls.Add(this.UserName_Txtb);
            this.ToolBox_Panel.Controls.Add(this.label6);
            this.ToolBox_Panel.Controls.Add(this.label5);
            this.ToolBox_Panel.Controls.Add(this.label4);
            this.ToolBox_Panel.Controls.Add(this.label3);
            this.ToolBox_Panel.Controls.Add(this.label2);
            this.ToolBox_Panel.Controls.Add(this.label1);
            this.ToolBox_Panel.Location = new System.Drawing.Point(0, 41);
            this.ToolBox_Panel.Name = "ToolBox_Panel";
            this.ToolBox_Panel.Size = new System.Drawing.Size(659, 201);
            this.ToolBox_Panel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(461, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "(*) Trường thông tin không được bỏ trống";
            // 
            // Sex_CBB
            // 
            this.Sex_CBB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giới tính(*)";
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
            this.AccountType_Cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountType_Cbb.FormattingEnabled = true;
            this.AccountType_Cbb.Items.AddRange(new object[] {
            "Quản trị",
            "Nhân viên"});
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
            // AddSaveDe_Panel
            // 
            this.AddSaveDe_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddSaveDe_Panel.Controls.Add(this.Save_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Cancel_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Delete_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Edit_Btn);
            this.AddSaveDe_Panel.Controls.Add(this.Add_Btn);
            this.AddSaveDe_Panel.Location = new System.Drawing.Point(0, 0);
            this.AddSaveDe_Panel.Name = "AddSaveDe_Panel";
            this.AddSaveDe_Panel.Size = new System.Drawing.Size(665, 41);
            this.AddSaveDe_Panel.TabIndex = 2;
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
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(174, 3);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(81, 32);
            this.Delete_Btn.TabIndex = 2;
            this.Delete_Btn.Text = "Xoá";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(87, 3);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(81, 32);
            this.Edit_Btn.TabIndex = 1;
            this.Edit_Btn.Text = "Sửa";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(0, 3);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(81, 32);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Thêm ";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã nhân viên";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên đăng nhập";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Ten";
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
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
            // AccountType
            // 
            this.AccountType.DataPropertyName = "LoaiTaiKhoan";
            this.AccountType.HeaderText = "Loại tài khoản";
            this.AccountType.Name = "AccountType";
            this.AccountType.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Pass";
            this.Password.HeaderText = "matkhau";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.DataPropertyName = "Pass";
            this.ConfirmPass.HeaderText = "xacnhamatkhau";
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.ReadOnly = true;
            this.ConfirmPass.Visible = false;
            // 
            // UC_StaffMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddSaveDe_Panel);
            this.Controls.Add(this.ToolBox_Panel);
            this.Controls.Add(this.AccountInfo_Dtgrv);
            this.Name = "UC_StaffMana";
            this.Size = new System.Drawing.Size(660, 441);
            ((System.ComponentModel.ISupportInitialize)(this.AccountInfo_Dtgrv)).EndInit();
            this.ToolBox_Panel.ResumeLayout(false);
            this.ToolBox_Panel.PerformLayout();
            this.AddSaveDe_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountInfo_Dtgrv;
        private System.Windows.Forms.Panel ToolBox_Panel;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel AddSaveDe_Panel;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmPass;
    }
}
