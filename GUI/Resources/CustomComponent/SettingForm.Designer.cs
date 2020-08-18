namespace GUI.Resources.CustomComponent
{
    partial class SettingForm
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
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMaxScreen = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDarkMode = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMenu = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignOut_Bar = new FontAwesome.Sharp.IconButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gunaLinePanel1.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.bunifuCustomLabel3);
            this.gunaLinePanel1.Controls.Add(this.btnMaxScreen);
            this.gunaLinePanel1.Controls.Add(this.bunifuCustomLabel2);
            this.gunaLinePanel1.Controls.Add(this.btnDarkMode);
            this.gunaLinePanel1.Controls.Add(this.bunifuCustomLabel1);
            this.gunaLinePanel1.Controls.Add(this.btnMenu);
            this.gunaLinePanel1.Controls.Add(this.gunaGradient2Panel1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(280, 202);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(78, 152);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(142, 17);
            this.bunifuCustomLabel3.TabIndex = 47;
            this.bunifuCustomLabel3.Text = "Khóa màn hình cỡ lớn";
            // 
            // btnMaxScreen
            // 
            this.btnMaxScreen.BaseColor = System.Drawing.SystemColors.Control;
            this.btnMaxScreen.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.btnMaxScreen.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMaxScreen.FillColor = System.Drawing.Color.White;
            this.btnMaxScreen.Location = new System.Drawing.Point(34, 150);
            this.btnMaxScreen.Name = "btnMaxScreen";
            this.btnMaxScreen.Size = new System.Drawing.Size(38, 20);
            this.btnMaxScreen.TabIndex = 46;
            this.btnMaxScreen.CheckedChanged += new System.EventHandler(this.btnMaxScreen_CheckedChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(78, 109);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(112, 17);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Giao diện nền tối";
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BaseColor = System.Drawing.SystemColors.Control;
            this.btnDarkMode.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.btnDarkMode.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDarkMode.FillColor = System.Drawing.Color.White;
            this.btnDarkMode.Location = new System.Drawing.Point(34, 107);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(38, 20);
            this.btnDarkMode.TabIndex = 44;
            this.btnDarkMode.CheckedChanged += new System.EventHandler(this.btnDarkMode_CheckedChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(78, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(151, 17);
            this.bunifuCustomLabel1.TabIndex = 43;
            this.bunifuCustomLabel1.Text = "Hiển thị menu phím tắt";
            // 
            // btnMenu
            // 
            this.btnMenu.BaseColor = System.Drawing.SystemColors.Control;
            this.btnMenu.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.btnMenu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMenu.FillColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(34, 64);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 20);
            this.btnMenu.TabIndex = 42;
            this.btnMenu.CheckedChanged += new System.EventHandler(this.btnMenu_CheckedChanged);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.btnSignOut_Bar);
            this.gunaGradient2Panel1.Controls.Add(this.label4);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(280, 42);
            this.gunaGradient2Panel1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cài đặt giao diện";
            // 
            // btnSignOut_Bar
            // 
            this.btnSignOut_Bar.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut_Bar.FlatAppearance.BorderSize = 0;
            this.btnSignOut_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut_Bar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignOut_Bar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSignOut_Bar.IconColor = System.Drawing.Color.White;
            this.btnSignOut_Bar.IconSize = 30;
            this.btnSignOut_Bar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSignOut_Bar.Location = new System.Drawing.Point(242, 4);
            this.btnSignOut_Bar.Name = "btnSignOut_Bar";
            this.btnSignOut_Bar.Rotation = 0D;
            this.btnSignOut_Bar.Size = new System.Drawing.Size(35, 35);
            this.btnSignOut_Bar.TabIndex = 43;
            this.btnSignOut_Bar.UseVisualStyleBackColor = false;
            this.btnSignOut_Bar.Click += new System.EventHandler(this.btnSignOut_Bar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.gunaGradient2Panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 202);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingForm";
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGoogleSwitch btnMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI.WinForms.GunaGoogleSwitch btnDarkMode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Guna.UI.WinForms.GunaGoogleSwitch btnMaxScreen;
        private FontAwesome.Sharp.IconButton btnSignOut_Bar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}