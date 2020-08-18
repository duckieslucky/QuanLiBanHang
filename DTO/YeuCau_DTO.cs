using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class YeuCau_DTO
    {
        private string id;
        private DateTime ngaylap;
        private bool? trangthai;
        private string ghichu;
        private int idNhanVien;

        public string Id { get => id; set => id = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public bool? Trangthai { get => trangthai; set => trangthai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }

        //converter
        public static YeuCau_DTO Parse(DataRow dr, bool joinProperties = false)
        {
            var obj = new YeuCau_DTO()
            {
                Id = dr["id"].ToString(),
                Ngaylap = Convert.ToDateTime(dr["ngaylap"]),
                Trangthai = dr.Field<bool?>("trangthai"),
                Ghichu = dr["ghichu"].ToString(),
                IdNhanVien = Convert.ToInt32(dr["idNhanVien"]),
            };

            if (joinProperties)
            {
                //obj.tenban = dr["tenBan"].ToString();
                //obj.tenNhanVien = dr["tenNhanVien"].ToString();
            }
            return obj;
        }

        public static List<YeuCau_DTO> TableToList(DataTable dt)
        {
            bool joinProperties = false;
            //if (dt.Columns.Contains("tenBan"))
            //{
            //    joinProperties = true;
            //}

            List<YeuCau_DTO> lResult = new List<YeuCau_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr, joinProperties));
            }
            return lResult;
        }
    }
}
