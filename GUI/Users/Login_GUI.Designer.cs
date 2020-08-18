using GUI.Resources.Themes;

namespace GUI.Users
{
    partial class Login_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_GUI));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlLayout = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.tbxPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbxUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLayout
            // 
            this.pnlLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLayout.BackgroundImage")));
            this.pnlLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLayout.Controls.Add(this.label3);
            this.pnlLayout.Controls.Add(this.btnExit);
            this.pnlLayout.Controls.Add(this.linkLabel1);
            this.pnlLayout.Controls.Add(this.label4);
            this.pnlLayout.Controls.Add(this.label1);
            this.pnlLayout.Controls.Add(this.iconPictureBox2);
            this.pnlLayout.Controls.Add(this.iconPictureBox1);
            this.pnlLayout.Controls.Add(this.btnLogin);
            this.pnlLayout.Controls.Add(this.tbxPassword);
            this.pnlLayout.Controls.Add(this.tbxUsername);
            this.pnlLayout.Controls.Add(this.pictureBox1);
            this.pnlLayout.Controls.Add(this.label2);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlLayout.GradientBottomRight = System.Drawing.Color.Blue;
            this.pnlLayout.GradientTopLeft = System.Drawing.Color.Red;
            this.pnlLayout.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Quality = 10;
            this.pnlLayout.Size = new System.Drawing.Size(345, 464);
            this.pnlLayout.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Drink and Foods";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconSize = 18;
            this.btnExit.Location = new System.Drawing.Point(194, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(3);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(114, 41);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(221, 444);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mika-Software";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "* Phần mềm được thiết kế bởi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "WELCOME BACK !";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 30;
            this.iconPictureBox2.Location = new System.Drawing.Point(40, 209);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(30, 34);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 15;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(40, 169);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 33);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconSize = 18;
            this.btnLogin.Location = new System.Drawing.Point(76, 267);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(3);
            this.btnLogin.Rotation = 0D;
            this.btnLogin.Size = new System.Drawing.Size(112, 41);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.AcceptsReturn = false;
            this.tbxPassword.AcceptsTab = false;
            this.tbxPassword.AnimationSpeed = 200;
            this.tbxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxPassword.BackgroundImage")));
            this.tbxPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbxPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbxPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbxPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbxPassword.BorderRadius = 1;
            this.tbxPassword.BorderThickness = 1;
            this.tbxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.tbxPassword.DefaultText = "";
            this.tbxPassword.FillColor = System.Drawing.Color.White;
            this.tbxPassword.HideSelection = true;
            this.tbxPassword.IconLeft = null;
            this.tbxPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.IconPadding = 10;
            this.tbxPassword.IconRight = null;
            this.tbxPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.Lines = new string[0];
            this.tbxPassword.Location = new System.Drawing.Point(76, 208);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbxPassword.Modified = false;
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbxPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxPassword.OnIdleState = stateProperties4;
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbxPassword.PlaceholderText = "Mật khẩu";
            this.tbxPassword.ReadOnly = false;
            this.tbxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.SelectionLength = 0;
            this.tbxPassword.SelectionStart = 0;
            this.tbxPassword.ShortcutsEnabled = true;
            this.tbxPassword.Size = new System.Drawing.Size(232, 35);
            this.tbxPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbxPassword.TabIndex = 11;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPassword.TextMarginBottom = 0;
            this.tbxPassword.TextMarginLeft = 5;
            this.tbxPassword.TextMarginTop = 0;
            this.tbxPassword.TextPlaceholder = "Mật khẩu";
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.WordWrap = true;
            // 
            // tbxUsername
            // 
            this.tbxUsername.AcceptsReturn = false;
            this.tbxUsername.AcceptsTab = false;
            this.tbxUsername.AnimationSpeed = 200;
            this.tbxUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxUsername.BackgroundImage")));
            this.tbxUsername.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbxUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbxUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbxUsername.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbxUsername.BorderRadius = 1;
            this.tbxUsername.BorderThickness = 1;
            this.tbxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.tbxUsername.DefaultText = "";
            this.tbxUsername.FillColor = System.Drawing.Color.White;
            this.tbxUsername.HideSelection = true;
            this.tbxUsername.IconLeft = null;
            this.tbxUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.IconPadding = 10;
            this.tbxUsername.IconRight = null;
            this.tbxUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.Lines = new string[0];
            this.tbxUsername.Location = new System.Drawing.Point(76, 167);
            this.tbxUsername.MaxLength = 32767;
            this.tbxUsername.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbxUsername.Modified = false;
            this.tbxUsername.Multiline = false;
            this.tbxUsername.Name = "tbxUsername";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxUsername.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbxUsername.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxUsername.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxUsername.OnIdleState = stateProperties8;
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbxUsername.PlaceholderText = "Tài khoản";
            this.tbxUsername.ReadOnly = false;
            this.tbxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.SelectionLength = 0;
            this.tbxUsername.SelectionStart = 0;
            this.tbxUsername.ShortcutsEnabled = true;
            this.tbxUsername.Size = new System.Drawing.Size(232, 35);
            this.tbxUsername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbxUsername.TabIndex = 10;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxUsername.TextMarginBottom = 0;
            this.tbxUsername.TextMarginLeft = 5;
            this.tbxUsername.TextMarginTop = 0;
            this.tbxUsername.TextPlaceholder = "Tài khoản";
            this.tbxUsername.UseSystemPasswordChar = false;
            this.tbxUsername.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duckies Bakery";
            // 
            // Mover
            // 
            this.Mover.Fixed = true;
            this.Mover.Horizontal = true;
            this.Mover.TargetControl = this.pnlLayout;
            this.Mover.Vertical = true;
            // 
            // Login_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 464);
            this.Controls.Add(this.pnlLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_GUI";
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbxPassword;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbxUsername;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnExit;
        private Bunifu.Framework.UI.BunifuDragControl Mover;
        private System.Windows.Forms.Label label3;
    }
}