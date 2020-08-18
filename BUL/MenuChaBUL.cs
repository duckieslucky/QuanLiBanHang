using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class MenuChaBUL
    {
        private static MenuChaBUL instance;

        public static MenuChaBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuChaBUL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<MenuCha_DTO> Retrieve()
        {
            return MenuChaDAL.Instance.Retrieve();
        }

        public bool InsertMenuCha(MenuCha_DTO cha)
        {
            return MenuChaDAL.Instance.InsertMenuCha(cha);
        }

        public bool UpdateMenuCha(MenuCha_DTO cha)
        {
            return MenuChaDAL.Instance.UpdateMenuCha(cha);
        }

        //viết sau
        public bool DeleteMenuCon(MenuCha_DTO cha)
        {
            return MenuChaDAL.Instance.DeleteMenuCha(cha);
        }

        public MenuCha_DTO Find(object id)
        {
            return MenuChaDAL.Instance.Find(id);
        }
    }
}
