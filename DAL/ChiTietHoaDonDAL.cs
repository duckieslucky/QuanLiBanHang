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
    public class ChiTietHoaDonDAL
    {
        private static ChiTietHoaDonDAL instance;

        public static ChiTietHoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public CThoadon_DTO Find(object idHoadon, object idSanPham)
        {
            string query = "select * from ChiTietHoaDon where idHoadon = @idHoadon and idSanPham = @idSanPham ";
            object[] values = {idHoadon, idSanPham};
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return CThoadon_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }

        //chỉnh lại view chắc ngon or kết
        public List<CThoadon_DTO> FindList(object idHoadon)
        {
            string query = "select * from ChiTietHoaDon_View where idHoadon = @idHoadon";
            object[] values = { idHoadon };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            List<CThoadon_DTO> lResult = CThoadon_DTO.TableToList(dt);
            return lResult;
        }

        public void InsertChiTiet(CThoadon_DTO item, SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            string query = "exec Them_CThoadon @idHoaDon, @idSanPham, @soluong";
            SqlParameter[] paras = HelperDAL.ExtractParameter(query, new object[] 
            {
                item.IdPhieu,
                item.IdSanPham,
                item.Soluong,
            });
            cmd.CommandText = query;
            cmd.Parameters.AddRange(paras);
            cmd.ExecuteNonQuery();
        }

        

    }
}
