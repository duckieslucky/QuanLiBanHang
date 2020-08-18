namespace GUI.Resources.CustomComponent
{
    partial class MyLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyLoader));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loader = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timeFadeOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.status.Location = new System.Drawing.Point(12, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(145, 21);
            this.status.TabIndex = 0;
            this.status.Text = "Đang tải dữ liệu...";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.message.Location = new System.Drawing.Point(13, 41);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(119, 13);
            this.message.TabIndex = 1;
            this.message.Text = "Vui lòng đợi cập nhật";
            // 
            // btnCancel
            // 
            this.btnCancel.Active = false;
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Hủy";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(214, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(66, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // loader
            // 
            this.loader.animated = true;
            this.loader.animationIterval = 1;
            this.loader.animationSpeed = 1;
            this.loader.BackColor = System.Drawing.Color.White;
            this.loader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loader.BackgroundImage")));
            this.loader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.loader.ForeColor = System.Drawing.Color.SeaGreen;
            this.loader.LabelVisible = false;
            this.loader.LineProgressThickness = 5;
            this.loader.LineThickness = 4;
            this.loader.Location = new System.Drawing.Point(97, 63);
            this.loader.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.loader.MaxValue = 100;
            this.loader.Name = "loader";
            this.loader.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.loader.ProgressColor = System.Drawing.Color.SeaGreen;
            this.loader.Size = new System.Drawing.Size(105, 105);
            this.loader.TabIndex = 18;
            this.loader.Value = 30;
            // 
            // timeFadeOut
            // 
            this.timeFadeOut.Interval = 1;
            this.timeFadeOut.Tick += new System.EventHandler(this.timeFadeOut_Tick);
            // 
            // MyLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 214);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyLoader";
            this.Text = "MyLoader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar loader;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuCustomLabel message;
        private Bunifu.Framework.UI.BunifuCustomLabel status;
        private System.Windows.Forms.Timer timeFadeOut;
    }
}