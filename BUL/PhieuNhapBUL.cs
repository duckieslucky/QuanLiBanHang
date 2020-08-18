using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUL.Methods;
using DAL;
using DTO;
namespace BUL
{
    public class PhieuNhapBUL
    {
        private static PhieuNhapBUL instance;

        public static PhieuNhapBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuNhapBUL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public string Get_NewId()
        {
            int count = PhieuNhapDAL.Instance.Count_PhieuNhapByDate(DateTime.Now);
            return BaseFormat.Generator_ViewId("PN", count);
        }

        //all case
        public List<PhieuNhap_DTO> Retrieve()
        {
            return PhieuNhapDAL.Instance.Retrieve();
        }

        public List<HoaDon_DTO> Retrieve_View()
        {
            return PhieuNhapDAL.Instance.Retrieve_View();
        }

        public bool InsertPhieuNhap(PhieuNhap_DTO pn, List<CTphieunhap_DTO> listItem)
        {
            pn.Id = BaseFormat.DateNow + pn.Id;
            listItem.ForEach(s => s.IdPhieu = pn.Id);
            return PhieuNhapDAL.Instance.InsertPhieuNhap_IncludeChiTiet(pn, listItem);
        }

        public int Count_PhieuNhapByDate(DateTime yourDate)
        {
            return PhieuNhapDAL.Instance.Count_PhieuNhapByDate(yourDate);
        }

        public PhieuNhap_DTO Find(string maphieu)
        {
            return PhieuNhapDAL.Instance.Find(maphieu);
        }

        public bool UpdatePhieuNhap(PhieuNhap_DTO pn, List<CTphieunhap_DTO> listItem)
        {
            if (pn.Huydon)
            {
                pn.Tongtien = 0;
                pn.Tienno = 0;
            }
            else
            {
                pn.Tongtien = pn.Tienno = listItem.Sum(s => s.Thanhtien);
            }
            
            return PhieuNhapDAL.Instance.UpdatePhieuNhap_IncludeChiTiet(pn, listItem);
        }
        public List<PhieuNhap_DTO> UPD_LayPhieuNhapConNo(int? idNhaCungCap = null)
        {
            return PhieuNhapDAL.Instance.UPD_LayPhieuNhapConNo(idNhaCungCap);
        }

    }
}
