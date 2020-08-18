using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CThoadon_DTO : CTphieu_DTO
    {
        public decimal Thanhtien
        {
            get
            {
                return (decimal)(Soluong * Dongia);
            }
        }

        public decimal Dongia
        {
            get
            {
                var temp = giagoc * (decimal)(1 + tileLoi) * (decimal)(1 - tileKm);
                return Math.Round(temp);
            }
        }
        //properties

        public decimal Giagoc { get => giagoc; set => giagoc = value; }
        public float TileLoi { get => tileLoi; set => tileLoi = value; }
        public float TileKm { get => tileKm; set => tileKm = value; }

        private decimal giagoc;
        private float tileLoi;
        private float tileKm;
        


        //method
        public CThoadon_DTO() : base()
        {

        }

        public static CThoadon_DTO Parse(DataRow dr, bool joinProperties = false)
        {
            var chitiet = new CThoadon_DTO()
            {
                IdPhieu = dr["idHoaDon"].ToString(),
                IdSanPham = Convert.ToInt32(dr["idSanPham"]),
                Soluong = Convert.ToInt32(dr["soluong"]),
                Giagoc = Convert.ToDecimal(dr["giagoc"]),
                TileLoi = Convert.ToSingle(dr["tileLoi"]),
                tileKm = Convert.ToSingle(dr["tileKm"]),
            };

            if (joinProperties)
            {
                chitiet.TenSanPham = dr["tenSanPham"].ToString();
            }
            return chitiet;
        }

        public static List<CThoadon_DTO> TableToList(DataTable dt)
        {
            bool joinProperties = false;
            if (dt.Columns.Contains("tenSanPham"))
            {
                joinProperties = true;
            }
            //transfer
            List<CThoadon_DTO> lResult = new List<CThoadon_DTO>();
            foreach(DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr, joinProperties));
            }
            return lResult;
        }
    }
}
