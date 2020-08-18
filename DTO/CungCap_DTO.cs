using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CungCap_DTO : User_DTO
    {
        public CungCap_DTO() : base()
        {

        }

        public static CungCap_DTO Parse(DataRow dr)
        {
            return new CungCap_DTO()
            {
                Id = Convert.ToInt32(dr["id"]),
                Ten = dr["ten"].ToString(),
                Sdt = dr["sdt"].ToString(),
                Diachi = dr["diachi"].ToString(),
                Email = dr["email"].ToString(),
            };
        }

        public static List<CungCap_DTO> TableToList(DataTable dt)
        {
            List<CungCap_DTO> lResult = new List<CungCap_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr));
            }
            return lResult;
        }
    }
}
