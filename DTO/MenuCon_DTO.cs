using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MenuCon_DTO:Menu_DTO
    {
        private int? idMenuCha;
        public int? IdMenuCha { get => idMenuCha; set => idMenuCha = value; }

        public MenuCon_DTO() : base()
        {

        }

        public static MenuCon_DTO Parse(DataRow dr)
        {
            return new MenuCon_DTO()
            {
                Id = Convert.ToInt32(dr["id"]),
                Ten = dr["ten"].ToString(),
                IdMenuCha = dr.Field<int?>("idMenuCha")
            };
        }

        public static List<MenuCon_DTO> TableToList(DataTable dt)
        {
            List<MenuCon_DTO> lResult = new List<MenuCon_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr));
            }
            return lResult;
        }
    }
}
