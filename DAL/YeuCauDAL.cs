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
    public class YeuCauDAL
    {
        private static YeuCauDAL instance;

        public static YeuCauDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new YeuCauDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public YeuCau_DTO Find(object id)
        {
            string query = "select * from YeuCau where id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new SqlParameter[]
            {
                new SqlParameter("@id", id)
            });
            if (dt.Rows.Count > 0)
            {
                return YeuCau_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }

        public List<YeuCau_DTO> Retrieve()
        {
            string query = "select * from YeuCau";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<YeuCau_DTO> lResult = YeuCau_DTO.TableToList(dt);

            return lResult;
        }

        public void InsertYeuCau(YeuCau_DTO yc, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "insert into YeuCau values(@id, @ngaylap, @idNhanVien, @trangthai, @ghichu)";
            object[] values = { yc.Id, yc.Ngaylap, HelperDAL.HandleNull(yc.Trangthai), yc.Ghichu, yc.IdNhanVien };
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(HelperDAL.ExtractParameter(query, values));
            cmd.ExecuteNonQuery();
        }

        public bool InsertYeuCau_IncludeChiTiet(YeuCau_DTO yc, List<CTyeucau_DTO> listItem)
        {
            return DataProvider.Instance.ExecuteNonQuery_Advance(cmd =>
            {
                InsertYeuCau(yc, cmd);
                listItem.ForEach(i => ChiTietYeuCauDAL.Instance.InsertChiTiet(i, cmd));
            });
        }

        public bool UpdateYeuCau(YeuCau_DTO yc)
        {
            string query = "Update YeuCau set trangthai = @trangthai where id = @id";
            object[] values = { HelperDAL.HandleNull(yc.Trangthai), HelperDAL.HandleNull(yc.Id) };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public int Count_YeuCauByDate(DateTime yourDate)
        {
            string query = "SELECT count(*) FROM YeuCau where id like @prefix";
            object[] values = { yourDate.ToString("ddMMyyyy") + "%" };
            int count = (int)DataProvider.Instance.ExecuteScalar(query,HelperDAL.ExtractParameter(query, values));
            return count;
        }

        public List<YeuCau_DTO> UPD_LayYeuCau_TheoNgay(bool trangthai)
        {
            string query = "EXEC UPD_LayYeuCau_TheoNgay @trangthai";
            object[] values = { HelperDAL.HandleNull(trangthai) };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<YeuCau_DTO> lResult = YeuCau_DTO.TableToList(dt);
            return lResult;
        }

        public List<YeuCau_DTO> UPD_LayYeuCau_TheoTuan(bool trangthai)
        {
            string query = "EXEC UPD_LayYeuCau_TheoTuan @trangthai";
            object[] values = { HelperDAL.HandleNull(trangthai) };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<YeuCau_DTO> lResult = YeuCau_DTO.TableToList(dt);
            return lResult;
        }

        public List<YeuCau_DTO> UPD_LayYeuCau_TheoThang(bool trangthai)
        {
            string query = "EXEC UPD_LayYeuCau_TheoThang @trangthai";
            object[] values = { HelperDAL.HandleNull(trangthai) };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<YeuCau_DTO> lResult = YeuCau_DTO.TableToList(dt);
            return lResult;
        }
    }
}
