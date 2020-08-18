using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTphieunhap_DTO : CTphieu_DTO
    {
        private decimal? dongia;//decimal
        public decimal? Dongia { get => dongia; set => dongia = value; }

        public decimal Thanhtien
        {
            get
            {
                if(Dongia != null)
                {
                    return (decimal)Dongia * Soluong;
                }
                return 0;
            }
        }
        public CTphieunhap_DTO() : base()
        {

        }

        //conveter
        public static CTphieunhap_DTO Parse(DataRow dr, bool joinProperties = false)
        {
            var chitiet = new CTphieunhap_DTO()
            {
                IdPhieu = dr["idPhieu"].ToString(),
                IdSanPham = Convert.ToInt32(dr["idSanPham"]),
                Soluong = Convert.ToInt32(dr["soluong"]),
                Dongia = dr.Field<decimal?>("dongia")
            };

            if (joinProperties)
            {
                chitiet.TenSanPham = dr["tenSanPham"].ToString();
            }
            return chitiet;
        }

        public static List<CTphieunhap_DTO> TableToList(DataTable dt)
        {
            bool joinProperties = false;
            if (dt.Columns.Contains("tenSanPham"))
            {
                joinProperties = true;
            }
            //transfer
            List<CTphieunhap_DTO> lResult = new List<CTphieunhap_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr, joinProperties));
            }
            return lResult;
        }
    }
}
