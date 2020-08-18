namespace GUI.Resources.CustomComponent
{
    partial class TableCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDetails = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHold = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClean = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblState = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CircleAlert = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDetail);
            this.panel1.Controls.Add(this.pnlBottom);
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 149);
            this.panel1.TabIndex = 0;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(157)))));
            this.pnlDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDetail.Controls.Add(this.lblName);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 30);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(209, 71);
            this.pnlDetail.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(10, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Bàn ???";
            this.lblName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnDetails);
            this.pnlBottom.Controls.Add(this.btnHold);
            this.pnlBottom.Controls.Add(this.btnClean);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 101);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(209, 48);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDetails.CheckedState.Parent = this.btnDetails;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetails.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDetails.HoverState.Parent = this.btnDetails;
            this.btnDetails.Image = global::GUI.Properties.Resources.magnifying_glass;
            this.btnDetails.ImageRotate = 0F;
            this.btnDetails.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDetails.Location = new System.Drawing.Point(63, 0);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDetails.PressedState.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(83, 48);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnHold
            // 
            this.btnHold.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHold.CheckedState.Parent = this.btnHold;
            this.btnHold.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHold.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnHold.HoverState.Parent = this.btnHold;
            this.btnHold.Image = global::GUI.Properties.Resources.calendar;
            this.btnHold.ImageRotate = 0F;
            this.btnHold.ImageSize = new System.Drawing.Size(40, 40);
            this.btnHold.Location = new System.Drawing.Point(146, 0);
            this.btnHold.Name = "btnHold";
            this.btnHold.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHold.PressedState.Parent = this.btnHold;
            this.btnHold.Size = new System.Drawing.Size(63, 48);
            this.btnHold.TabIndex = 1;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnClean
            // 
            this.btnClean.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClean.CheckedState.Parent = this.btnClean;
            this.btnClean.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClean.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClean.HoverState.Parent = this.btnClean;
            this.btnClean.Image = global::GUI.Properties.Resources.clean;
            this.btnClean.ImageRotate = 0F;
            this.btnClean.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClean.Location = new System.Drawing.Point(0, 0);
            this.btnClean.Name = "btnClean";
            this.btnClean.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClean.PressedState.Parent = this.btnClean;
            this.btnClean.Size = new System.Drawing.Size(63, 48);
            this.btnClean.TabIndex = 0;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblState);
            this.pnlTop.Controls.Add(this.CircleAlert);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(209, 30);
            this.pnlTop.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblState.Location = new System.Drawing.Point(38, 6);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(64, 19);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Bàn trống";
            // 
            // CircleAlert
            // 
            this.CircleAlert.CheckedState.Parent = this.CircleAlert;
            this.CircleAlert.CustomImages.Parent = this.CircleAlert;
            this.CircleAlert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CircleAlert.ForeColor = System.Drawing.Color.White;
            this.CircleAlert.HoverState.Parent = this.CircleAlert;
            this.CircleAlert.Location = new System.Drawing.Point(10, 8);
            this.CircleAlert.Name = "CircleAlert";
            this.CircleAlert.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleAlert.ShadowDecoration.Parent = this.CircleAlert;
            this.CircleAlert.Size = new System.Drawing.Size(15, 15);
            this.CircleAlert.TabIndex = 0;
            // 
            // TableCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "TableCard";
            this.Size = new System.Drawing.Size(209, 149);
            this.panel1.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblState;
        private Guna.UI2.WinForms.Guna2CircleButton CircleAlert;
        private Guna.UI2.WinForms.Guna2ImageButton btnClean;
        private Guna.UI2.WinForms.Guna2ImageButton btnDetails;
        private Guna.UI2.WinForms.Guna2ImageButton btnHold;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
    }
}
