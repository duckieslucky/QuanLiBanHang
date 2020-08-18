namespace GUI.Resources.CustomComponent
{
    partial class PersonalSetting
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
            this.components = new System.ComponentModel.Container();
            this.padContainer = new Guna.UI.WinForms.GunaLinePanel();
            this.tbxClose = new Guna.UI2.WinForms.Guna2TileButton();
            this.padChange = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbxXacnhan = new Guna.UI2.WinForms.Guna2TileButton();
            this.tbxRePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.padInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblCV = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblDc = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnDoiMK = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2TileButton();
            this.padContainer.SuspendLayout();
            this.padChange.SuspendLayout();
            this.padInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // padContainer
            // 
            this.padContainer.BackColor = System.Drawing.Color.White;
            this.padContainer.Controls.Add(this.btnCapnhat);
            this.padContainer.Controls.Add(this.btnDoiMK);
            this.padContainer.Controls.Add(this.tbxClose);
            this.padContainer.Controls.Add(this.padChange);
            this.padContainer.Controls.Add(this.padInfo);
            this.padContainer.Controls.Add(this.pictureBox1);
            this.padContainer.Controls.Add(this.label19);
            this.padContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padContainer.LineBottom = 5;
            this.padContainer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.padContainer.LineLeft = 3;
            this.padContainer.LineRight = 3;
            this.padContainer.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.padContainer.LineTop = 40;
            this.padContainer.Location = new System.Drawing.Point(0, 0);
            this.padContainer.Name = "padContainer";
            this.padContainer.Size = new System.Drawing.Size(777, 501);
            this.padContainer.TabIndex = 0;
            // 
            // tbxClose
            // 
            this.tbxClose.CheckedState.Parent = this.tbxClose;
            this.tbxClose.CustomImages.Parent = this.tbxClose;
            this.tbxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbxClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClose.ForeColor = System.Drawing.Color.White;
            this.tbxClose.HoverState.Parent = this.tbxClose;
            this.tbxClose.Location = new System.Drawing.Point(12, 437);
            this.tbxClose.Name = "tbxClose";
            this.tbxClose.ShadowDecoration.Parent = this.tbxClose;
            this.tbxClose.Size = new System.Drawing.Size(160, 45);
            this.tbxClose.TabIndex = 16;
            this.tbxClose.Text = "Đóng cửa sổ";
            this.tbxClose.Click += new System.EventHandler(this.tbxClose_Click);
            // 
            // padChange
            // 
            this.padChange.Controls.Add(this.tbxXacnhan);
            this.padChange.Controls.Add(this.tbxRePass);
            this.padChange.Controls.Add(this.tbxNewPass);
            this.padChange.Controls.Add(this.tbxPassword);
            this.padChange.Controls.Add(this.label12);
            this.padChange.Controls.Add(this.label11);
            this.padChange.Controls.Add(this.label10);
            this.padChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.padChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.padChange.Location = new System.Drawing.Point(192, 283);
            this.padChange.Name = "padChange";
            this.padChange.ShadowDecoration.Parent = this.padChange;
            this.padChange.Size = new System.Drawing.Size(573, 199);
            this.padChange.TabIndex = 48;
            this.padChange.Text = "Đổi mật khẩu";
            // 
            // tbxXacnhan
            // 
            this.tbxXacnhan.CheckedState.Parent = this.tbxXacnhan;
            this.tbxXacnhan.CustomImages.Parent = this.tbxXacnhan;
            this.tbxXacnhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxXacnhan.ForeColor = System.Drawing.Color.White;
            this.tbxXacnhan.HoverState.Parent = this.tbxXacnhan;
            this.tbxXacnhan.Location = new System.Drawing.Point(435, 97);
            this.tbxXacnhan.Name = "tbxXacnhan";
            this.tbxXacnhan.ShadowDecoration.Parent = this.tbxXacnhan;
            this.tbxXacnhan.Size = new System.Drawing.Size(117, 48);
            this.tbxXacnhan.TabIndex = 15;
            this.tbxXacnhan.Text = "Xác nhận";
            this.tbxXacnhan.Click += new System.EventHandler(this.tbxXacnhan_Click);
            // 
            // tbxRePass
            // 
            this.tbxRePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxRePass.DefaultText = "";
            this.tbxRePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxRePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxRePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRePass.DisabledState.Parent = this.tbxRePass;
            this.tbxRePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxRePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRePass.FocusedState.Parent = this.tbxRePass;
            this.tbxRePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxRePass.HoverState.Parent = this.tbxRePass;
            this.tbxRePass.Location = new System.Drawing.Point(203, 153);
            this.tbxRePass.Name = "tbxRePass";
            this.tbxRePass.PasswordChar = '\0';
            this.tbxRePass.PlaceholderText = "";
            this.tbxRePass.SelectedText = "";
            this.tbxRePass.ShadowDecoration.Parent = this.tbxRePass;
            this.tbxRePass.Size = new System.Drawing.Size(199, 31);
            this.tbxRePass.TabIndex = 14;
            this.tbxRePass.UseSystemPasswordChar = true;
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNewPass.DefaultText = "";
            this.tbxNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNewPass.DisabledState.Parent = this.tbxNewPass;
            this.tbxNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNewPass.FocusedState.Parent = this.tbxNewPass;
            this.tbxNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxNewPass.HoverState.Parent = this.tbxNewPass;
            this.tbxNewPass.Location = new System.Drawing.Point(203, 107);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.PasswordChar = '\0';
            this.tbxNewPass.PlaceholderText = "";
            this.tbxNewPass.SelectedText = "";
            this.tbxNewPass.ShadowDecoration.Parent = this.tbxNewPass;
            this.tbxNewPass.Size = new System.Drawing.Size(199, 31);
            this.tbxNewPass.TabIndex = 13;
            this.tbxNewPass.UseSystemPasswordChar = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.DefaultText = "";
            this.tbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPassword.DisabledState.Parent = this.tbxPassword;
            this.tbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPassword.FocusedState.Parent = this.tbxPassword;
            this.tbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPassword.HoverState.Parent = this.tbxPassword;
            this.tbxPassword.Location = new System.Drawing.Point(203, 53);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '\0';
            this.tbxPassword.PlaceholderText = "";
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.ShadowDecoration.Parent = this.tbxPassword;
            this.tbxPassword.Size = new System.Drawing.Size(199, 31);
            this.tbxPassword.TabIndex = 12;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nhâp lại mật khẩu:";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mật khẩu mới:";
            this.label11.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mật khẩu hiện tại:";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // padInfo
            // 
            this.padInfo.Controls.Add(this.lblEmail);
            this.padInfo.Controls.Add(this.lblGioitinh);
            this.padInfo.Controls.Add(this.lblCV);
            this.padInfo.Controls.Add(this.lblTK);
            this.padInfo.Controls.Add(this.lblDc);
            this.padInfo.Controls.Add(this.lblSDT);
            this.padInfo.Controls.Add(this.lblNgaySinh);
            this.padInfo.Controls.Add(this.lblHoTen);
            this.padInfo.Controls.Add(this.lblMa);
            this.padInfo.Controls.Add(this.label8);
            this.padInfo.Controls.Add(this.label7);
            this.padInfo.Controls.Add(this.label6);
            this.padInfo.Controls.Add(this.label9);
            this.padInfo.Controls.Add(this.label5);
            this.padInfo.Controls.Add(this.label1);
            this.padInfo.Controls.Add(this.label4);
            this.padInfo.Controls.Add(this.label2);
            this.padInfo.Controls.Add(this.label3);
            this.padInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.padInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.padInfo.Location = new System.Drawing.Point(192, 51);
            this.padInfo.Name = "padInfo";
            this.padInfo.ShadowDecoration.Parent = this.padInfo;
            this.padInfo.Size = new System.Drawing.Size(573, 226);
            this.padInfo.TabIndex = 47;
            this.padInfo.Text = "Thông tin cá nhân";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(375, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(195, 15);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "tmkhoa_18th1@student.agu.edu.vn";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(375, 122);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(33, 15);
            this.lblGioitinh.TabIndex = 16;
            this.lblGioitinh.Text = "Nam";
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Location = new System.Drawing.Point(375, 86);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(114, 15);
            this.lblCV.TabIndex = 15;
            this.lblCV.Text = "Nhân viên bán hàng";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(375, 50);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(33, 15);
            this.lblTK.TabIndex = 14;
            this.lblTK.Text = "khoa";
            // 
            // lblDc
            // 
            this.lblDc.AutoSize = true;
            this.lblDc.Location = new System.Drawing.Point(149, 194);
            this.lblDc.Name = "lblDc";
            this.lblDc.Size = new System.Drawing.Size(207, 15);
            this.lblDc.TabIndex = 13;
            this.lblDc.Text = "Cần Đăng, H.Châu Thành, T.An Giang";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(149, 158);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(67, 15);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "0914745129";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(149, 122);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(65, 15);
            this.lblNgaySinh.TabIndex = 11;
            this.lblNgaySinh.Text = "13/04/1999";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(149, 86);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(92, 15);
            this.lblHoTen.TabIndex = 10;
            this.lblHoTen.Text = "Trần Minh Khoa";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(149, 50);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(41, 15);
            this.lblMa.TabIndex = 9;
            this.lblMa.Text = "NV001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Địa chỉ:";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tài khoản:";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.DUCK_7;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(3, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(213, 30);
            this.label19.TabIndex = 44;
            this.label19.Text = "Thông tin nhân viên";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.padContainer;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.CheckedState.Parent = this.btnDoiMK;
            this.btnDoiMK.CustomImages.Parent = this.btnDoiMK;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.HoverState.Parent = this.btnDoiMK;
            this.btnDoiMK.Location = new System.Drawing.Point(12, 283);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.ShadowDecoration.Parent = this.btnDoiMK;
            this.btnDoiMK.Size = new System.Drawing.Size(160, 45);
            this.btnDoiMK.TabIndex = 16;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.CheckedState.Parent = this.btnCapnhat;
            this.btnCapnhat.CustomImages.Parent = this.btnCapnhat;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.HoverState.Parent = this.btnCapnhat;
            this.btnCapnhat.Location = new System.Drawing.Point(12, 334);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.ShadowDecoration.Parent = this.btnCapnhat;
            this.btnCapnhat.Size = new System.Drawing.Size(160, 45);
            this.btnCapnhat.TabIndex = 49;
            this.btnCapnhat.Text = "Cập nhật thông tin";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // PersonalSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 501);
            this.Controls.Add(this.padContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalSetting";
            this.Text = "PersonalSetting";
            this.Load += new System.EventHandler(this.PersonalSetting_Load);
            this.padContainer.ResumeLayout(false);
            this.padContainer.PerformLayout();
            this.padChange.ResumeLayout(false);
            this.padChange.PerformLayout();
            this.padInfo.ResumeLayout(false);
            this.padInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel padContainer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox padInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GroupBox padChange;
        private Guna.UI2.WinForms.Guna2TextBox tbxRePass;
        private Guna.UI2.WinForms.Guna2TextBox tbxNewPass;
        private Guna.UI2.WinForms.Guna2TextBox tbxPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblDc;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMa;
        private Guna.UI2.WinForms.Guna2TileButton tbxXacnhan;
        private Guna.UI2.WinForms.Guna2TileButton tbxClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI2.WinForms.Guna2TileButton btnDoiMK;
        private Guna.UI2.WinForms.Guna2TileButton btnCapnhat;
    }
}