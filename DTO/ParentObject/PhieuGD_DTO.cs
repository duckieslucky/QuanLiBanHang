using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ParentObject
{
    public class PhieuGD_DTO
    {
        private string id;
        private bool trangthai;
        private int idNhanVien;
        private string ghichu;
        private decimal? tongtien;
        private bool huydon;

        public decimal? Tongtien { get => tongtien; set => tongtien = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Id { get => id; set => id = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public bool Huydon { get => huydon; set => huydon = value; }
        

        //view
        //private int stt;
        //public int Stt { get => stt; set => stt = value; }
    }
}
