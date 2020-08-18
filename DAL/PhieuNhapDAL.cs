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
    public class PhieuNhapDAL
    {
        private static PhieuNhapDAL instance;

        public static PhieuNhapDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuNhapDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        //all case
        public List<PhieuNhap_DTO> Retrieve()
        {
            string query = "select * from PhieuNhap";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<PhieuNhap_DTO> lResult = PhieuNhap_DTO.TableToList(dt);
            return lResult;
        }

        public List<HoaDon_DTO> Retrieve_View()
        {
            string query = "EXEC UPD_RetrievePhieuNhap_View";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<HoaDon_DTO> lResult = HoaDon_DTO.TableToList(dt);
            return lResult;
        }

        public PhieuNhap_DTO Find(object maphieu)
        {
            string query = "select * from PhieuNhap where id = @id";
            var values = new object[] { maphieu };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return PhieuNhap_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }

        public void InsertPhieuNhap(PhieuNhap_DTO pn, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "insert into PhieuNhap values(@id, @thoigianLap, @thoigianCapnhat, @trangthai, @tongtien, @tienno, @ghichu, @huydon, @idNhanVien, @idNhaCungCap, @idNhanVienKho)";
            SqlParameter[] paras = 
            {
                new SqlParameter("@id", pn.Id),
                new SqlParameter("@thoigianLap", pn.ThoigianLap),
                new SqlParameter("@thoigianCapnhat", HelperDAL.HandleNull(pn.ThoigianCapnhat)),
                new SqlParameter("@trangthai", false),
                new SqlParameter("@tongtien", HelperDAL.HandleNull(null)),
                new SqlParameter("@tienno", HelperDAL.HandleNull(null)),
                new SqlParameter("@ghichu", pn.Ghichu),
                new SqlParameter("@huydon", pn.Huydon),
                new SqlParameter("@idNhanVien", pn.IdNhanVien),
                new SqlParameter("@idNhaCungCap", pn.IdNhaCungCap),
                new SqlParameter("@idNhanVienKho", HelperDAL.HandleNull(null)),
            };
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(paras);
            cmd.ExecuteNonQuery();
        }

        public bool InsertPhieuNhap_IncludeChiTiet(PhieuNhap_DTO pn, List<CTphieunhap_DTO> listItem)
        {
            return DataProvider.Instance.ExecuteNonQuery_Advance(cmd =>
            {
                InsertPhieuNhap(pn, cmd);
                listItem.ForEach(i => ChiTietPhieuNhapDAL.Instance.InsertChiTiet(i, cmd));
            });
        }

        public void UpdatePhieuNhap(PhieuNhap_DTO pn, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "update PhieuNhap set trangthai = @trangthai, thoigianCapnhat = @thoigianCapnhat, tongtien = @tongtien, tienno = @tienno, huydon = @huydon, idNhanVienKho = @idNhanVienKho where id = @id";
            SqlParameter[] paras =
            {
                new SqlParameter("@id", pn.Id),
                new SqlParameter("@thoigianCapnhat", HelperDAL.HandleNull(pn.ThoigianCapnhat)),
                new SqlParameter("@trangthai", true),//tức là đã xem phiếu hồi âm từ nhà cung cấp
                new SqlParameter("@tongtien", HelperDAL.HandleNull(pn.Tongtien)),
                new SqlParameter("@tienno", HelperDAL.HandleNull(pn.Tienno)),
                new SqlParameter("@huydon", pn.Huydon),
                new SqlParameter("@idNhanVienKho", HelperDAL.HandleNull(null)),
            };
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(paras);
            cmd.ExecuteNonQuery();
        }

        public bool UpdatePhieuNhap_IncludeChiTiet(PhieuNhap_DTO pn, List<CTphieunhap_DTO> listItem)
        {
            return DataProvider.Instance.ExecuteNonQuery_Advance(cmd =>
            {
                UpdatePhieuNhap(pn, cmd);
                if (!pn.Huydon)
                {
                    listItem.ForEach(i => ChiTietPhieuNhapDAL.Instance.UpdateChiTiet(i, cmd));
                }
            });
        }

        public int Count_PhieuNhapByDate(DateTime yourDate)
        {
            string query = "SELECT count(*) FROM PhieuNhap where id like @prefix";
            SqlParameter[] paras =
            {
                new SqlParameter("@prefix", yourDate.ToString("ddMMyyyy") + "%"),
            };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, paras);
            return count;
        }


        public List<PhieuNhap_DTO> UPD_LayPhieuNhapConNo(int? idNhaCungCap = null)
        {
            string query = "EXEC UPD_LayPhieuNhapConNo @idNhaCungCap";
            object[] values = { HelperDAL.HandleNull(idNhaCungCap) };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<PhieuNhap_DTO> lResult = PhieuNhap_DTO.TableToList(dt);
            return lResult;
        }
    }
}
