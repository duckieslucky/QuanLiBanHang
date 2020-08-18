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
    public class ThanhToanDAL
    {
        private static ThanhToanDAL instance;

        public static ThanhToanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThanhToanDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public ThanhToan_DTO Find(object id, object stt)
        {
            string query = "select * from ThanhToan where idPhieu = @idPhieu and stt = @stt";
            object[] values = { id, stt };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return ThanhToan_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }

        public List<ThanhToan_DTO> FindList(object idPhieu)
        {
            string query = "select * " +
                           "from ThanhToan_View " +
                           "where idPhieu = @idPhieu " +
                           "order by stt asc";
            object[] values = { idPhieu };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<ThanhToan_DTO> lResult = ThanhToan_DTO.TableToList(dt);
            return lResult;
        }

        public bool InsertThanhToan(ThanhToan_DTO thanhtoan)
        {
            string query = "EXEC UPD_ThanhtoanPhieuNhap @idPhieu, @sotien, @idNhanVien";
            object[] values = { thanhtoan.IdPhieu, thanhtoan.Sotien, thanhtoan.IdNhanVien };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }
    }
}
