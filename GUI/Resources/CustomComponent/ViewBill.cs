using BUL;
using DTO;
using GUI.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuDataGridView.Transitions;

namespace GUI.Resources.CustomComponent
{
    public partial class ViewBill : Form
    {
        public Order_Staff parent;

        private List<CThoadon_DTO> lChitiet;
        private int sale = 0;
        private HoaDon_DTO hoadon;
        public string shipping;
        public Ban_DTO ban;

        public ViewBill()
        {
            InitializeComponent();
        }

        private void ViewBill_Load(object sender, EventArgs e)
        {
            //get data from parent form
            lChitiet = parent.lChitiet;
            sale = Convert.ToInt32(parent.tbxSale.Text);

            hoadon = new HoaDon_DTO()
            {
                Id = HoaDonBUL.Instance.Get_NewId(),
                Checkin = DateTime.Now,
                Giamgia = sale,
                Tongtien = lChitiet.Sum(s => s.Thanhtien),
            };
            
            tbxTime.Text = hoadon.Checkin.ToString("dd-MM-yyyy hh:mm:ss tt");
            tbxSale.Text = parent.tbxSale.Text + " %";
            rdbTructiep.Checked = true;
            dgv.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgv, "dongia");
            Helper_GUI.Set_CurrencyVN_Grid(dgv, "thanhtien");

            Load_HoaDon();
            Load_ListChitiet();
        }

        private void Load_HoaDon()
        {
            lblIdHoaDon.Text += hoadon.Id;
            tbxTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
            tbxStaff.Text = User.FullName;
            tbxSale.Text = "Tổng tiền: " + Helper_GUI.ConvertToVNmoney((decimal)hoadon.Tongtien) + " VNĐ | Giảm: " +sale.ToString() + " %";
            tbxSum.Text = Helper_GUI.ConvertToVNmoney(hoadon.Thanhtoan) + " VNĐ";
        }

        private void Create_HoaDon(bool Thanhtoan = false)
        {
            hoadon.Id = HoaDonBUL.Instance.Get_NewId();
            hoadon.IdNhanVien = User.UserId;
            //vào bul tính
            hoadon.Giamgia = sale;
            hoadon.Tongtien = null;
            hoadon.Huydon = false;
            hoadon.IdBan = null;
            if (rdbGiaohang.Checked)
            {
                hoadon.Shipping = true;
            }
            else if (rdbTaiban.Checked)
            {
                hoadon.Sudungban = true;
                if (ban != null)
                {
                    hoadon.IdBan = ban.Id;
                }
            }
            else
            {
                hoadon.Shipping = hoadon.Sudungban = false;
            }
            hoadon.Ghichu = tbxNote.Text;

            if (Thanhtoan)
            {
                hoadon.Checkout = DateTime.Now;
                hoadon.Trangthai = true;
            }
            else
            {
                hoadon.Checkout = null;
                hoadon.Trangthai = false;
            }

            //set bill for products
            lChitiet.ForEach(s => s.IdPhieu = hoadon.Id);
        }

        private void Load_ListChitiet()
        {
            dgv.DataSource = lChitiet;
            if (lChitiet == null)
            {
                return;
            }

            int stt = 1;
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                var ct = (dr.DataBoundItem as CThoadon_DTO);
                //set format
                dr.Cells["stt"].Value = stt;
                stt++;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTructiep_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTructiep.Checked)
            {
                tbxNote.Text = "Hóa đơn thanh toán trực tiếp";
                btnInfoShipping.Visible = btnSelectBan.Visible = false;
                btnSave.Enabled = false;
                btnCashout.Enabled = true;
            }
        }

        private void rdbGiaohang_CheckedChanged(object sender, EventArgs e)
        {
            btnInfoShipping.Visible = rdbGiaohang.Checked;
            if (rdbGiaohang.Checked)
            {
                tbxNote.Text = "Hóa đơn giao hàng";
                btnSave.Enabled = btnCashout.Enabled = rdbGiaohang.Checked;
            }
        }

        private void rdbTaiban_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectBan.Visible = rdbTaiban.Checked;
            if (rdbTaiban.Checked)
            {
                tbxNote.Text = "Hóa đơn tại bàn";
                btnSelectBan.Text = "Chọn bàn";
                btnSave.Enabled = true;
                btnCashout.Enabled = false;
            }
        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            Create_HoaDon(true);
            bool isSuccess = HoaDonBUL.Instance.Create_HoaDon(hoadon, lChitiet);
            if (isSuccess)
            {
                MessageBox.Show($"Đã thanh toán hóa đơn {hoadon.Id} !", "Thông báo");
                this.Close();
                parent.Clear_Chitiet();
                parent.Load_SanPham();
            }
            else
            {
                MessageBox.Show("Sự cố không lặp được hóa đơn");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Create_HoaDon(false);
            bool isSuccess = HoaDonBUL.Instance.Create_HoaDon(hoadon, lChitiet);
            if (isSuccess)
            {
                MessageBox.Show($"Hóa đơn {hoadon.Id} đã lưu lại !","Thông báo");
                this.Close();
                parent.Clear_Chitiet();
                parent.Load_SanPham();
            }
            else
            {
                MessageBox.Show("Sự cố không lặp được hóa đơn");
            }
        }

        private void btnInfoShipping_Click(object sender, EventArgs e)
        {
            tbxNote.Clear();
            using (ShippingForm f = new ShippingForm())
            {
                f.parent = this;
                f.ShowDialog();
            }
            tbxNote.Text += shipping;
        }

        private void btnSelectBan_Click(object sender, EventArgs e)
        {
            using (BanForm f = new BanForm())
            {
                f.parent = this;
                f.ShowDialog();
            }
            //cẩn thận null object
            btnSelectBan.Text = ban.Ten;
        }
    }
}
