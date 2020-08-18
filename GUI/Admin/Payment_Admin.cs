using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Users;
using DTO;
using BUL;
using GUI.Resources;

namespace GUI.Admin
{
    public partial class Payment_Admin : ChildForm
    {
        PhieuNhap_DTO phieunhap;
        public Payment_Admin()
        {
            InitializeComponent();
        }

        private void Payment_Admin_Load(object sender, EventArgs e)
        {
            //default
            tbxSotien_tt.Enabled = false;
            this.dgvPN.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvPN, "tbxTienno");
            this.dgvCT.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvCT, "dongia");
            Helper_GUI.Set_CurrencyVN_Grid(dgvCT, "thanhtien");
            this.dgvTrans.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvTrans, "colSotien");

            //bul
            List<CungCap_DTO> temp1 = CungCapBUL.Instance.Retrieve();
            temp1.Add(new CungCap_DTO()
            {
                Id = 0,
                Ten = "Xem tất cả"
            });
            cbxNCC.DataSource = temp1;
            cbxNCC.DisplayMember = "ten";
            cbxNCC.ValueMember = "id";
        }

        private void btnSearch_tt_Click(object sender, EventArgs e)
        {
            btnCancel_Click(null, null);
            if (String.IsNullOrEmpty(tbxSearch_tt.Text))
            {
                MessageBox.Show("Hãy nhập thông tin phiếu","Thông báo");
                return;
            }

            phieunhap = PhieuNhapBUL.Instance.Find(tbxSearch_tt.Text);
            if(phieunhap == null)
            {
                MessageBox.Show("Phiếu không tồn tại", "Thông báo");
                return;
            }
            //lock pay
            btnSave.Enabled = (phieunhap.Tienno == 0) ? false : true;
            
            //fill grid
            dgvTrans.DataSource = ThanhToanBUL.Instance.FindList(phieunhap.Id);

            //mainflow
            tbxSotien_tt.Enabled = true;
            lblId_tt.Text = phieunhap.Id;
            lbltime_tt.Text = DateTime.Now.Date.ToString();
            lblTienno_tt.Text = Helper_GUI.ConvertToVNmoney((decimal)phieunhap.Tienno) + " VND";
            lblUser_tt.Text = User.FullName;
        }

        private void tbxSotien_tt_Validated(object sender, EventArgs e)
        {
            
        }

        private void tbxSotien_tt_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            phieunhap = null;
            tbxSotien_tt.Enabled = false;
            tbxSotien_tt.Clear();
            lblId_tt.ResetText();
            lbltime_tt.ResetText();
            lblTienno_tt.ResetText();
            lblUser_tt.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(phieunhap == null)
            {
                MessageBox.Show("Chưa kiểm tra hóa đơn", "Cảnh báo");
                return;
            }

            decimal sotien;
            if (decimal.TryParse(tbxSotien_tt.Text, out sotien))
            {
                if (sotien < 0)
                {
                    MessageBox.Show("Số tiền không hợp lệ", "Cảnh báo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Số tiền không hợp lệ", "Cảnh báo");
                return;
            }

            ThanhToan_DTO tt = new ThanhToan_DTO()
            {
                IdNhanVien = User.UserId,
                Sotien = sotien,
                IdPhieu = phieunhap.Id,
            };
            if (ThanhToanBUL.Instance.InsertThanhToan(tt))
            {
                MessageBox.Show($"Đã thanh toán cho phiếu: {tt.IdPhieu}" + Environment.NewLine + "Số tiền: " + Helper_GUI.ConvertToVNmoney(sotien) + " VND", "Thông báo");
                //next pay
                tbxSearch_tt.Text = phieunhap.Id;
                btnCancel_Click(null, null);
                btnSearch_tt_Click(null, null);
                
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống", "Cảnh báo");
            }
        }

        private void cbxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLocNCC_Click(object sender, EventArgs e)
        {
            int id = (int)cbxNCC.SelectedValue;
            if (id == 0)
            {
                dgvPN.DataSource = PhieuNhapBUL.Instance.UPD_LayPhieuNhapConNo();
            }
            else
            {
                dgvPN.DataSource = PhieuNhapBUL.Instance.UPD_LayPhieuNhapConNo(id);
            }
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnXemCT" && e.RowIndex >= 0)
            {
                var pn = dgvPN.CurrentRow.DataBoundItem as PhieuNhap_DTO;
                XemThongTin(pn);
                tabGroup.SelectedTab = tabThongtin;
            }
        }

        private void XemThongTin(PhieuNhap_DTO phieunhap)
        {
            lblId.Text = phieunhap.Id;
            lblNgayLap.Text = phieunhap.ThoigianLap.ToString("dd-MM-yyyy");
            lblGhichu.Text = phieunhap.Ghichu;
            lblNhanVien.Text = NhanVienBUL.Instance.Find(phieunhap.IdNhanVien).Hoten;
            lblNCC.Text = CungCapBUL.Instance.Find(phieunhap.IdNhaCungCap).Ten;
            lblKho.Text = (phieunhap.IdNhanVienKho == null) ? "Chờ cập nhật" : NhanVienBUL.Instance.Find(phieunhap.IdNhanVienKho).Hoten;
            lblTrangthai.Text = (phieunhap.ThoigianCapnhat == null) ? "Chờ cập nhật" : "Đã cập nhật";
            lblTongtien.Text = Helper_GUI.ConvertToVNmoney((decimal)phieunhap.Tongtien);
            lblTienno.Text = Helper_GUI.ConvertToVNmoney((decimal)phieunhap.Tienno) + " VND";
            //load chitiet
            dgvCT.DataSource = ChiTietPhieuNhapBUL.Instance.FindList(phieunhap.Id);
        }
    }
}
