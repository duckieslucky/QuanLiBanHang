using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Resources.CustomComponent
{
    public partial class ShippingForm : Form
    {
        public ViewBill parent;
        public ShippingForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            parent.shipping += $"Tên khách hàng: " + tbxTen.Text + Environment.NewLine;
            parent.shipping += $"Liên lạc: " + tbxSDT.Text + Environment.NewLine;
            parent.shipping += $"Địa chỉ: " + tbxDiaChi.Text + Environment.NewLine;
            MessageBox.Show("Đã lưu thông tin giao hàng !", "Thông báo");
            this.Close();
        }
    }
}
