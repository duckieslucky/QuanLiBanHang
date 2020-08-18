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
using BUL.Methods;

namespace GUI.Staff
{
    public partial class Provider_Staff : ChildForm
    {
        private List<SanPham_DTO> lSanpham;
        private List<CTyeucau_DTO> lRequest;
        private BindingSource requestSource;
        public Provider_Staff()
        {
            InitializeComponent();
        }

        private void Provider_Staff_Load(object sender, EventArgs e)
        {
            //default set
            dgvSP.AutoGenerateColumns = false;
            dgvRequest.AutoGenerateColumns = false;
            Helper_GUI.Set_CurrencyVN_Grid(dgvSP, "giagoc");

            //load info
            Reload();
            Load_Filter();

            //load data
            lSanpham = SanPhamBUL.Instance.Retrieve();
            dgvSanPham_Load(lSanpham);

            //binding
            lRequest = new List<CTyeucau_DTO>();
            requestSource = new BindingSource()
            {
                DataSource = lRequest
            };
            dgvRequest.DataSource = requestSource;
        }

        //methods


        private void Load_Filter()
        {
            Dictionary<string, int> options = new Dictionary<string, int>();
            options.Add("Xem tất cả", 1000);
            options.Add("Dưới 50", 50);
            options.Add("Dưới 20", 20);
            options.Add("Dưới 10", 10);
            options.Add("Hết hàng", 0);
            cbxFilter.DataSource = new BindingSource(options, null);
            cbxFilter.DisplayMember = "Key";
            cbxFilter.ValueMember = "Value";
        }

        private void Reload()
        {
            lblIdPhieu.Text = "#" + YeuCauBUL.Instance.Get_NewId();
            lblNv.Text = User.FullName;
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            tbxNote.Clear();
        }

        //events
        private void dgvSanPham_Load(List<SanPham_DTO> DataSource)
        {
            dgvSP.DataSource = DataSource;

            
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var sp = dgvSP.CurrentRow.DataBoundItem as SanPham_DTO;
                if(lRequest.Find(s=>s.IdSanPham == sp.Id) == null)
                {
                    requestSource.Add(new CTyeucau_DTO()
                    {
                        IdSanPham = sp.Id,
                        //view
                        TenSanPham = sp.Ten,
                        Dvt = sp.Dvt
                    });
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            requestSource.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(requestSource.Count == 0)
            {
                MessageBox.Show("Lựa chọn hàng cần yêu cầu nhập");
                return;
            }
            YeuCau_DTO yc = new YeuCau_DTO()
            {
                Ghichu = tbxNote.Text,
                IdNhanVien = User.UserId,
                Ngaylap = DateTime.Now,
                Trangthai = null,
            };
            bool isSuccess = YeuCauBUL.Instance.InsertYeuCau(yc, lRequest);
            if (isSuccess)
            {
                MessageBox.Show($"Đã lưu yêu cầu [Mã: {lblIdPhieu.Text}]");
                requestSource.Clear();
                Reload();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thực hiện");
            }
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var sp = dgvRequest.CurrentRow.DataBoundItem as CTyeucau_DTO;
                requestSource.Remove(sp);
            }
        }

        private void cbxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int limit = (int)cbxFilter.SelectedValue;
            dgvSP.DataSource = lSanpham.FindAll(s => s.Soluong <= limit);
        }
    }
}
