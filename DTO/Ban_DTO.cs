using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban_DTO
    {
        private int id;
        private string ten;
        private bool controng;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public bool Controng { get => controng; set => controng = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public static Ban_DTO Parse(DataRow dr)
        {
            return new Ban_DTO()
            {
                Id = Convert.ToInt32(dr["id"]),
                Ten = dr["ten"].ToString(),
                Controng = Convert.ToBoolean(dr["controng"]),
                Ghichu = dr["ghichu"].ToString()
            };
        }

        public static List<Ban_DTO> TableToList(DataTable dt)
        {
            List<Ban_DTO> lResult = new List<Ban_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr));
            }
            return lResult;
        }
    }
}
