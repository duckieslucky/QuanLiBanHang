using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuNhapDAL
    {
        private static ChiTietPhieuNhapDAL instance;

        public static ChiTietPhieuNhapDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuNhapDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<CTphieunhap_DTO> FindList(object idPhieu)
        {
            string query = "select * from ChiTietPhieuNhap_View where idPhieu = @idPhieu";
            object[] values = { idPhieu };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<CTphieunhap_DTO> lResult = CTphieunhap_DTO.TableToList(dt);
            return lResult;
        }

        public void InsertChiTiet(CTphieunhap_DTO ct, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "insert into ChiTietPhieuNhap values(@idPhieu, @idSanPham, @soluong, @dongia)";
            object[] values = { ct.IdPhieu, ct.IdSanPham, ct.Soluong, HelperDAL.HandleNull(ct.Dongia) };
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(HelperDAL.ExtractParameter(query, values));
            cmd.ExecuteNonQuery();
        }

        public void UpdateChiTiet(CTphieunhap_DTO ct, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "EXEC UPD_NhapHangVaoKho @idPhieu, @idSanPham, @dongia";
            object[] values = { ct.IdPhieu, ct.IdSanPham, ct.Dongia };
            cmd.CommandText = query;
            cmd.Parameters.AddRange(HelperDAL.ExtractParameter(query, values));
            cmd.ExecuteNonQuery();
        }
    }
}
