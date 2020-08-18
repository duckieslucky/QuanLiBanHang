namespace GUI.Resources.CustomComponent
{
    partial class FastViewBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pad = new Guna.UI.WinForms.GunaLinePanel();
            this.btnAn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCashout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblMahd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxSum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.tbxSale = new System.Windows.Forms.TextBox();
            this.tbxStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.pnlMode = new System.Windows.Forms.Panel();
            this.rdbTaiban = new System.Windows.Forms.RadioButton();
            this.rdbGiaohang = new System.Windows.Forms.RadioButton();
            this.rdbTructiep = new System.Windows.Forms.RadioButton();
            this.btnShowChitiet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label19 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.Color.White;
            this.pad.Controls.Add(this.dgv);
            this.pad.Controls.Add(this.btnAn);
            this.pad.Controls.Add(this.btnClose);
            this.pad.Controls.Add(this.btnCashout);
            this.pad.Controls.Add(this.lblMahd);
            this.pad.Controls.Add(this.tableLayoutPanel1);
            this.pad.Controls.Add(this.label19);
            this.pad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad.LineBottom = 2;
            this.pad.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pad.LineLeft = 2;
            this.pad.LineRight = 2;
            this.pad.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pad.LineTop = 40;
            this.pad.Location = new System.Drawing.Point(0, 0);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(895, 488);
            this.pad.TabIndex = 0;
            this.pad.Paint += new System.Windows.Forms.PaintEventHandler(this.pad_Paint);
            // 
            // btnAn
            // 
            this.btnAn.AnimationHoverSpeed = 0.07F;
            this.btnAn.AnimationSpeed = 0.03F;
            this.btnAn.BackColor = System.Drawing.Color.Transparent;
            this.btnAn.BaseColor = System.Drawing.Color.Transparent;
            this.btnAn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAn.BorderSize = 1;
            this.btnAn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAn.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAn.CheckedForeColor = System.Drawing.Color.White;
            this.btnAn.CheckedImage = null;
            this.btnAn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAn.FocusedColor = System.Drawing.Color.Empty;
            this.btnAn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAn.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAn.Image = null;
            this.btnAn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAn.Location = new System.Drawing.Point(739, 437);
            this.btnAn.Name = "btnAn";
            this.btnAn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAn.OnHoverImage = null;
            this.btnAn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAn.OnPressedColor = System.Drawing.Color.Black;
            this.btnAn.Radius = 8;
            this.btnAn.Size = new System.Drawing.Size(144, 41);
            this.btnAn.TabIndex = 53;
            this.btnAn.Text = "<< Ẩn danh sách";
            this.btnAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.BorderSize = 1;
            this.btnClose.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClose.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImage = null;
            this.btnClose.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.Location = new System.Drawing.Point(15, 437);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 8;
            this.btnClose.Size = new System.Drawing.Size(144, 41);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Đóng cửa sổ";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCashout
            // 
            this.btnCashout.Animated = true;
            this.btnCashout.AnimationHoverSpeed = 0.07F;
            this.btnCashout.AnimationSpeed = 0.03F;
            this.btnCashout.BackColor = System.Drawing.Color.Transparent;
            this.btnCashout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(85)))));
            this.btnCashout.BorderColor = System.Drawing.Color.Black;
            this.btnCashout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCashout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCashout.CheckedForeColor = System.Drawing.Color.White;
            this.btnCashout.CheckedImage = null;
            this.btnCashout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCashout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCashout.FocusedColor = System.Drawing.Color.Empty;
            this.btnCashout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashout.ForeColor = System.Drawing.Color.White;
            this.btnCashout.Image = null;
            this.btnCashout.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCashout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCashout.Location = new System.Drawing.Point(181, 437);
            this.btnCashout.Name = "btnCashout";
            this.btnCashout.OnHoverBaseColor = System.Drawing.Color.Tomato;
            this.btnCashout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCashout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCashout.OnHoverImage = null;
            this.btnCashout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCashout.OnPressedColor = System.Drawing.Color.White;
            this.btnCashout.Radius = 8;
            this.btnCashout.Size = new System.Drawing.Size(230, 41);
            this.btnCashout.TabIndex = 51;
            this.btnCashout.Text = "Thanh toán";
            this.btnCashout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCashout.Click += new System.EventHandler(this.btnCashout_Click);
            // 
            // lblMahd
            // 
            this.lblMahd.AutoSize = true;
            this.lblMahd.BackColor = System.Drawing.Color.Transparent;
            this.lblMahd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahd.ForeColor = System.Drawing.Color.White;
            this.lblMahd.Location = new System.Drawing.Point(213, 9);
            this.lblMahd.Name = "lblMahd";
            this.lblMahd.Size = new System.Drawing.Size(176, 30);
            this.lblMahd.TabIndex = 50;
            this.lblMahd.Text = "20200615HD000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.43176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.56824F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxSum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxNote, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxSale, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxStaff, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnShowChitiet, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 364);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Danh sách sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hình thức thanh toán";
            // 
            // tbxSum
            // 
            this.tbxSum.BackColor = System.Drawing.Color.White;
            this.tbxSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSum.Location = new System.Drawing.Point(173, 179);
            this.tbxSum.Multiline = true;
            this.tbxSum.Name = "tbxSum";
            this.tbxSum.ReadOnly = true;
            this.tbxSum.Size = new System.Drawing.Size(227, 38);
            this.tbxSum.TabIndex = 10;
            this.tbxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ghi chú";
            // 
            // tbxNote
            // 
            this.tbxNote.BackColor = System.Drawing.Color.White;
            this.tbxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNote.Location = new System.Drawing.Point(173, 223);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.ReadOnly = true;
            this.tbxNote.Size = new System.Drawing.Size(227, 90);
            this.tbxNote.TabIndex = 8;
            // 
            // tbxSale
            // 
            this.tbxSale.BackColor = System.Drawing.Color.White;
            this.tbxSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSale.Location = new System.Drawing.Point(173, 135);
            this.tbxSale.Multiline = true;
            this.tbxSale.Name = "tbxSale";
            this.tbxSale.ReadOnly = true;
            this.tbxSale.Size = new System.Drawing.Size(227, 38);
            this.tbxSale.TabIndex = 6;
            this.tbxSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxStaff
            // 
            this.tbxStaff.BackColor = System.Drawing.Color.White;
            this.tbxStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStaff.Location = new System.Drawing.Point(173, 47);
            this.tbxStaff.Multiline = true;
            this.tbxStaff.Name = "tbxStaff";
            this.tbxStaff.ReadOnly = true;
            this.tbxStaff.Size = new System.Drawing.Size(227, 38);
            this.tbxStaff.TabIndex = 5;
            this.tbxStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thanh toán";
            // 
            // tbxTime
            // 
            this.tbxTime.BackColor = System.Drawing.Color.White;
            this.tbxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTime.Location = new System.Drawing.Point(173, 3);
            this.tbxTime.Multiline = true;
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.ReadOnly = true;
            this.tbxTime.Size = new System.Drawing.Size(227, 38);
            this.tbxTime.TabIndex = 4;
            this.tbxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlMode
            // 
            this.pnlMode.Controls.Add(this.rdbTaiban);
            this.pnlMode.Controls.Add(this.rdbGiaohang);
            this.pnlMode.Controls.Add(this.rdbTructiep);
            this.pnlMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMode.Location = new System.Drawing.Point(173, 91);
            this.pnlMode.Name = "pnlMode";
            this.pnlMode.Size = new System.Drawing.Size(227, 38);
            this.pnlMode.TabIndex = 12;
            // 
            // rdbTaiban
            // 
            this.rdbTaiban.AutoSize = true;
            this.rdbTaiban.Enabled = false;
            this.rdbTaiban.Location = new System.Drawing.Point(162, 3);
            this.rdbTaiban.Name = "rdbTaiban";
            this.rdbTaiban.Size = new System.Drawing.Size(61, 17);
            this.rdbTaiban.TabIndex = 2;
            this.rdbTaiban.TabStop = true;
            this.rdbTaiban.Text = "Tại bàn";
            this.rdbTaiban.UseVisualStyleBackColor = true;
            // 
            // rdbGiaohang
            // 
            this.rdbGiaohang.AutoSize = true;
            this.rdbGiaohang.Enabled = false;
            this.rdbGiaohang.Location = new System.Drawing.Point(79, 3);
            this.rdbGiaohang.Name = "rdbGiaohang";
            this.rdbGiaohang.Size = new System.Drawing.Size(74, 17);
            this.rdbGiaohang.TabIndex = 1;
            this.rdbGiaohang.TabStop = true;
            this.rdbGiaohang.Text = "Giao hàng";
            this.rdbGiaohang.UseVisualStyleBackColor = true;
            // 
            // rdbTructiep
            // 
            this.rdbTructiep.AutoSize = true;
            this.rdbTructiep.Enabled = false;
            this.rdbTructiep.Location = new System.Drawing.Point(3, 3);
            this.rdbTructiep.Name = "rdbTructiep";
            this.rdbTructiep.Size = new System.Drawing.Size(67, 17);
            this.rdbTructiep.TabIndex = 0;
            this.rdbTructiep.TabStop = true;
            this.rdbTructiep.Text = "Trực tiếp";
            this.rdbTructiep.UseVisualStyleBackColor = true;
            // 
            // btnShowChitiet
            // 
            this.btnShowChitiet.AnimationHoverSpeed = 0.07F;
            this.btnShowChitiet.AnimationSpeed = 0.03F;
            this.btnShowChitiet.BackColor = System.Drawing.Color.Transparent;
            this.btnShowChitiet.BaseColor = System.Drawing.Color.Transparent;
            this.btnShowChitiet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(85)))));
            this.btnShowChitiet.BorderSize = 1;
            this.btnShowChitiet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnShowChitiet.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShowChitiet.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowChitiet.CheckedImage = null;
            this.btnShowChitiet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShowChitiet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowChitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowChitiet.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowChitiet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowChitiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(176)))), ((int)(((byte)(85)))));
            this.btnShowChitiet.Image = null;
            this.btnShowChitiet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShowChitiet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShowChitiet.Location = new System.Drawing.Point(173, 319);
            this.btnShowChitiet.Name = "btnShowChitiet";
            this.btnShowChitiet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShowChitiet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShowChitiet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowChitiet.OnHoverImage = null;
            this.btnShowChitiet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnShowChitiet.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowChitiet.Radius = 8;
            this.btnShowChitiet.Size = new System.Drawing.Size(227, 42);
            this.btnShowChitiet.TabIndex = 52;
            this.btnShowChitiet.Text = "Xem >>";
            this.btnShowChitiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowChitiet.Click += new System.EventHandler(this.btnShowChitiet_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(3, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(204, 30);
            this.label19.TabIndex = 44;
            this.label19.Text = "Thông tin hóa đơn:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pad;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 40;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanpham,
            this.dongia,
            this.soluong,
            this.thanhtien});
            this.dgv.Location = new System.Drawing.Point(429, 53);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 35;
            this.dgv.Size = new System.Drawing.Size(454, 364);
            this.dgv.TabIndex = 54;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sanpham
            // 
            this.sanpham.DataPropertyName = "tenSanPham";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sanpham.DefaultCellStyle = dataGridViewCellStyle2;
            this.sanpham.HeaderText = "Sản phẩm";
            this.sanpham.Name = "sanpham";
            this.sanpham.ReadOnly = true;
            this.sanpham.Width = 130;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "Dongia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dongia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.dongia.Width = 120;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Soluong";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.soluong.DefaultCellStyle = dataGridViewCellStyle4;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 70;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.DataPropertyName = "Thanhtien";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.thanhtien.DefaultCellStyle = dataGridViewCellStyle5;
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // FastViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 488);
            this.Controls.Add(this.pad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(895, 488);
            this.MinimumSize = new System.Drawing.Size(420, 488);
            this.Name = "FastViewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastViewBill";
            this.Load += new System.EventHandler(this.FastViewBill_Load);
            this.pad.ResumeLayout(false);
            this.pad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlMode.ResumeLayout(false);
            this.pnlMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel pad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.TextBox tbxSale;
        private System.Windows.Forms.TextBox tbxStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.Panel pnlMode;
        private System.Windows.Forms.RadioButton rdbTaiban;
        private System.Windows.Forms.RadioButton rdbGiaohang;
        private System.Windows.Forms.RadioButton rdbTructiep;
        private System.Windows.Forms.Label lblMahd;
        private Guna.UI.WinForms.GunaAdvenceButton btnCashout;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaAdvenceButton btnShowChitiet;
        private Guna.UI.WinForms.GunaAdvenceButton btnAn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}