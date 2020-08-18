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
    public class MenuConDAL
    {
        private static MenuConDAL instance;

        public static MenuConDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuConDAL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<MenuCon_DTO> Retrieve()
        {
            string query = "select * from MenuCon";
            DataTable dt =  DataProvider.Instance.ExecuteQuery(query);

            List<MenuCon_DTO> lResult = MenuCon_DTO.TableToList(dt);

            return lResult;
        }

        public bool InsertMenuCon(MenuCon_DTO con)
        {
            string query = "insert into MenuCon(ten, [idMenuCha]) values(@ten, @idMenuCha)";
            object[] values = { con.Ten, HelperDAL.HandleNull(con.IdMenuCha) };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public bool UpdateMenuCon(MenuCon_DTO con)
        {
            string query = "update MenuCon set ten = @ten, idMenuCha = @idMenuCha where id = @id ";
            object[] values = { con.Id, con.Ten, HelperDAL.HandleNull(con.IdMenuCha) };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        //viết sau
        public bool DeleteMenuCon(MenuCon_DTO con)
        {
            return false;
        }

        public MenuCon_DTO Find(object id)
        {
            string query = "select * from MenuCon where id = @id";
            object[] values = { id };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return MenuCon_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }
    }
}
