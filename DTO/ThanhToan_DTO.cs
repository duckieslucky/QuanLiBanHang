using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhToan_DTO
    {
        string idPhieu;
        int stt;
        DateTime thoigian;
        decimal sotien;
        int idNhanVien;
        string tenNhanVien;

        public string IdPhieu { get => idPhieu; set => idPhieu = value; }
        public int Stt { get => stt; set => stt = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }
        public decimal Sotien { get => sotien; set => sotien = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        /// <summary>
        /// view
        /// </summary>
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }


        public static ThanhToan_DTO Parse(DataRow dr, bool joinProperties = false)
        {
            var thanhtoan = new ThanhToan_DTO()
            {
                IdPhieu = dr["idPhieu"].ToString(),
                Stt = Convert.ToInt32(dr["stt"]),
                Thoigian = Convert.ToDateTime(dr["thoigian"]),
                IdNhanVien = Convert.ToInt32(dr["idNhanVien"]),
                Sotien = Convert.ToDecimal(dr["Sotien"]),
            };

            if (joinProperties)
            {
                thanhtoan.TenNhanVien = dr["tenNhanVien"].ToString();
            }
            return thanhtoan;
        }

        public static List<ThanhToan_DTO> TableToList(DataTable dt)
        {
            bool joinProperties = false;
            if (dt.Columns.Contains("tenNhanVien"))
            {
                joinProperties = true;
            }
            //transfer
            List<ThanhToan_DTO> lResult = new List<ThanhToan_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr, joinProperties));
            }
            return lResult;
        }
    }
}
