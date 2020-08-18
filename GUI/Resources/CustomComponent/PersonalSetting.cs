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
    public partial class PersonalSetting : Form
    {
        public PersonalSetting()
        {
            InitializeComponent();
        }

        private void PersonalSetting_Load(object sender, EventArgs e)
        {
            this.padChange.Enabled = false;

            //load data
            lblMa.Text = "NV" + User.UserId.ToString("000");
            lblHoTen.Text = User.FullName;
            lblNgaySinh.Text = User.Info.Ngaysinh.ToString("dd/MM/yyyy");
            lblSDT.Text = User.Info.Sdt;
            lblDc.Text = User.Info.Diachi;
            lblTK.Text = User.Info.Taikhoan;
            lblCV.Text = User.Chucvu;
            lblGioitinh.Text = User.Info.Gioitinh;
            lblEmail.Text = User.Info.Email;
        }

        private void tbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxXacnhan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Hãy nhập mật khẩu hiện tại", "Cảnh báo");
                return;
            }
            if (String.IsNullOrEmpty(tbxNewPass.Text) || String.IsNullOrEmpty(tbxRePass.Text))
            {
                MessageBox.Show("Hãy điền đủ thông tin để đổi mật khẩu", "Cảnh báo");
                return;
            }

            if (tbxNewPass.Text.CompareTo(tbxRePass.Text) != 0)
            {
                MessageBox.Show("Mật khẩu mới và phần nhập lại chưa khớp", "Cảnh báo");
                return;
            }

            var isSuccess = NhanVienBUL.Instance.Login(User.Info.Taikhoan, tbxPassword.Text);
            if (isSuccess)
            {
                NhanVien_DTO nv = new NhanVien_DTO()
                {
                    Id = User.UserId,
                    Matkhau = tbxRePass.Text
                };
                if (NhanVienBUL.Instance.UpdateAccount(nv))
                {
                    MessageBox.Show("Đổi mât khẩu thành công !", "Thông báo");
                    //reset
                    tbxPassword.ResetText();
                    tbxRePass.ResetText();
                    tbxNewPass.ResetText();
                    this.padChange.Enabled = false;
                }
                else
                {
                    //lỗi sql
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hiện tại", "Cảnh báo");
                tbxPassword.Focus();
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            padChange.Enabled = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

        }
    }
}
