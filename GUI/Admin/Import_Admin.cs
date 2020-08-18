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
    public partial class Import_Admin : ChildForm
    {
        PhieuNhap_DTO phieunhap;
        private List<CTphieunhap_DTO> yeucau;
        private BindingSource source;

        public Import_Admin()
        {
            InitializeComponent();
        }

        private void Provider_Full_Load(object sender, EventArgs e)
        {
            Payment_Admin_Load(null, null);
            Provider_Admin_Load(null, null);
        }

       


        #region Provider
        

        private void Provider_Admin_Load(object sender, EventArgs e)
        {
            //UI set
            rdbUnchecked.Checked = true;
            dgvSP.AutoGenerateColumns = false;
            dgvYC.AutoGenerateColumns = false;
            dgvCT.AutoGenerateColumns = dgvChiTiet.AutoGenerateColumns = false;
            cbxMenuCon.DisplayMember = "Ten";
            cbxMenuCon.ValueMember = "Id";
            Helper_GUI.Set_DatetimeVN_Grid(dgvYC, "tbxNgaylap");

            //Data set
            //binding
            yeucau = new List<CTphieunhap_DTO>();
            source = new BindingSource(yeucau, null);
            dgvChiTiet.DataSource = source;
            New_PhieuNhap();

            //BUL call
            dgvSP.DataSource = SanPhamBUL.Instance.Retrieve();
            dgvCT.DataSource = YeuCauBUL.Instance.UPD_LayYeuCau_TheoNgay(rdbChecked.Checked);
            lblNVlapphieu.Text = User.FullName;

            //cbx menucon
            var temp2 = MenuConBUL.Instance.Retrieve();
            temp2.Add(new MenuCon_DTO() { Id = -1, Ten = "Tất cả" });
            cbxMenuCon.DataSource = temp2;
            cbxMenuCon.SelectedValue = -1;

            //cbx NhaCungCap
            cbxNCC.DataSource = CungCapBUL.Instance.Retrieve();
            cbxNCC.DisplayMember = "ten";
            cbxNCC.ValueMember = "id";
        }

        #region Methods

        private void Display_ChiTiet(YeuCau_DTO yeucau)
        {
            btnChecked.Enabled = !(bool)yeucau.Trangthai;
            btnChecked.Text = (bool)yeucau.Trangthai ? "Đã duyệt" : "Duyệt đơn";
            lblMa.Text = yeucau.Id;
            lblNgaylap.Text = yeucau.Ngaylap.ToString("dd/MM/yyyy");
            lblNoidung.Text = yeucau.Ghichu;
            lblNhanvien.Text = NhanVienBUL.Instance.Find(yeucau.IdNhanVien).Hoten;
            dgvCT.DataSource = SanPhamBUL.Instance.UPD_LayDanhSachSanPham_YeuCapNhap_TheoMaphieu(yeucau.Id);
            tabGroup.SelectedTab = tabCT;
        }

        private void Add_YeuCau(SanPham_DTO sp)
        {
            var dup = yeucau.Find(s => s.IdSanPham == sp.Id);
            if (dup != null)
            {
                MessageBox.Show("Sản phẩm đã tồn tại");
                return;
            }

            source.Add(new CTphieunhap_DTO()
            {
                IdPhieu = string.Empty,
                IdSanPham = sp.Id,
                Dongia = 0,
                Soluong = 1,
                TenSanPham = sp.Ten
            });
        }

        private void New_PhieuNhap()
        {
            lblIdlapphieu.Text = PhieuNhapBUL.Instance.Get_NewId();
            lblNgaylapphieu.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
            tbxGhichu.Clear();
            source.Clear();
        }

        #endregion

        #region tab YeuCau
        private void cbxFilterYC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxFilterYC.SelectedIndex;
            switch (index)
            {
                case 0://day
                    dgvYC.DataSource = YeuCauBUL.Instance.UPD_LayYeuCau_TheoNgay(rdbChecked.Checked);
                    break;
                case 1://week
                    dgvYC.DataSource = YeuCauBUL.Instance.UPD_LayYeuCau_TheoTuan(rdbChecked.Checked);
                    break;
                case 2://month
                    dgvYC.DataSource = YeuCauBUL.Instance.UPD_LayYeuCau_TheoThang(rdbChecked.Checked);
                    break;
                default:
                    dgvYC.DataSource = YeuCauBUL.Instance.UPD_LayYeuCau_TheoNgay(rdbChecked.Checked);
                    break;
            }
        }

        private void rdbChecked_CheckedChanged(object sender, EventArgs e)
        {
            cbxFilterYC_SelectedIndexChanged(null, null);
        }

        private void rdbUnchecked_CheckedChanged(object sender, EventArgs e)
        {
            cbxFilterYC_SelectedIndexChanged(null, null);
        }

        private void dgvYC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnXemCT" && e.RowIndex >= 0)
            {
                var phieu = dgvYC.CurrentRow.DataBoundItem as YeuCau_DTO;
                Display_ChiTiet(phieu);
            }
        }
        #endregion

        #region tab ChiTiet
        private void btnChecked_Click(object sender, EventArgs e)
        {
            var obj = YeuCauBUL.Instance.Find(lblMa.Text);
            obj.Trangthai = true;
            bool isSuccess = YeuCauBUL.Instance.UpdateYeuCau(obj);
            if (isSuccess)
            {
                MessageBox.Show("Đã duyệt phiếu yêu cầu: " + obj.Id);
                cbxFilterYC_SelectedIndexChanged(null, null);
                Display_ChiTiet(YeuCauBUL.Instance.Find(lblMa.Text));
            }
            else
            {
                MessageBox.Show("Lỗi không thể thực hiện duyệt !!");
            }
        }

        #endregion

        #region tab SanPham

        private void cbxMenuCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = (int)cbxMenuCon.SelectedValue;
            switch (value)
            {
                case -1:
                    dgvSP.DataSource = SanPhamBUL.Instance.Retrieve();
                    break;
                default:
                    dgvSP.DataSource = SanPhamBUL.Instance.Retrieve(value);
                    break;
            }
        }



        #endregion


        private void dgvCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnThem" && e.RowIndex >= 0)
            {
                var sp = dgvCT.CurrentRow.DataBoundItem as SanPham_DTO;
                Add_YeuCau(sp);
            }
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnThem1" && e.RowIndex >= 0)
            {
                var sp = dgvSP.CurrentRow.DataBoundItem as SanPham_DTO;
                Add_YeuCau(sp);
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnXoa" && e.RowIndex >= 0)
            {
                var sp = dgvChiTiet.CurrentRow.DataBoundItem as CTphieunhap_DTO;
                source.Remove(sp);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (source.Count < 1)
            {
                MessageBox.Show("Chưa yêu cầu sản phẩm cần nhập !", "Thông báo");
                return;
            }

            //
            PhieuNhap_DTO pn = new PhieuNhap_DTO()
            {
                Id = PhieuNhapBUL.Instance.Get_NewId(),
                ThoigianLap = Convert.ToDateTime(lblNgaylap.Text),
                ThoigianCapnhat = null,
                Trangthai = false,
                Tongtien = null,
                Tienno = null,
                Ghichu = tbxGhichu.Text,
                Huydon = false,
                IdNhanVien = User.UserId,
                IdNhaCungCap = (int)cbxNCC.SelectedValue,
                IdNhanVienKho = null,
            };
            bool isSuccess = PhieuNhapBUL.Instance.InsertPhieuNhap(pn, yeucau);
            if (isSuccess)
            {
                MessageBox.Show("Đã thêm phiếu nhập");
                New_PhieuNhap();
            }
            else
            {
                MessageBox.Show("Lỗi !!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            New_PhieuNhap();
        }

        #endregion


        #region payment
        private void Payment_Admin_Load(object sender, EventArgs e)
        {
            //default
            tbxSotien_tt.Enabled = false;
            this.dgvPN.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvPN, "tbxTienno");
            this.dgvCTSP.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvCTSP, "dongia");
            Helper_GUI.Set_CurrencyVN_Grid(dgvCTSP, "thanhtien");
            this.dgvTrans.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvTrans, "colSotien");

            //bul
            List<CungCap_DTO> temp1 = CungCapBUL.Instance.Retrieve();
            temp1.Add(new CungCap_DTO()
            {
                Id = 0,
                Ten = "Xem tất cả"
            });
            cbxNCC_2.DataSource = temp1;
            cbxNCC_2.DisplayMember = "ten";
            cbxNCC_2.ValueMember = "id";
        }

        private void btnSearch_tt_Click(object sender, EventArgs e)
        {
            btnCancel_TT_Click(null, null);
            if (String.IsNullOrEmpty(tbxSearch_tt.Text))
            {
                MessageBox.Show("Hãy nhập thông tin phiếu", "Thông báo");
                return;
            }

            phieunhap = PhieuNhapBUL.Instance.Find(tbxSearch_tt.Text);
            if (phieunhap == null)
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

        private void btnCancel_TT_Click(object sender, EventArgs e)
        {
            phieunhap = null;
            tbxSotien_tt.Enabled = false;
            tbxSotien_tt.Clear();
            lblId_tt.ResetText();
            lbltime_tt.ResetText();
            lblTienno_tt.ResetText();
            lblUser_tt.ResetText();
        }

        private void btnSave_TT_Click(object sender, EventArgs e)
        {
            if (phieunhap == null)
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
            int id = (int)cbxNCC_2.SelectedValue;
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

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnXemCT_2" && e.RowIndex >= 0)
            {
                var pn = dgvPN.CurrentRow.DataBoundItem as PhieuNhap_DTO;
                XemThongTin(pn);
                tabGroup_2.SelectedTab = tabThongtin;
            }
        }

        private void XemThongTin(PhieuNhap_DTO phieunhap)
        {
            lblId.Text = phieunhap.Id;
            lblNgayLap2.Text = phieunhap.ThoigianLap.ToString("dd-MM-yyyy");
            lblGhichu.Text = phieunhap.Ghichu;
            lblNhanVien2.Text = NhanVienBUL.Instance.Find(phieunhap.IdNhanVien).Hoten;
            lblNCC.Text = CungCapBUL.Instance.Find(phieunhap.IdNhaCungCap).Ten;
            lblKho.Text = (phieunhap.IdNhanVienKho == null) ? "Chờ cập nhật" : NhanVienBUL.Instance.Find(phieunhap.IdNhanVienKho).Hoten;
            lblTrangthai.Text = (phieunhap.ThoigianCapnhat == null) ? "Chờ cập nhật" : "Đã cập nhật";
            lblTongtien.Text = Helper_GUI.ConvertToVNmoney((decimal)phieunhap.Tongtien);
            lblTienno.Text = Helper_GUI.ConvertToVNmoney((decimal)phieunhap.Tienno) + " VND";
            //load chitiet
            dgvCTSP.DataSource = ChiTietPhieuNhapBUL.Instance.FindList(phieunhap.Id);
        }

        #endregion
    }
}
