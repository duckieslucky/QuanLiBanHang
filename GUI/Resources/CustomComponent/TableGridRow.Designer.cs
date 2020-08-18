namespace GUI.Resources.CustomComponent
{
    partial class TableGridRow
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
            this.pad = new Guna.UI.WinForms.GunaLinePanel();
            this.lblMaHd = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenBan = new Guna.UI.WinForms.GunaLabel();
            this.lblCheckin = new Guna.UI.WinForms.GunaLabel();
            this.lblTrangthai = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.pad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.Color.White;
            this.pad.Controls.Add(this.lblMaHd);
            this.pad.Controls.Add(this.gunaLabel6);
            this.pad.Controls.Add(this.btnXem);
            this.pad.Controls.Add(this.lblTenBan);
            this.pad.Controls.Add(this.lblCheckin);
            this.pad.Controls.Add(this.lblTrangthai);
            this.pad.Controls.Add(this.gunaLabel2);
            this.pad.Controls.Add(this.gunaLabel1);
            this.pad.Controls.Add(this.lblName);
            this.pad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pad.LineColor = System.Drawing.Color.Black;
            this.pad.LineLeft = 5;
            this.pad.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pad.Location = new System.Drawing.Point(0, 0);
            this.pad.Name = "pad";
            this.pad.Padding = new System.Windows.Forms.Padding(5);
            this.pad.Size = new System.Drawing.Size(280, 95);
            this.pad.TabIndex = 20;
            // 
            // lblMaHd
            // 
            this.lblMaHd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaHd.AutoSize = true;
            this.lblMaHd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHd.Location = new System.Drawing.Point(91, 2);
            this.lblMaHd.Name = "lblMaHd";
            this.lblMaHd.Size = new System.Drawing.Size(55, 17);
            this.lblMaHd.TabIndex = 18;
            this.lblMaHd.Text = "HD0023";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(13, 5);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(74, 13);
            this.gunaLabel6.TabIndex = 17;
            this.gunaLabel6.Text = "Mã hóa đơn:";
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.CheckedState.Parent = this.btnXem;
            this.btnXem.CustomImages.Parent = this.btnXem;
            this.btnXem.FillColor = System.Drawing.Color.Green;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.HoverState.Parent = this.btnXem;
            this.btnXem.Location = new System.Drawing.Point(193, 26);
            this.btnXem.Name = "btnXem";
            this.btnXem.ShadowDecoration.Parent = this.btnXem;
            this.btnXem.Size = new System.Drawing.Size(79, 62);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem thông tin";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBan.Location = new System.Drawing.Point(91, 72);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(51, 17);
            this.lblTenBan.TabIndex = 14;
            this.lblTenBan.Text = "Bàn A3";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(91, 47);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(78, 17);
            this.lblCheckin.TabIndex = 13;
            this.lblCheckin.Text = "12:22:00 PM";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.Location = new System.Drawing.Point(91, 23);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(96, 17);
            this.lblTrangthai.TabIndex = 12;
            this.lblTrangthai.Text = "Đã thanh toán";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(13, 75);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 13);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Bàn sử dụng:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(13, 50);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 13);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Thời gian:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Trạng thái:";
            // 
            // TableGridRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pad);
            this.Name = "TableGridRow";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(280, 98);
            this.pad.ResumeLayout(false);
            this.pad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLinePanel pad;
        private Guna.UI.WinForms.GunaLabel lblMaHd;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI.WinForms.GunaLabel lblTenBan;
        private Guna.UI.WinForms.GunaLabel lblCheckin;
        private Guna.UI.WinForms.GunaLabel lblTrangthai;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblName;
    }
}
