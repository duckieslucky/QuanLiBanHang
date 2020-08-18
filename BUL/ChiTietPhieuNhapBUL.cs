using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ChiTietPhieuNhapBUL
    {
        private static ChiTietPhieuNhapBUL instance;

        public static ChiTietPhieuNhapBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuNhapBUL();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<CTphieunhap_DTO> FindList(object idPhieu)
        {
            return ChiTietPhieuNhapDAL.Instance.FindList(idPhieu);
        }
    }
}
