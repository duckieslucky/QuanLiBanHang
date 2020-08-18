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

namespace GUI.Staff
{
    public partial class KiemKho_Staff : ChildForm
    {
        private PhieuNhap_DTO phieunhap;
        private BindingSource src;
        public KiemKho_Staff()
        {
            InitializeComponent();
        }

        private void KiemKho_Staff_Load(object sender, EventArgs e)
        {
            this.dgvCT.AutoGenerateColumns = false;
            //
            Helper_GUI.Set_CurrencyVN_Grid(dgvCT, "tbxDongia");
            Helper_GUI.Set_CurrencyVN_Grid(dgvCT, "tbxThanhtien");

        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSearch.Text))
            {
                MessageBox.Show("Chưa nhập mã phiếu nhập");
                return;
            }

            phieunhap = PhieuNhapBUL.Instance.Find(tbxSearch.Text);
            
            if(phieunhap == null)
            {
                MessageBox.Show("Không tồn tại phiếu nhập", "Thông báo");
                return;
            }

            if(phieunhap.Huydon == true)
            {
                MessageBox.Show($"Đơn {phieunhap.Id} đã bị hủy", "Thông báo");
                return;
            }

            //show
            lblId.Text = phieunhap.Id;
            lblNgayLap.Text = phieunhap.ThoigianLap.ToString("dd-MM-yyyy");
            lblGhichu.Text = phieunhap.Ghichu;
            lblNhanVien.Text = NhanVienBUL.Instance.Find(phieunhap.IdNhanVien).Hoten;
            lblNCC.Text = CungCapBUL.Instance.Find(phieunhap.IdNhaCungCap).Ten;
            lblKho.Text = (phieunhap.IdNhanVienKho == null) ? "Chờ cập nhật" : NhanVienBUL.Instance.Find(phieunhap.IdNhanVienKho).Hoten; 
            lblTrangthai.Text = (phieunhap.ThoigianCapnhat == null) ? "Chờ cập nhật" : "Đã cập nhật";

            //load chitiet
            src = new BindingSource(ChiTietPhieuNhapBUL.Instance.FindList(phieunhap.Id), null);
            dgvCT.DataSource = src;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void phieunhaplTongtien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "btnGia" && e.RowIndex >= 0)
            {
                var obj = dgvCT.CurrentRow.DataBoundItem as CTphieunhap_DTO;
                dgvCT["tbxDongia", e.RowIndex].Value = SanPhamBUL.Instance.Find(obj.IdSanPham).Giagoc;
            }
        }

        private void dgvCT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "tbxDongia" && e.RowIndex >= 0)
            {
                decimal sum = (src.DataSource as List<CTphieunhap_DTO>).Sum(s => s.Thanhtien);
                lblTongtien.Text = Helper_GUI.ConvertToVNmoney(sum);
            }
        }

        private void resetForm()
        {
            phieunhap = null;
            this.lblId.Text = "xxxxxxxxPNxxx";
            this.lblTrangthai.Text = "Chờ nhận hàng";
            this.lblNhanVien.Text = "Người lập";
            this.lblNgayLap.Text = "xx/xx/xxxx";
            lblGhichu.Text = "Nội dung";
            lblKho.Text = "Người kiểm kho";
            lblNCC.Text = "Nhà cung cấp";
            lblTrangthai.Text = "Cập nhật";
            src.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToDB(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SaveToDB(true);
        }

        private void SaveToDB(bool huydon)
        {
            phieunhap.ThoigianCapnhat = DateTime.Now;
            phieunhap.IdNhanVienKho = User.UserId;
            phieunhap.Trangthai = true;
            phieunhap.Huydon = huydon;
            bool isSuccess = PhieuNhapBUL.Instance.UpdatePhieuNhap(phieunhap, src.DataSource as List<CTphieunhap_DTO>);
            if (isSuccess)
            {
                MessageBox.Show("Đã cập nhật thành công");
                resetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }



    }
}
