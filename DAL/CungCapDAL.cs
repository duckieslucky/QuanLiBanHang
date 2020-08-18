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
    public class CungCapDAL
    {
        private static CungCapDAL instance;

        public static CungCapDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CungCapDAL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<CungCap_DTO> Retrieve()
        {
            string query = "select * from NhaCungCap";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<CungCap_DTO> lResult = CungCap_DTO.TableToList(dt);
            return lResult;
        }

        public bool InsertCungCap(CungCap_DTO cc)
        {
            string query = "insert into NhaCungCap(ten, sdt, diachi, email) values(@ten, @sdt, @diachi, @email)";
            object[] values = { cc.Ten, cc.Sdt, cc.Diachi, cc.Email };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public bool UpdateCungCap(CungCap_DTO cc)
        {
            string query = "update NhaCungCap set ten = @ten, sdt = @sdt, diachi = @diachi, email = @email where id = @id";
            object[] values = { cc.Ten, cc.Sdt, cc.Diachi, cc.Email, cc.Id };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }
        
        //viết sau
        public bool DeleteCungCap(CungCap_DTO cc)
        {
            return false;
        }

        public CungCap_DTO Find(object id)
        {
            string query = "select * from NhaCungCap where id = @id";
            object[] values = { id };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return CungCap_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }
    }
}
