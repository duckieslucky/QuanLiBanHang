using BUL;
using DTO;
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
    public partial class FastViewBill : Form
    {
        private HoaDon_DTO hoadon;
        private List<CThoadon_DTO> ds = null;
        public FastViewBill(HoaDon_DTO imHoadon)
        {
            InitializeComponent();
            this.hoadon = imHoadon;
        }

        private void FastViewBill_Load(object sender, EventArgs e)
        {
            this.Size = this.MinimumSize;
            this.dgv.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgv, "dongia");
            Helper_GUI.Set_CurrencyVN_Grid(dgv, "thanhtien");
            Load_HoaDon();
            
        }

        private void Load_HoaDon()
        {
            if (hoadon.Trangthai)
            {
                btnCashout.Text = "Đã thanh toán";
                btnCashout.Enabled = false;
            }
            lblMahd.Text = hoadon.Id;
            tbxStaff.Text = hoadon.TenNhanVien;
            tbxTime.Text = hoadon.Checkin.ToString("dd-MM-yyyy hh:mm:ss tt");
            tbxSale.Text = hoadon.Giamgia.ToString("00") + "%";
            tbxSum.Text = Helper_GUI.ConvertToVNmoney(hoadon.Thanhtoan) + " VNĐ";
            if (hoadon.Shipping)
            {
                rdbGiaohang.Checked = true;
            }
            else if (hoadon.Sudungban)
            {
                rdbTaiban.Checked = true;

            }
            else
            {
                rdbTructiep.Checked = true;
            }
            tbxNote.Text = hoadon.Ghichu;
        }

        private void btnShowChitiet_Click(object sender, EventArgs e)
        {
            if(ds == null) 
            {
                var lChitiet = ChiTietHoaDonBUL.Instance.FindList(hoadon.Id);
                
                dgv.DataSource = lChitiet;
                if (lChitiet == null)
                {
                    return;
                }
            }
            

            //resize form
            this.Size = this.MaximumSize;
        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            bool isSuccess = HoaDonBUL.Instance.ThanhToan(hoadon.Id);
            if (isSuccess)
            {
                MessageBox.Show($"Đã thanh toán hóa đơn: {hoadon.Id}");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.Size = this.MinimumSize;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
