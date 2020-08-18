using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class ChiTietYeuCauBUL
    {
        private static ChiTietYeuCauBUL instance;

        public static ChiTietYeuCauBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietYeuCauBUL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public CTyeucau_DTO Find(object idPhieu, object idSanPham)
        {
            return ChiTietYeuCauDAL.Instance.Find(idPhieu, idSanPham);
        }

        

    }
}
