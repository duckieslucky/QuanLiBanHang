using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ParentObject
{
    public class CTphieu_DTO
    {
        private string idPhieu;
        private int idSanPham;
        private int soluong;
        

        public string IdPhieu { get => idPhieu; set => idPhieu = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        
        //View
        private string tenSanPham;
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
    }
}
