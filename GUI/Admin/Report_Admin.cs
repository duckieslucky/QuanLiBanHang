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
using GUI.QLBHDataSetTableAdapters;
using GUI.Resources;
using Microsoft.Reporting.WinForms;
using BUL;
using System.IO;
using DTO;

namespace GUI.Admin
{
    public partial class Report_Admin : ChildForm
    {
        
        public Report_Admin()
        {
            InitializeComponent();
        }

        private void Report_Admin_Load(object sender, EventArgs e)
        {
            //load combobox
            cbxThang.DataSource = Helper_GUI.Get_MonthList().ToList();
            cbxNam.DataSource = Helper_GUI.Get_YearList().ToList();
            cbxThang.DisplayMember = cbxNam.DisplayMember = "Key";
            cbxThang.ValueMember = cbxNam.ValueMember = "Value";

            cbxHoadon_SelectedIndexChanged(null, null);

            cbxDT_nam.DataSource = Helper_GUI.Get_YearList().ToList();
            cbxDT_nam.DisplayMember = "Key";
            cbxDT_nam.ValueMember = "Value";

            cbxNV_chucvu.DataSource = ChucVuBUL.Instance.Retrieve();
            cbxNV_chucvu.DisplayMember = "Ten";
            cbxNV_chucvu.ValueMember = "Id";
        }

        private void switcher_CheckedChanged(object sender, EventArgs e)
        {
            padToolHD.Visible = !switcher.Checked;
        }

        #region HoaDon
        private void cbxHoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op = cbxHoadon.SelectedIndex;
            padr1.Visible = padr2.Visible = padr3.Visible = false;
            switch (op)
            {
                case 0:
                    padr3.Visible = true;
                    break;
                case 1:
                    padr2.Visible = true;
                    break;
                case 2:
                    padr1.Visible = true;
                    break;
                default:
                    padr3.Visible = true;
                    break;
            }
        }

        #endregion

        #region SanPham

        #endregion

        #region DoanhThu
        private void btnDT_theongay_Click(object sender, EventArgs e)
        {
            Report_DTO src = ReporterBUL.Instance.UDP_DoanhThuTheoNgay(dpDT_start.Value, dpDT_end.Value);
            Helper_GUI.Load_LocalReport(rp_Doanhthu, src);
        }

        private void btnDT_theothang_Click(object sender, EventArgs e)
        {
            int month = cbxDT_thang.SelectedIndex;
            Report_DTO src = null;
            switch (month)
            {
                case 0:
                    src = ReporterBUL.Instance.UPD_DoanhThuTheoNam((int)cbxDT_nam.SelectedValue);
                    break;
                default:
                    src = ReporterBUL.Instance.UPD_DoanhThuTheoThang(month, (int)cbxDT_nam.SelectedValue);
                    break;
            }
            Helper_GUI.Load_LocalReport(rp_Doanhthu, src);
        }


        #endregion //bổ sung

        #region NhanVien

        #endregion

        #region PhieuNhap

        #endregion

        private void btnNV_chucvu_Click(object sender, EventArgs e)
        {
            Helper_GUI.Load_LocalReport(rp_Nhanvien, ReporterBUL.Instance.UPD_LayDanhSachNhanVien_ChucVu(cbxNV_chucvu.SelectedItem as ChucVu_DTO));
        }

        private void btnNV_manv_Click(object sender, EventArgs e)
        {
            int id;
            if(int.TryParse(tbxNV_manv.Text, out id))
            {
                Helper_GUI.Load_LocalReport(rp_Nhanvien, ReporterBUL.Instance.UPD_LayThongTinNhanVien(id));
            }
        }

        private void cbxNV_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Hoadon_Click(object sender, EventArgs e)
        {
            int index = cbxHoadon.SelectedIndex;
            switch (index)
            {
                case 0:
                    Helper_GUI.Load_LocalReport(rp_Hoadon, ReporterBUL.Instance.UDP_ReportHoaDonByRangeDate(timeStart.Value, timeEnd.Value));
                    break;
                case 1:
                    //Helper_GUI.Load_LocalReport(rp_Hoadon, ReporterBUL.Instance.up);
                    break;
                case 2:
                    break;
            }
        }
    }
}
