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
using BUL;
using DTO;
using GUI.Resources;
using GUI.Resources.CustomComponent;

namespace GUI.Admin
{
    public partial class User_Admin : ChildForm
    {
        private CRUD_State mode;
        private BoolBinding viewState;
        private BindingSource nhanvien;
        private NhanVien_DTO newItem;

        public User_Admin()
        {
            InitializeComponent();
        }

        private void User_Admin_Load(object sender, EventArgs e)
        {
            viewState = new BoolBinding(false);
            mode = CRUD_State.View;

            this.dgvNV.AutoGenerateColumns = false;
            cbxChucvu.DisplayMember = "Ten";
            cbxChucvu.ValueMember = "Id";

            //data
            nhanvien = new BindingSource(NhanVienBUL.Instance.Retrieve(), null);
            dgvNV.DataSource = nhanvien;

            //combobox
            var temp1 = ChucVuBUL.Instance.Retrieve();
            temp1.Add(new ChucVu_DTO() { Id = null, Ten = "Thôi việc" });
            cbxChucvu.DataSource = temp1;

            //
            BindingUI();
            BindingData();
        }

        private void BindingData()
        {
            lblId.DataBindings.Add(new Binding("Text", nhanvien, "Id", true, DataSourceUpdateMode.Never));
            tbxTen.DataBindings.Add(new Binding("Text", nhanvien, "Ten", true, DataSourceUpdateMode.Never));
            tbxHo.DataBindings.Add(new Binding("Text", nhanvien, "Ho", true, DataSourceUpdateMode.Never));
            tbxDT.DataBindings.Add(new Binding("Text", nhanvien, "Sdt", true, DataSourceUpdateMode.Never));
            tbxEmail.DataBindings.Add(new Binding("Text", nhanvien, "Email", true, DataSourceUpdateMode.Never));
            tbxDC.DataBindings.Add(new Binding("Text", nhanvien, "Diachi", true, DataSourceUpdateMode.Never));
            rdbNam.DataBindings.Add(new Binding("Checked", nhanvien, "IsMan", true, DataSourceUpdateMode.Never));
            rdbNu.DataBindings.Add(new Binding("Checked", nhanvien, "IsWoman", true, DataSourceUpdateMode.Never));

            dpNS.DataBindings.Add(new Binding("Value", nhanvien, "Ngaysinh", true, DataSourceUpdateMode.Never));
            
            cbxChucvu.DataBindings.Add(new Binding("SelectedValue", nhanvien, "IdChucVu", true, DataSourceUpdateMode.Never));
        }

        private void BindingUI()
        {
            //form
            lblId.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxTen.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxHo.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxDT.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxEmail.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            tbxDC.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            rdbNam.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            rdbNu.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));
            dpNS.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));

            //button
            padBottomRight.DataBindings.Add(new Binding("Enabled", viewState, "State", true, DataSourceUpdateMode.OnPropertyChanged));

            //gridview
            dgvNV.DataBindings.Add(new Binding("Enabled", viewState, "OppState", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            if (newItem == null)
            {
                return;
            }
            newItem.Ho = tbxHo.Text;
            newItem.Ten = tbxTen.Text;
            newItem.Ngaysinh = dpNS.Value.Date;
            newItem.Gioitinh = (rdbNam.Checked) ? "Name" : "Nữ";
            newItem.Sdt = tbxDT.Text;
            newItem.Email = tbxEmail.Text;
            newItem.Diachi = tbxDC.Text;
            newItem.IdChucVu = (int?)cbxChucvu.SelectedValue;
            //new tạo mới
            newItem.Taikhoan = newItem.Email.Split('@')[0];
            newItem.Matkhau = "123";
            if (mode == CRUD_State.Insert)
            {
                isSuccess = NhanVienBUL.Instance.InsertNhanVien(newItem);
            }
            else //update
            {
                isSuccess = NhanVienBUL.Instance.UpdatePersonal(newItem);
                if(isSuccess) NhanVienBUL.Instance.UpdateChucVu(newItem);
            }

            //Notification
            if (isSuccess)
            {
                if (mode == CRUD_State.Insert)
                {
                    MessageBox.Show("Đã thêm nhân viên mới !");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật thông tin nhân viên !");
                }
                nhanvien.DataSource = NhanVienBUL.Instance.Retrieve();

                //change state
                viewState.State = false;
                mode = CRUD_State.View;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !!!", "Cảnh báo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            viewState.State = false;
            mode = CRUD_State.View;
            ClearForm();
            if (newItem != null)
            {
                newItem = null;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            viewState.State = true;
            mode = CRUD_State.Insert;
            ClearForm();
            newItem = new NhanVien_DTO();

        }

        private void ClearForm()
        {
            lblId.Text = "Tự động cập nhật";
            tbxTen.Clear();
            tbxDT.Clear();
            tbxEmail.Clear();
            tbxDC.Clear();
            rdbNam.Checked = true;
            tbxHo.Clear();
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "colCapnhat" && e.RowIndex >= 0)
            {
                viewState.State = true;
                mode = CRUD_State.Update;
                newItem = dgvNV.CurrentRow.DataBoundItem as NhanVien_DTO;
            }
        }
    }
}
