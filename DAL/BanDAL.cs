using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanDAL
    {
        private static BanDAL instance;

        public static BanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BanDAL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<Ban_DTO> Retrieve()
        {
            string query = "select * from Ban";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<Ban_DTO> lResult = Ban_DTO.TableToList(dt);
            
            return lResult;
        }

        public bool InsertBan(Ban_DTO ban)
        {
            string query = "insert into Ban(ten, controng, [ghichu]) values(@ten, @controng, @ghichu)";
            object[] values = { ban.Ten, ban.Controng, HelperDAL.HandleNull(ban.Ghichu) };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public bool UpdateBan(Ban_DTO ban)
        {
            string query = "update Ban set ten = @ten , controng = @controng , ghichu = @ghichu where id = @id";
            object[] values = { ban.Id, ban.Ten, ban.Controng, HelperDAL.HandleNull(ban.Ghichu) };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        //viết sau
        public bool DeleteBan(Ban_DTO ban)
        {
            return false;
        }

        public Ban_DTO Find(object id)
        {
            string query = "select * from Ban where id = @id";
            object[] values = { id };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return Ban_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }
    }

}
