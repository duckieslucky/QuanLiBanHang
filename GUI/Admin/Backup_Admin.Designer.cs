namespace GUI.Admin
{
    partial class Backup_Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChon_1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tbxBackup = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tbxRestore = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnBackup_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnRestore_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(100, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sao lưu dữ liệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnChon_1);
            this.panel1.Controls.Add(this.btnBackup_Save);
            this.panel1.Controls.Add(this.tbxBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(64, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 200);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Đường dẫn:";
            // 
            // btnChon_1
            // 
            this.btnChon_1.AnimationHoverSpeed = 0.07F;
            this.btnChon_1.AnimationSpeed = 0.03F;
            this.btnChon_1.BackColor = System.Drawing.Color.Transparent;
            this.btnChon_1.BaseColor = System.Drawing.Color.Transparent;
            this.btnChon_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnChon_1.BorderSize = 1;
            this.btnChon_1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnChon_1.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnChon_1.CheckedForeColor = System.Drawing.Color.White;
            this.btnChon_1.CheckedImage = null;
            this.btnChon_1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnChon_1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChon_1.FocusedColor = System.Drawing.Color.Empty;
            this.btnChon_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon_1.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnChon_1.Image = null;
            this.btnChon_1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChon_1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChon_1.Location = new System.Drawing.Point(495, 49);
            this.btnChon_1.Name = "btnChon_1";
            this.btnChon_1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChon_1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChon_1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChon_1.OnHoverImage = null;
            this.btnChon_1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChon_1.OnPressedColor = System.Drawing.Color.Black;
            this.btnChon_1.Size = new System.Drawing.Size(82, 29);
            this.btnChon_1.TabIndex = 49;
            this.btnChon_1.Text = "Chọn...";
            this.btnChon_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChon_1.Click += new System.EventHandler(this.btnChon_1_Click);
            // 
            // tbxBackup
            // 
            this.tbxBackup.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbxBackup.Location = new System.Drawing.Point(23, 49);
            this.tbxBackup.Name = "tbxBackup";
            this.tbxBackup.Size = new System.Drawing.Size(466, 29);
            this.tbxBackup.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khôi phục dữ liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(728, 347);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnChon2);
            this.panel2.Controls.Add(this.btnRestore_Save);
            this.panel2.Controls.Add(this.tbxRestore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(64, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 200);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Đường dẫn:";
            // 
            // btnChon2
            // 
            this.btnChon2.AnimationHoverSpeed = 0.07F;
            this.btnChon2.AnimationSpeed = 0.03F;
            this.btnChon2.BackColor = System.Drawing.Color.Transparent;
            this.btnChon2.BaseColor = System.Drawing.Color.Transparent;
            this.btnChon2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnChon2.BorderSize = 1;
            this.btnChon2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnChon2.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnChon2.CheckedForeColor = System.Drawing.Color.White;
            this.btnChon2.CheckedImage = null;
            this.btnChon2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnChon2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChon2.FocusedColor = System.Drawing.Color.Empty;
            this.btnChon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon2.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnChon2.Image = null;
            this.btnChon2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChon2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChon2.Location = new System.Drawing.Point(497, 53);
            this.btnChon2.Name = "btnChon2";
            this.btnChon2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChon2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChon2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChon2.OnHoverImage = null;
            this.btnChon2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnChon2.OnPressedColor = System.Drawing.Color.Black;
            this.btnChon2.Size = new System.Drawing.Size(82, 29);
            this.btnChon2.TabIndex = 53;
            this.btnChon2.Text = "Chọn...";
            this.btnChon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChon2.Click += new System.EventHandler(this.btnChon2_Click);
            // 
            // tbxRestore
            // 
            this.tbxRestore.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbxRestore.Location = new System.Drawing.Point(25, 53);
            this.tbxRestore.Name = "tbxRestore";
            this.tbxRestore.Size = new System.Drawing.Size(466, 29);
            this.tbxRestore.TabIndex = 51;
            // 
            // btnBackup_Save
            // 
            this.btnBackup_Save.Animated = true;
            this.btnBackup_Save.AnimationHoverSpeed = 0.07F;
            this.btnBackup_Save.AnimationSpeed = 0.03F;
            this.btnBackup_Save.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup_Save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(85)))));
            this.btnBackup_Save.BorderColor = System.Drawing.Color.Black;
            this.btnBackup_Save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBackup_Save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBackup_Save.CheckedForeColor = System.Drawing.Color.White;
            this.btnBackup_Save.CheckedImage = null;
            this.btnBackup_Save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBackup_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackup_Save.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackup_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup_Save.ForeColor = System.Drawing.Color.White;
            this.btnBackup_Save.Image = global::GUI.Properties.Resources.save;
            this.btnBackup_Save.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBackup_Save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBackup_Save.Location = new System.Drawing.Point(390, 99);
            this.btnBackup_Save.Name = "btnBackup_Save";
            this.btnBackup_Save.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnBackup_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackup_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackup_Save.OnHoverImage = null;
            this.btnBackup_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBackup_Save.OnPressedColor = System.Drawing.Color.White;
            this.btnBackup_Save.Radius = 8;
            this.btnBackup_Save.Size = new System.Drawing.Size(187, 65);
            this.btnBackup_Save.TabIndex = 48;
            this.btnBackup_Save.Text = "Tạo bản sao chép";
            this.btnBackup_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBackup_Save.Click += new System.EventHandler(this.btnBackup_Save_Click);
            // 
            // btnRestore_Save
            // 
            this.btnRestore_Save.Animated = true;
            this.btnRestore_Save.AnimationHoverSpeed = 0.07F;
            this.btnRestore_Save.AnimationSpeed = 0.03F;
            this.btnRestore_Save.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore_Save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(85)))));
            this.btnRestore_Save.BorderColor = System.Drawing.Color.Black;
            this.btnRestore_Save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRestore_Save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRestore_Save.CheckedForeColor = System.Drawing.Color.White;
            this.btnRestore_Save.CheckedImage = null;
            this.btnRestore_Save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRestore_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestore_Save.FocusedColor = System.Drawing.Color.Empty;
            this.btnRestore_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore_Save.ForeColor = System.Drawing.Color.White;
            this.btnRestore_Save.Image = global::GUI.Properties.Resources.restore;
            this.btnRestore_Save.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRestore_Save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRestore_Save.Location = new System.Drawing.Point(394, 104);
            this.btnRestore_Save.Name = "btnRestore_Save";
            this.btnRestore_Save.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnRestore_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRestore_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRestore_Save.OnHoverImage = null;
            this.btnRestore_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRestore_Save.OnPressedColor = System.Drawing.Color.White;
            this.btnRestore_Save.Radius = 8;
            this.btnRestore_Save.Size = new System.Drawing.Size(185, 65);
            this.btnRestore_Save.TabIndex = 52;
            this.btnRestore_Save.Text = "Khôi phục dữ liệu";
            this.btnRestore_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRestore_Save.Click += new System.EventHandler(this.btnRestore_Save_Click);
            // 
            // Backup_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Backup_Admin";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Load += new System.EventHandler(this.Backup_Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbxBackup;
        private Guna.UI.WinForms.GunaAdvenceButton btnChon_1;
        private Guna.UI.WinForms.GunaAdvenceButton btnBackup_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnChon2;
        private Guna.UI.WinForms.GunaAdvenceButton btnRestore_Save;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbxRestore;
    }
}
