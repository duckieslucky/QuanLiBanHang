using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BUL.Methods;

namespace BUL
{
    public class YeuCauBUL
    {
        private static YeuCauBUL instance;

        public static YeuCauBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new YeuCauBUL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public string Get_NewId()
        {
            int count = YeuCauDAL.Instance.Count_YeuCauByDate(DateTime.Now);
            return BaseFormat.Generator_ViewId("YC", count);
        }

        public YeuCau_DTO Find(object id)
        {
            return YeuCauDAL.Instance.Find(id);
        }

        public List<YeuCau_DTO> Retrieve()
        {
            return YeuCauDAL.Instance.Retrieve();
        }

        public bool InsertYeuCau(YeuCau_DTO yc, List<CTyeucau_DTO> listItem)
        {
            yc.Id = BaseFormat.DateNow + Get_NewId();
            listItem.ForEach(s => s.IdPhieu = yc.Id);
            return YeuCauDAL.Instance.InsertYeuCau_IncludeChiTiet(yc, listItem);
        }

        public bool UpdateYeuCau(YeuCau_DTO yc)
        {
            return YeuCauDAL.Instance.UpdateYeuCau(yc);
        }

        public int Count_YeuCauByDate(DateTime yourDate)
        {
            return YeuCauDAL.Instance.Count_YeuCauByDate(yourDate);
        }


        public List<YeuCau_DTO> UPD_LayYeuCau_TheoNgay(bool trangthai)
        {
            return YeuCauDAL.Instance.UPD_LayYeuCau_TheoNgay(trangthai);
        }

        public List<YeuCau_DTO> UPD_LayYeuCau_TheoTuan(bool trangthai)
        {
            return YeuCauDAL.Instance.UPD_LayYeuCau_TheoTuan(trangthai);
        }

        public List<YeuCau_DTO> UPD_LayYeuCau_TheoThang(bool trangthai)
        {
            return YeuCauDAL.Instance.UPD_LayYeuCau_TheoThang(trangthai);
        }
    }
}
