using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTyeucau_DTO
    {
        private string idPhieu;
        private int idSanPham;

        public string IdPhieu { get => idPhieu; set => idPhieu = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }

        //view
        private string tenSanPham;
        private string dvt;
        private int soluong; //tồn kho
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public static CTyeucau_DTO Parse(DataRow dr, bool joinProperties = false)
        {
            var chitiet = new CTyeucau_DTO()
            {
                IdPhieu = dr["idPhieu"].ToString(),
                IdSanPham = Convert.ToInt32(dr["idSanPham"]),
            };

            if (joinProperties)
            {
                chitiet.TenSanPham = dr["tenSanPham"].ToString();
                chitiet.Soluong = Convert.ToInt32(dr["soluong"]);
            }
            return chitiet;
        }

        public static List<CTyeucau_DTO> TableToList(DataTable dt)
        {
            bool joinProperties = false;
            if (dt.Columns.Contains("tenSanPham"))
            {
                joinProperties = true;
            }
            //transfer
            List<CTyeucau_DTO> lResult = new List<CTyeucau_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr, joinProperties));
            }
            return lResult;
        }
    }
}
