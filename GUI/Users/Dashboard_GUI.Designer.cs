using GUI.Resources.Themes;
using System.Drawing;

namespace GUI
{
    partial class Dashboard_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_GUI));
            this.pnlMenuForm = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnBackup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProvider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlUserLayout = new System.Windows.Forms.Panel();
            this.padUserButton = new System.Windows.Forms.Panel();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.padUserInfo = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCv = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSignOut_Menu = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHide = new FontAwesome.Sharp.IconButton();
            this.btnSignOut_Bar = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.khoa123ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tai123ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuKhôiPhụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôiPhụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuYêuCầuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenuForm.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlUserLayout.SuspendLayout();
            this.padUserButton.SuspendLayout();
            this.padUserInfo.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStatusBar.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuForm
            // 
            this.pnlMenuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.pnlMenuForm.Controls.Add(this.pnlButton);
            this.pnlMenuForm.Controls.Add(this.pnlUserLayout);
            this.pnlMenuForm.Controls.Add(this.panel4);
            this.pnlMenuForm.Controls.Add(this.pnlLogo);
            this.pnlMenuForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuForm.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuForm.Name = "pnlMenuForm";
            this.pnlMenuForm.Size = new System.Drawing.Size(215, 753);
            this.pnlMenuForm.TabIndex = 0;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnBackup);
            this.pnlButton.Controls.Add(this.btnReport);
            this.pnlButton.Controls.Add(this.btnStaff);
            this.pnlButton.Controls.Add(this.btnProvider);
            this.pnlButton.Controls.Add(this.btnProduct);
            this.pnlButton.Controls.Add(this.btnImport);
            this.pnlButton.Controls.Add(this.btnBill);
            this.pnlButton.Controls.Add(this.btnTable);
            this.pnlButton.Controls.Add(this.btnSale);
            this.pnlButton.Controls.Add(this.btnHome);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(0, 197);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(12, 5, 0, 5);
            this.pnlButton.Size = new System.Drawing.Size(215, 500);
            this.pnlButton.TabIndex = 5;
            // 
            // btnBackup
            // 
            this.btnBackup.Active = false;
            this.btnBackup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.BorderRadius = 0;
            this.btnBackup.ButtonText = "      Sao lưu dữ liệu";
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackup.Iconimage = global::GUI.Properties.Resources.backup_file;
            this.btnBackup.Iconimage_right = null;
            this.btnBackup.Iconimage_right_Selected = null;
            this.btnBackup.Iconimage_Selected = null;
            this.btnBackup.IconMarginLeft = 6;
            this.btnBackup.IconMarginRight = 0;
            this.btnBackup.IconRightVisible = true;
            this.btnBackup.IconRightZoom = 0D;
            this.btnBackup.IconVisible = true;
            this.btnBackup.IconZoom = 65D;
            this.btnBackup.IsTab = true;
            this.btnBackup.Location = new System.Drawing.Point(12, 446);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBackup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnBackup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackup.selected = false;
            this.btnBackup.Size = new System.Drawing.Size(203, 49);
            this.btnBackup.TabIndex = 9;
            this.btnBackup.Text = "      Sao lưu dữ liệu";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Textcolor = System.Drawing.Color.White;
            this.btnBackup.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnReport
            // 
            this.btnReport.Active = false;
            this.btnReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.BorderRadius = 0;
            this.btnReport.ButtonText = "      Báo cáo";
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.DisabledColor = System.Drawing.Color.Gray;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReport.Iconimage")));
            this.btnReport.Iconimage_right = null;
            this.btnReport.Iconimage_right_Selected = null;
            this.btnReport.Iconimage_Selected = null;
            this.btnReport.IconMarginLeft = 6;
            this.btnReport.IconMarginRight = 0;
            this.btnReport.IconRightVisible = true;
            this.btnReport.IconRightZoom = 0D;
            this.btnReport.IconVisible = true;
            this.btnReport.IconZoom = 65D;
            this.btnReport.IsTab = true;
            this.btnReport.Location = new System.Drawing.Point(12, 397);
            this.btnReport.Name = "btnReport";
            this.btnReport.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnReport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReport.selected = false;
            this.btnReport.Size = new System.Drawing.Size(203, 49);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "      Báo cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Textcolor = System.Drawing.Color.White;
            this.btnReport.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStaff
            // 
            this.btnStaff.Active = false;
            this.btnStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStaff.BorderRadius = 0;
            this.btnStaff.ButtonText = "      Nhân viên";
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStaff.Iconimage")));
            this.btnStaff.Iconimage_right = null;
            this.btnStaff.Iconimage_right_Selected = null;
            this.btnStaff.Iconimage_Selected = null;
            this.btnStaff.IconMarginLeft = 6;
            this.btnStaff.IconMarginRight = 0;
            this.btnStaff.IconRightVisible = true;
            this.btnStaff.IconRightZoom = 0D;
            this.btnStaff.IconVisible = true;
            this.btnStaff.IconZoom = 65D;
            this.btnStaff.IsTab = true;
            this.btnStaff.Location = new System.Drawing.Point(12, 348);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStaff.selected = false;
            this.btnStaff.Size = new System.Drawing.Size(203, 49);
            this.btnStaff.TabIndex = 7;
            this.btnStaff.Text = "      Nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Textcolor = System.Drawing.Color.White;
            this.btnStaff.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnProvider
            // 
            this.btnProvider.Active = false;
            this.btnProvider.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnProvider.BackColor = System.Drawing.Color.Transparent;
            this.btnProvider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProvider.BorderRadius = 0;
            this.btnProvider.ButtonText = "      Nhà cung cấp";
            this.btnProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProvider.DisabledColor = System.Drawing.Color.Gray;
            this.btnProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProvider.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProvider.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProvider.Iconimage")));
            this.btnProvider.Iconimage_right = null;
            this.btnProvider.Iconimage_right_Selected = null;
            this.btnProvider.Iconimage_Selected = null;
            this.btnProvider.IconMarginLeft = 6;
            this.btnProvider.IconMarginRight = 0;
            this.btnProvider.IconRightVisible = true;
            this.btnProvider.IconRightZoom = 0D;
            this.btnProvider.IconVisible = true;
            this.btnProvider.IconZoom = 65D;
            this.btnProvider.IsTab = true;
            this.btnProvider.Location = new System.Drawing.Point(12, 299);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProvider.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnProvider.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProvider.selected = false;
            this.btnProvider.Size = new System.Drawing.Size(203, 49);
            this.btnProvider.TabIndex = 6;
            this.btnProvider.Text = "      Nhà cung cấp";
            this.btnProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvider.Textcolor = System.Drawing.Color.White;
            this.btnProvider.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnProduct
            // 
            this.btnProduct.Active = false;
            this.btnProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.BorderRadius = 0;
            this.btnProduct.ButtonText = "      Sản phẩm";
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProduct.Iconimage")));
            this.btnProduct.Iconimage_right = null;
            this.btnProduct.Iconimage_right_Selected = null;
            this.btnProduct.Iconimage_Selected = null;
            this.btnProduct.IconMarginLeft = 6;
            this.btnProduct.IconMarginRight = 0;
            this.btnProduct.IconRightVisible = true;
            this.btnProduct.IconRightZoom = 0D;
            this.btnProduct.IconVisible = true;
            this.btnProduct.IconZoom = 65D;
            this.btnProduct.IsTab = true;
            this.btnProduct.Location = new System.Drawing.Point(12, 250);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProduct.selected = false;
            this.btnProduct.Size = new System.Drawing.Size(203, 49);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "      Sản phẩm";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Textcolor = System.Drawing.Color.White;
            this.btnProduct.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnImport
            // 
            this.btnImport.Active = false;
            this.btnImport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.BorderRadius = 0;
            this.btnImport.ButtonText = "      Nhập hàng";
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.DisabledColor = System.Drawing.Color.Gray;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImport.Iconimage")));
            this.btnImport.Iconimage_right = null;
            this.btnImport.Iconimage_right_Selected = null;
            this.btnImport.Iconimage_Selected = null;
            this.btnImport.IconMarginLeft = 6;
            this.btnImport.IconMarginRight = 0;
            this.btnImport.IconRightVisible = true;
            this.btnImport.IconRightZoom = 0D;
            this.btnImport.IconVisible = true;
            this.btnImport.IconZoom = 65D;
            this.btnImport.IsTab = true;
            this.btnImport.Location = new System.Drawing.Point(12, 201);
            this.btnImport.Name = "btnImport";
            this.btnImport.Normalcolor = System.Drawing.Color.Transparent;
            this.btnImport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnImport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImport.selected = false;
            this.btnImport.Size = new System.Drawing.Size(203, 49);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "      Nhập hàng";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Textcolor = System.Drawing.Color.White;
            this.btnImport.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBill
            // 
            this.btnBill.Active = false;
            this.btnBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBill.BorderRadius = 0;
            this.btnBill.ButtonText = "      Hóa đơn";
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBill.Iconimage")));
            this.btnBill.Iconimage_right = null;
            this.btnBill.Iconimage_right_Selected = null;
            this.btnBill.Iconimage_Selected = null;
            this.btnBill.IconMarginLeft = 6;
            this.btnBill.IconMarginRight = 0;
            this.btnBill.IconRightVisible = true;
            this.btnBill.IconRightZoom = 0D;
            this.btnBill.IconVisible = true;
            this.btnBill.IconZoom = 65D;
            this.btnBill.IsTab = true;
            this.btnBill.Location = new System.Drawing.Point(12, 152);
            this.btnBill.Name = "btnBill";
            this.btnBill.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBill.selected = false;
            this.btnBill.Size = new System.Drawing.Size(203, 49);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "      Hóa đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Textcolor = System.Drawing.Color.White;
            this.btnBill.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTable
            // 
            this.btnTable.Active = false;
            this.btnTable.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTable.BorderRadius = 0;
            this.btnTable.ButtonText = "      Quản lý bàn";
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.DisabledColor = System.Drawing.Color.Gray;
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTable.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTable.Iconimage")));
            this.btnTable.Iconimage_right = null;
            this.btnTable.Iconimage_right_Selected = null;
            this.btnTable.Iconimage_Selected = null;
            this.btnTable.IconMarginLeft = 6;
            this.btnTable.IconMarginRight = 0;
            this.btnTable.IconRightVisible = true;
            this.btnTable.IconRightZoom = 0D;
            this.btnTable.IconVisible = true;
            this.btnTable.IconZoom = 65D;
            this.btnTable.IsTab = true;
            this.btnTable.Location = new System.Drawing.Point(12, 103);
            this.btnTable.Name = "btnTable";
            this.btnTable.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTable.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnTable.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTable.selected = false;
            this.btnTable.Size = new System.Drawing.Size(203, 49);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "      Quản lý bàn";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Textcolor = System.Drawing.Color.White;
            this.btnTable.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSale
            // 
            this.btnSale.Active = false;
            this.btnSale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnSale.BackColor = System.Drawing.Color.Transparent;
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSale.BorderRadius = 0;
            this.btnSale.ButtonText = "      Bán hàng";
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.DisabledColor = System.Drawing.Color.Gray;
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSale.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSale.Iconimage")));
            this.btnSale.Iconimage_right = null;
            this.btnSale.Iconimage_right_Selected = null;
            this.btnSale.Iconimage_Selected = null;
            this.btnSale.IconMarginLeft = 6;
            this.btnSale.IconMarginRight = 0;
            this.btnSale.IconRightVisible = true;
            this.btnSale.IconRightZoom = 0D;
            this.btnSale.IconVisible = true;
            this.btnSale.IconZoom = 65D;
            this.btnSale.IsTab = true;
            this.btnSale.Location = new System.Drawing.Point(12, 54);
            this.btnSale.Name = "btnSale";
            this.btnSale.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnSale.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSale.selected = false;
            this.btnSale.Size = new System.Drawing.Size(203, 49);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "      Bán hàng";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Textcolor = System.Drawing.Color.White;
            this.btnSale.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Active = false;
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "      Màn hình chính";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 6;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 65D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(12, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.White;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(203, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "      Màn hình chính";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlUserLayout
            // 
            this.pnlUserLayout.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserLayout.Controls.Add(this.padUserButton);
            this.pnlUserLayout.Controls.Add(this.padUserInfo);
            this.pnlUserLayout.Controls.Add(this.panel1);
            this.pnlUserLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserLayout.Location = new System.Drawing.Point(0, 54);
            this.pnlUserLayout.Name = "pnlUserLayout";
            this.pnlUserLayout.Size = new System.Drawing.Size(215, 143);
            this.pnlUserLayout.TabIndex = 6;
            // 
            // padUserButton
            // 
            this.padUserButton.Controls.Add(this.btnUser);
            this.padUserButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.padUserButton.Location = new System.Drawing.Point(0, 82);
            this.padUserButton.Name = "padUserButton";
            this.padUserButton.Size = new System.Drawing.Size(215, 56);
            this.padUserButton.TabIndex = 11;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.White;
            this.btnUser.IconSize = 30;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(12, 10);
            this.btnUser.Name = "btnUser";
            this.btnUser.Rotation = 0D;
            this.btnUser.Size = new System.Drawing.Size(194, 35);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "       Xem thông tin";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseCompatibleTextRendering = true;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // padUserInfo
            // 
            this.padUserInfo.Controls.Add(this.lblUsername);
            this.padUserInfo.Controls.Add(this.flowLayoutPanel2);
            this.padUserInfo.Controls.Add(this.flowLayoutPanel1);
            this.padUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padUserInfo.Location = new System.Drawing.Point(0, 0);
            this.padUserInfo.Name = "padUserInfo";
            this.padUserInfo.Size = new System.Drawing.Size(215, 138);
            this.padUserInfo.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(9, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 15);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Thông tin nhân viên";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblCv);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 58);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(194, 21);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // lblCv
            // 
            this.lblCv.AutoSize = true;
            this.lblCv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCv.ForeColor = System.Drawing.Color.White;
            this.lblCv.Location = new System.Drawing.Point(133, 0);
            this.lblCv.Name = "lblCv";
            this.lblCv.Size = new System.Drawing.Size(58, 17);
            this.lblCv.TabIndex = 7;
            this.lblCv.Text = "Chức vụ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 21);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(96, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Tên nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 5);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnSignOut_Menu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 697);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 56);
            this.panel4.TabIndex = 5;
            // 
            // btnSignOut_Menu
            // 
            this.btnSignOut_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnSignOut_Menu.FlatAppearance.BorderSize = 0;
            this.btnSignOut_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut_Menu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignOut_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSignOut_Menu.ForeColor = System.Drawing.Color.White;
            this.btnSignOut_Menu.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSignOut_Menu.IconColor = System.Drawing.Color.White;
            this.btnSignOut_Menu.IconSize = 30;
            this.btnSignOut_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut_Menu.Location = new System.Drawing.Point(12, 9);
            this.btnSignOut_Menu.Name = "btnSignOut_Menu";
            this.btnSignOut_Menu.Rotation = 0D;
            this.btnSignOut_Menu.Size = new System.Drawing.Size(194, 35);
            this.btnSignOut_Menu.TabIndex = 8;
            this.btnSignOut_Menu.Text = "       Đăng xuất";
            this.btnSignOut_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut_Menu.UseVisualStyleBackColor = false;
            this.btnSignOut_Menu.Click += new System.EventHandler(this.btnSignOut_Menu_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.label3);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(215, 54);
            this.pnlLogo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drink and Foods";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duckies Bakery";
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.pnlStatusBar.Controls.Add(this.guna2VSeparator1);
            this.pnlStatusBar.Controls.Add(this.lblTime);
            this.pnlStatusBar.Controls.Add(this.panel5);
            this.pnlStatusBar.Controls.Add(this.btnMenu);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusBar.Location = new System.Drawing.Point(215, 0);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(958, 54);
            this.pnlStatusBar.TabIndex = 1;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VSeparator1.FillColor = System.Drawing.Color.White;
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(818, 4);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 47);
            this.guna2VSeparator1.TabIndex = 45;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(554, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(258, 30);
            this.lblTime.TabIndex = 44;
            this.lblTime.Text = "13/04/2020 00:00:00 AM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnHide);
            this.panel5.Controls.Add(this.btnSignOut_Bar);
            this.panel5.Controls.Add(this.btnSetting);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(831, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 54);
            this.panel5.TabIndex = 2;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHide.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnHide.IconColor = System.Drawing.Color.White;
            this.btnHide.IconSize = 30;
            this.btnHide.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHide.Location = new System.Drawing.Point(46, 9);
            this.btnHide.Name = "btnHide";
            this.btnHide.Rotation = 0D;
            this.btnHide.Size = new System.Drawing.Size(35, 35);
            this.btnHide.TabIndex = 6;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
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
            this.btnSignOut_Bar.Location = new System.Drawing.Point(89, 9);
            this.btnSignOut_Bar.Name = "btnSignOut_Bar";
            this.btnSignOut_Bar.Rotation = 0D;
            this.btnSignOut_Bar.Size = new System.Drawing.Size(35, 35);
            this.btnSignOut_Bar.TabIndex = 5;
            this.btnSignOut_Bar.UseVisualStyleBackColor = false;
            this.btnSignOut_Bar.Click += new System.EventHandler(this.btnSignOut_Bar_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.White;
            this.btnSetting.IconSize = 30;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetting.Location = new System.Drawing.Point(3, 9);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Rotation = 0D;
            this.btnSetting.Size = new System.Drawing.Size(35, 35);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconSize = 30;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.Location = new System.Drawing.Point(6, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Rotation = 0D;
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlChildForm);
            this.panel2.Controls.Add(this.menuTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(215, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 699);
            this.panel2.TabIndex = 2;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(0, 24);
            this.pnlChildForm.MinimumSize = new System.Drawing.Size(942, 587);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(958, 675);
            this.pnlChildForm.TabIndex = 3;
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoa123ToolStripMenuItem,
            this.tai123ToolStripMenuItem,
            this.bánHàngToolStripMenuItem,
            this.thôngTinGiaoDịchToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(958, 24);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // khoa123ToolStripMenuItem
            // 
            this.khoa123ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.saoLưuKhôiPhụcToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.khoa123ToolStripMenuItem.Name = "khoa123ToolStripMenuItem";
            this.khoa123ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.khoa123ToolStripMenuItem.Text = "Hệ thống";
            // 
            // tai123ToolStripMenuItem
            // 
            this.tai123ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem});
            this.tai123ToolStripMenuItem.Name = "tai123ToolStripMenuItem";
            this.tai123ToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.tai123ToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánHàngToolStripMenuItem1,
            this.quảnLýBànToolStripMenuItem});
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            // 
            // thôngTinGiaoDịchToolStripMenuItem
            // 
            this.thôngTinGiaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.phiếuNhậpToolStripMenuItem,
            this.phiếuYêuCầuToolStripMenuItem,
            this.phiếuThanhToánToolStripMenuItem});
            this.thôngTinGiaoDịchToolStripMenuItem.Name = "thôngTinGiaoDịchToolStripMenuItem";
            this.thôngTinGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinGiaoDịchToolStripMenuItem.Text = "Thông tin giao dịch";
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuToolStripMenuItem,
            this.kiểmKhoToolStripMenuItem});
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // saoLưuKhôiPhụcToolStripMenuItem
            // 
            this.saoLưuKhôiPhụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.khôiPhụcToolStripMenuItem});
            this.saoLưuKhôiPhụcToolStripMenuItem.Name = "saoLưuKhôiPhụcToolStripMenuItem";
            this.saoLưuKhôiPhụcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saoLưuKhôiPhụcToolStripMenuItem.Text = "Sao lưu / khôi phục";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saoLưuToolStripMenuItem.Text = "Sao lưu";
            // 
            // khôiPhụcToolStripMenuItem
            // 
            this.khôiPhụcToolStripMenuItem.Name = "khôiPhụcToolStripMenuItem";
            this.khôiPhụcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.khôiPhụcToolStripMenuItem.Text = "Khôi phục";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // phiếuYêuCầuToolStripMenuItem
            // 
            this.phiếuYêuCầuToolStripMenuItem.Name = "phiếuYêuCầuToolStripMenuItem";
            this.phiếuYêuCầuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phiếuYêuCầuToolStripMenuItem.Text = "Phiếu yêu cầu";
            // 
            // phiếuThanhToánToolStripMenuItem
            // 
            this.phiếuThanhToánToolStripMenuItem.Name = "phiếuThanhToánToolStripMenuItem";
            this.phiếuThanhToánToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phiếuThanhToánToolStripMenuItem.Text = "Phiếu thanh toán";
            // 
            // lậpPhiếuToolStripMenuItem
            // 
            this.lậpPhiếuToolStripMenuItem.Name = "lậpPhiếuToolStripMenuItem";
            this.lậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lậpPhiếuToolStripMenuItem.Text = "Lập phiếu";
            // 
            // kiểmKhoToolStripMenuItem
            // 
            this.kiểmKhoToolStripMenuItem.Name = "kiểmKhoToolStripMenuItem";
            this.kiểmKhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiểmKhoToolStripMenuItem.Text = "Kiểm kho";
            // 
            // bánHàngToolStripMenuItem1
            // 
            this.bánHàngToolStripMenuItem1.Name = "bánHàngToolStripMenuItem1";
            this.bánHàngToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bánHàngToolStripMenuItem1.Text = "Bán hàng";
            // 
            // quảnLýBànToolStripMenuItem
            // 
            this.quảnLýBànToolStripMenuItem.Name = "quảnLýBànToolStripMenuItem";
            this.quảnLýBànToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýBànToolStripMenuItem.Text = "Quản lý bàn";
            // 
            // Dashboard_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.pnlMenuForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_GUI_Load);
            this.pnlMenuForm.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlUserLayout.ResumeLayout(false);
            this.padUserButton.ResumeLayout(false);
            this.padUserInfo.ResumeLayout(false);
            this.padUserInfo.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuForm;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnSignOut_Bar;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnHide;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnSignOut_Menu;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlUserLayout;
        private System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblCv;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnUser;
        private System.Windows.Forms.Panel padUserInfo;
        private System.Windows.Forms.Panel padUserButton;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem khoa123ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tai123ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGiaoDịchToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnImport;
        private Bunifu.Framework.UI.BunifuFlatButton btnBill;
        private Bunifu.Framework.UI.BunifuFlatButton btnTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnSale;
        private Bunifu.Framework.UI.BunifuFlatButton btnReport;
        private Bunifu.Framework.UI.BunifuFlatButton btnStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnProvider;
        private Bunifu.Framework.UI.BunifuFlatButton btnProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnBackup;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoLưuKhôiPhụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khôiPhụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuYêuCầuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuThanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}

