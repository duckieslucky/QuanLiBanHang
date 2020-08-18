using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    //all of methods above will return datatable via UPD_ sql
    public class ReporterDAL
    {
        private static ReporterDAL instance;

        public static ReporterDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReporterDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        #region HoaDon
        
        public DataTable UPD_ReportHoaDonById(string idHoaDon)
        {
            string query = "EXEC UPD_ReportHoaDonById @idHoaDon";
            object[] values = { idHoaDon };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public DataTable UDP_ReportHoaDonByRangeDate(DateTime start, DateTime end)
        {
            string query = "EXEC UDP_ReportHoaDonByRangeDate @startDate , @endDate";
            object[] values = { start, end };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public DataTable UDP_ReportDoanhThuByYear(string year)
        {
            string query = "EXEC UDP_ReportDoanhThuByYear @year";
            object[] values = { year };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        #endregion

        #region DoanhThu
        public DataTable UPD_DoanhThuTheoNgay(DateTime start, DateTime end)
        {
            string query = "EXEC UPD_DoanhThuTheoNgay @startDate , @endDate";
            object[] values = { start, end };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public DataTable UPD_DoanhThuTheoThang(int month, int fullYear)
        {
            string query = "EXEC UPD_DoanhThuTheoThang @thang, @nam";
            object[] values = { month, fullYear };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public DataTable UPD_DoanhThuTheoNam(int fullYear)
        {
            string query = "EXEC UPD_DoanhThuTheoNam @nam";
            object[] values = { fullYear };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }
        #endregion

        public DataTable UPD_LayThongTinNhanVien(int id)
        {
            string query = "EXEC UPD_LayThongTinNhanVien @id";
            object[] values = { id };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public DataTable UPD_LayDanhSachNhanVien_ChucVu(int idChucVu)
        {
            string query = "EXEC UPD_LayDanhSachNhanVien_ChucVu @idChucVu";
            object[] values = { idChucVu };
            return DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
        }
    }
}
