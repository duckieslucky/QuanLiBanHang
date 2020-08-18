using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Microsoft.Reporting.WinForms;

namespace BUL
{
    public class ReporterBUL
    {
        private static ReporterBUL instance;

        public static ReporterBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReporterBUL();
                }
                return instance;
            }
            private set => instance = value;
        }

        #region HoaDon

        public Report_DTO UPD_ReportHoaDonById(string idHoaDon)
        {
            return new Report_DTO()
            {
                RdlcFile = "HoaDon_Print.rdlc",
                ListTable = new List<ReportDataSource>()
                {
                    new ReportDataSource("dsHoaDon", ReporterDAL.Instance.UPD_ReportHoaDonById(idHoaDon)),
                    new ReportDataSource("dsCT_HoaDon", ChiTietHoaDonBUL.Instance.FindList(idHoaDon)),
                },
            };
        }

        public Report_DTO UDP_ReportHoaDonByRangeDate(DateTime start, DateTime end)
        {
            return new Report_DTO()
            {
                RdlcFile = "HoaDon_ChiTiet.rdlc",
                ListTable = new List<ReportDataSource>()
                {
                    new ReportDataSource("tblHoaDon", ReporterDAL.Instance.UDP_ReportHoaDonByRangeDate(start, end)),
                },
                ListPara = new List<ReportParameter>()
                {
                    new ReportParameter("title", "BÁO CÁO HÓA ĐƠN NGÀY"),
                    new ReportParameter("detail", "Từ " + start.ToString("dd/MM/yyyy") + "\t Đến " + end.ToString("dd/MM/yyyy")),
                    new ReportParameter("user", User.FullName),
                },
            };
        }

        public DataTable UDP_ReportDoanhThuByYear(string year)
        {
            return ReporterDAL.Instance.UDP_ReportDoanhThuByYear(year);
        }

        #endregion

        #region DoanhThu
        public Report_DTO UDP_DoanhThuTheoNgay(DateTime start, DateTime end)
        {
            return new Report_DTO()
            {
                RdlcFile = "DoanhThu.rdlc",
                ListTable = new List<ReportDataSource>()
                {
                    new ReportDataSource("DoanhThu", ReporterDAL.Instance.UPD_DoanhThuTheoNgay(start, end)),
                },
                ListPara = new List<ReportParameter>()
                {
                    new ReportParameter("title", "BÁO CÁO DOANH THU NGÀY"),
                    new ReportParameter("detail", "Từ " + start.ToString("dd/MM/yyyy") + "\t Đến " + end.ToString("dd/MM/yyyy")),
                    new ReportParameter("user", User.FullName),
                },
            };
        }

        public Report_DTO UPD_DoanhThuTheoThang(int month, int fullYear)
        {
            return new Report_DTO()
            {
                RdlcFile = "DoanhThu.rdlc",
                ListTable = new List<ReportDataSource>()
                {
                    new ReportDataSource("DoanhThu", ReporterDAL.Instance.UPD_DoanhThuTheoThang(month, fullYear)),
                },
                ListPara = new List<ReportParameter>()
                {
                    new ReportParameter("title", "BÁO CÁO DOANH THU THÁNG"),
                    new ReportParameter("detail", $"Doanh thu trong tháng {month.ToString("00")} năm {fullYear}"),
                    new ReportParameter("user", User.FullName),
                },
            };
        }

        public Report_DTO UPD_DoanhThuTheoNam(int fullYear)
        {
            return new Report_DTO()
            {
                RdlcFile = "DoanhThu.rdlc",
                ListTable = new List<ReportDataSource>()
                {
                    new ReportDataSource("DoanhThu", ReporterDAL.Instance.UPD_DoanhThuTheoNam(fullYear)),
                },
                ListPara = new List<ReportParameter>()
                {
                    new ReportParameter("title", "BÁO CÁO DOANH THU NĂM"),
                    new ReportParameter("detail", $"Doanh thu trong năm {fullYear}"),
                    new ReportParameter("user", User.FullName),
                },
            };
        }
        #endregion

        #region NhanVien
        public Report_DTO UPD_LayThongTinNhanVien(int id)
        {
            return new Report_DTO()
            {
                RdlcFile = "NhanVien_ChiTiet.rdlc",
                ListTable = new List<ReportDataSource>()
                {
                    new ReportDataSource("NhanVien", ReporterDAL.Instance.UPD_LayThongTinNhanVien(id)),
                }
            };
        }

        public Report_DTO UPD_LayDanhSachNhanVien_ChucVu(ChucVu_DTO chucvu) 
        {
            return new Report_DTO()
            {
                RdlcFile = "NhanVien_DanhSach.rdlc",
                ListTable = new List<ReportDataSource>()
                {
                    new ReportDataSource("NhanVien", ReporterDAL.Instance.UPD_LayDanhSachNhanVien_ChucVu((int)chucvu.Id)),
                },
                ListPara = new List<ReportParameter>()
                {
                    new ReportParameter("detail", "Nhân viên: " + chucvu.Ten),
                    new ReportParameter("user", User.FullName),
                },
            };
        }

        #endregion
    }
}
