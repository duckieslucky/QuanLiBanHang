using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MenuCha_DTO : Menu_DTO
    {
        public MenuCha_DTO() : base()
        {

        }

        public static MenuCha_DTO Parse(DataRow dr)
        {
            return new MenuCha_DTO()
            {
                Id = Convert.ToInt32(dr["id"]),
                Ten = dr["ten"].ToString(),
                
            };
        }

        public static List<MenuCha_DTO> TableToList(DataTable dt)
        {
            List<MenuCha_DTO> lResult = new List<MenuCha_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr));
            }
            return lResult;
        }
    }
}
