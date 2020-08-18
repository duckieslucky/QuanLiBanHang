using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class MenuConBUL
    {
        private static MenuConBUL instance;

        public static MenuConBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuConBUL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<MenuCon_DTO> Retrieve()
        {
            return MenuConDAL.Instance.Retrieve();
        }


        public bool InsertMenuCon(MenuCon_DTO con)
        {
            return MenuConDAL.Instance.InsertMenuCon(con);
        }

        public bool UpdateMenuCon(MenuCon_DTO con)
        {
            return MenuConDAL.Instance.UpdateMenuCon(con);
        }

        //viết sau
        public bool DeleteMenuCon(MenuCon_DTO con)
        {
            return MenuConDAL.Instance.DeleteMenuCon(con);
        }

        public MenuCon_DTO Find(object id)
        {
            return MenuConDAL.Instance.Find(id);
        }
    }
}
