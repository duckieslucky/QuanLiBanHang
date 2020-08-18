using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI.Resources.CustomComponent
{
    public partial class TableGridRow : UserControl
    {
        public TableGridRow(HoaDon_DTO hd)
        {
            InitializeComponent();
            this.Tag = hd;
            lblMaHd.Text = hd.Id;
            lblCheckin.Text = hd.Checkin.ToString("hh:mm:ss tt");
            lblTenBan.Text = hd.IdBan==null ? "Chưa cập nhật" : hd.Tenban;
            lblTrangthai.Text = hd.Trangthai ? "Đã thanh toán" : "Chưa thanh toán";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            MessageBox.Show((this.Tag as HoaDon_DTO).IdBan.ToString());
        }
    }
}
