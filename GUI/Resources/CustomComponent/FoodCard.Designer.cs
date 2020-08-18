namespace GUI.Resources.CustomComponent
{
    partial class FoodCard
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
            this.gunaLinePanel_valid = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.lblDongia = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblTen = new Guna.UI.WinForms.GunaLabel();
            this.btnAddCart = new Guna.UI.WinForms.GunaGradientButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSoluong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gunaLinePanel_valid.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel_valid
            // 
            this.gunaLinePanel_valid.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel_valid.BackgroundImage = global::GUI.Properties.Resources.cake;
            this.gunaLinePanel_valid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaLinePanel_valid.Controls.Add(this.lblSoluong);
            this.gunaLinePanel_valid.Controls.Add(this.bunifuCustomLabel1);
            this.gunaLinePanel_valid.Controls.Add(this.gunaGradient2Panel1);
            this.gunaLinePanel_valid.Controls.Add(this.gunaShadowPanel1);
            this.gunaLinePanel_valid.Controls.Add(this.btnAddCart);
            this.gunaLinePanel_valid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel_valid.LineBottom = 3;
            this.gunaLinePanel_valid.LineColor = System.Drawing.Color.Tomato;
            this.gunaLinePanel_valid.LineLeft = 3;
            this.gunaLinePanel_valid.LineRight = 3;
            this.gunaLinePanel_valid.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel_valid.LineTop = 3;
            this.gunaLinePanel_valid.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel_valid.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLinePanel_valid.Name = "gunaLinePanel_valid";
            this.gunaLinePanel_valid.Size = new System.Drawing.Size(175, 185);
            this.gunaLinePanel_valid.TabIndex = 11;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.lblDongia);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(3, 3);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(97, 25);
            this.gunaGradient2Panel1.TabIndex = 9;
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongia.ForeColor = System.Drawing.Color.White;
            this.lblDongia.Location = new System.Drawing.Point(10, 4);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(63, 15);
            this.lblDongia.TabIndex = 0;
            this.lblDongia.Text = "$ 17.000";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaShadowPanel1.Controls.Add(this.lblTen);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(10, 39);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 4;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(155, 48);
            this.gunaShadowPanel1.TabIndex = 9;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold);
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(14, 18);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(121, 13);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Pasta sea food Dish";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCart.Animated = true;
            this.btnAddCart.AnimationHoverSpeed = 0.07F;
            this.btnAddCart.AnimationSpeed = 0.03F;
            this.btnAddCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCart.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnAddCart.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnAddCart.BorderColor = System.Drawing.Color.Black;
            this.btnAddCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.Color.White;
            this.btnAddCart.Image = null;
            this.btnAddCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddCart.Location = new System.Drawing.Point(87, 134);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddCart.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddCart.OnHoverImage = null;
            this.btnAddCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCart.Size = new System.Drawing.Size(85, 48);
            this.btnAddCart.TabIndex = 12;
            this.btnAddCart.Text = "Thêm món";
            this.btnAddCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCart.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(7, 134);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(57, 13);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Số lượng:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(23, 147);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(37, 21);
            this.lblSoluong.TabIndex = 14;
            this.lblSoluong.Text = "100";
            // 
            // FoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gunaLinePanel_valid);
            this.Name = "FoodCard";
            this.Size = new System.Drawing.Size(175, 185);
            this.gunaLinePanel_valid.ResumeLayout(false);
            this.gunaLinePanel_valid.PerformLayout();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lblTen;
        private Guna.UI.WinForms.GunaGradientButton btnAddCart;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel_valid;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel lblDongia;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSoluong;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
