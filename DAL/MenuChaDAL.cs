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
    public class MenuChaDAL
    {
        private static MenuChaDAL instance;

        public static MenuChaDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuChaDAL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<MenuCha_DTO> Retrieve()
        {
            string query = "select * from MenuCha";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<MenuCha_DTO> lResult = MenuCha_DTO.TableToList(dt);

            return lResult;
        }

        public bool InsertMenuCha(MenuCha_DTO cha)
        {
            string query = "insert into MenuCha(ten) values(@ten)";
            object[] values = { cha.Ten };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        public bool UpdateMenuCha(MenuCha_DTO cha)
        {
            string query = "update MenuCha set ten = @ten where id = @id ";
            object[] values = { cha.Id, cha.Ten };
            return DataProvider.Instance.ExecuteNonQuery(query, HelperDAL.ExtractParameter(query, values));
        }

        //viết sau
        public bool DeleteMenuCha(MenuCha_DTO cha)
        {
            return false;
        }


        public MenuCha_DTO Find(object id)
        {
            string query = "select * from MenuCha where id = @id";
            object[] values = { id };
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, HelperDAL.ExtractParameter(query, values));
            if (dt.Rows.Count > 0)
            {
                return MenuCha_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }
    }
}
