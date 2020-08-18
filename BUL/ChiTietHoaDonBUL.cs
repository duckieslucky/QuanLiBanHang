using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUL;
using DAL;

namespace BUL
{
    public class ChiTietHoaDonBUL
    {
        private static ChiTietHoaDonBUL instance;

        public static ChiTietHoaDonBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonBUL();
                }
                return instance;
            }
            private set => instance = value;
        }


        public CThoadon_DTO Find(object idHoadon, object idSanPham)
        {
            return ChiTietHoaDonDAL.Instance.Find(idHoadon, idSanPham);
        }

        public List<CThoadon_DTO> FindList(object idHoadon)
        {
            return ChiTietHoaDonDAL.Instance.FindList(idHoadon);
        }

        //public bool InsertChiTiet(CThoadon_DTO CThoadon)
        //{
        //    return ChiTietHoaDonDAL.Instance.InsertChiTiet(CThoadon);
        //}

        //public bool InsertListChiTiet(List<CThoadon_DTO> listItem)
        //{
        //    return ChiTietHoaDonDAL.Instance.InsertListChiTiet(listItem);
        //}

        
    }
}
