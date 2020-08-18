namespace GUI.Resources.CustomComponent
{
    partial class FoodGridRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodGridRow));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblPrice = new Guna.UI.WinForms.GunaLabel();
            this.lblSum = new Guna.UI.WinForms.GunaLabel();
            this.NumQuantity = new Guna.UI.WinForms.GunaNumeric();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.btnRemove = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaLinePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.Controls.Add(this.lblPrice);
            this.gunaLinePanel1.Controls.Add(this.NumQuantity);
            this.gunaLinePanel1.Controls.Add(this.lblName);
            this.gunaLinePanel1.Controls.Add(this.btnRemove);
            this.gunaLinePanel1.Controls.Add(this.tableLayoutPanel1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(388, 68);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(54, 35);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(15, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(3, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(64, 16);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "0";
            // 
            // NumQuantity
            // 
            this.NumQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NumQuantity.BaseColor = System.Drawing.Color.White;
            this.NumQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.NumQuantity.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.NumQuantity.ButtonForeColor = System.Drawing.Color.White;
            this.NumQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NumQuantity.ForeColor = System.Drawing.Color.Black;
            this.NumQuantity.Location = new System.Drawing.Point(216, 19);
            this.NumQuantity.Maximum = ((long)(99));
            this.NumQuantity.Minimum = ((long)(1));
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Radius = 4;
            this.NumQuantity.Size = new System.Drawing.Size(57, 30);
            this.NumQuantity.TabIndex = 3;
            this.NumQuantity.Text = "gunaNumeric1";
            this.NumQuantity.Value = ((long)(1));
            this.NumQuantity.ValueChanged += new System.EventHandler(this.NumQuantity_ValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(54, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Pasta in Tomato Sauce";
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BackgroundImage = global::GUI.Properties.Resources.remove;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.BaseColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRemove.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRemove.CheckedForeColor = System.Drawing.Color.White;
            this.btnRemove.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.CheckedImage")));
            this.btnRemove.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = null;
            this.btnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemove.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRemove.Location = new System.Drawing.Point(12, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Size = new System.Drawing.Size(33, 26);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblSum, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(303, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(70, 16);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FoodGridRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "FoodGridRow";
            this.Size = new System.Drawing.Size(388, 68);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaNumeric NumQuantity;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaAdvenceButton btnRemove;
        private Guna.UI.WinForms.GunaLabel lblSum;
        private Guna.UI.WinForms.GunaLabel lblPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
