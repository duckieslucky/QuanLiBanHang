using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO
    {
        private int id;
        private string ten;
        private int soluong;
        private string dvt;
        private decimal giagoc;
        private float tileLoi;
        private float tileKm;
        private int? idMenuCon;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public decimal Giagoc { get => giagoc; set => giagoc = value; }
        public float TileLoi { get => tileLoi; set => tileLoi = value; }
        public float TileKm { get => tileKm; set => tileKm = value; }
        public int? IdMenuCon { get => idMenuCon; set => idMenuCon = value; }
        public decimal Giaban 
        {
            get 
            {
                var temp = giagoc * (decimal)(1 + tileLoi) * (decimal)(1 - tileKm);
                return Math.Round(temp);
            } 
        }

        public decimal Tinh_GiaKhongKM()
        {
            return Math.Round(giagoc * (decimal)(1 + tileLoi));
        }

        public static SanPham_DTO Parse(DataRow r)
        {
            return new SanPham_DTO()
            {
                Id = Convert.ToInt32(r["id"]),
                Ten = r["ten"].ToString(),
                Giagoc = Convert.ToDecimal(r["giagoc"]),
                Soluong = Convert.ToInt32(r["soluong"]),
                TileLoi = Convert.ToSingle(r["tileLoi"]),
                TileKm = Convert.ToSingle(r["tileKm"]),
                Dvt = r["dvt"].ToString(),
                IdMenuCon = r.Field<int?>("idMenuCon")
            };
        }

        public static List<SanPham_DTO> TableToList(DataTable dt)
        {
            List<SanPham_DTO> lResult = new List<SanPham_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr));
            }
            return lResult;
        }
    }
}
