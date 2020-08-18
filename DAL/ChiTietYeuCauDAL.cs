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
    public class ChiTietYeuCauDAL
    {
        private static ChiTietYeuCauDAL instance;

        public static ChiTietYeuCauDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietYeuCauDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public CTyeucau_DTO Find(object idPhieu, object idSanPham)
        {
            string query = "select * from ChiTietYeuCau where idPhieu = @idPhieu and idSanPham = @idSanPham ";
            object[] values = { idPhieu, idSanPham };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return CTyeucau_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }

        public void InsertChiTiet(CTyeucau_DTO item, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "insert into ChiTietYeuCau values (@idPhieu, @idSanPham)";
            object[] values = { item.IdPhieu, item.IdSanPham };
            cmd.CommandText = query;
            cmd.Parameters.AddRange(HelperDAL.ExtractParameter(query, values));
            cmd.ExecuteNonQuery();
        }

    }
}
