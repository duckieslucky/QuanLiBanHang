using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu_DTO
    {
        private int? id;
        private string ten;
        private int nhomquyen;

        public int? Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Nhomquyen { get => nhomquyen; set => nhomquyen = value; }

        public static ChucVu_DTO Parse(DataRow dr)
        {
            return new ChucVu_DTO()
            {
                Id = Convert.ToInt32(dr["id"]),
                Ten = dr["ten"].ToString(),
                Nhomquyen = Convert.ToInt32(dr["nhomquyen"]),
            };
        }

        public static List<ChucVu_DTO> TableToList(DataTable dt)
        {
            List<ChucVu_DTO> lResult = new List<ChucVu_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr));
            }
            return lResult;
        }
    }
}
