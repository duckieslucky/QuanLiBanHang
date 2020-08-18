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
    public class ChucVuDAL
    {
        private static ChucVuDAL instance;

        public static ChucVuDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuDAL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<ChucVu_DTO> Retrieve()
        {
            string query = "select * from ChucVu";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<ChucVu_DTO> lResult = ChucVu_DTO.TableToList(dt);            
            return lResult;
        }

        public bool InsertChucVu(ChucVu_DTO chucvu)
        {
            string query = "insert into ChucVu(ten, nhomquyen) values(@ten, @nhomquyen)";
            object[] values = { chucvu.Ten, chucvu.Nhomquyen };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public bool UpdateChucVu(ChucVu_DTO chucvu)
        {
            string query = "update ChucVu set ten = @ten, nhomquyen = @nhomquyen where id = @id";
            object[] values = { chucvu.Id, chucvu.Ten, chucvu.Nhomquyen };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        //viết sau
        public bool DeleteChucVu(ChucVu_DTO chucvu)
        {
            return false;
        }

        public ChucVu_DTO Find(object id)
        {
            string query = "select * from ChucVu where id = @id";
            object[] values = { id };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return ChucVu_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }
    }
}
