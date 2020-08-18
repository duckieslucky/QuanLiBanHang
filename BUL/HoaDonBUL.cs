using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using BUL.Methods;
using System.Data;

namespace BUL
{
    public class HoaDonBUL
    {
        private static HoaDonBUL instance;

        public static HoaDonBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public string Get_NewId()
        {
            int count = HoaDonDAL.Instance.Count_BillByDate(DateTime.Now);
            return BaseFormat.Generator_ViewId("HD", count);
        }

        public bool Create_HoaDon(HoaDon_DTO hd, List<CThoadon_DTO> dsSanPham)
        {
            hd.Id = BaseFormat.DateNow + Get_NewId();
            hd.Tongtien = dsSanPham.Sum(s => s.Thanhtien);
            dsSanPham.ForEach(s => s.IdPhieu = hd.Id);
            bool isSuccess = HoaDonDAL.Instance.InsertHoaDon_IncludeChiTiet(hd, dsSanPham);
            //cập nhật bàn sử dụng
            if (isSuccess)
            {
                if (hd.Sudungban && hd.IdBan != null)
                {
                    var obj = BanDAL.Instance.Find(hd.IdBan);
                    obj.Controng = false;
                    BanDAL.Instance.UpdateBan(obj);
                }
            }
            return isSuccess;
        }


        public bool UpdateHoaDon(HoaDon_DTO hd)
        {
            return HoaDonDAL.Instance.UpdateHoaDon(hd);

        }

        public bool CancelHoaDon(HoaDon_DTO hd)
        {
            return HoaDonDAL.Instance.CancelHoaDon(hd);
        }

        public HoaDon_DTO Find(object id)
        {
            return HoaDonDAL.Instance.Find(id);
        }

        public bool ThanhToan(object idHoaDon)
        {
            HoaDon_DTO hoadon = Find(idHoaDon);

            if (hoadon.Sudungban)
            {
                Ban_DTO ban = BanDAL.Instance.Find(hoadon.IdBan);
                ban.Controng = true;
                BanDAL.Instance.UpdateBan(ban);
            }

            hoadon.Checkout = DateTime.Now;
            hoadon.Trangthai = true;
            return HoaDonDAL.Instance.UpdateHoaDon(hoadon);
        }

        //more option
        //query
        public List<HoaDon_DTO> Get_BanBillByDate(DateTime yourdate)
        {
            return HoaDonDAL.Instance.Get_BillByDate(yourdate).FindAll(s=>s.Sudungban==true).OrderBy(s=>s.Checkin).ToList();
        }

        public List<HoaDon_DTO> Get_BillRangeDate(DateTime startDate, DateTime endDate)
        {
            return HoaDonDAL.Instance.Get_BillRangeDate(startDate, endDate);
        }

        public List<HoaDon_DTO> Get_BillByDate(DateTime date)
        {
            return HoaDonDAL.Instance.Get_BillByDate(date);
        }

        public List<HoaDon_DTO> Get_BillByDate(DateTime date, bool trangthai)
        {
            return HoaDonDAL.Instance.Get_BillByDate(date, trangthai);
        }

        public DataTable UPD_DoanhThu_NgayTrongTuan()
        {
            return HoaDonDAL.Instance.UPD_DoanhThu_NgayTrongTuan();
        }
        //Scalar
        public int Count_BillByDate(DateTime yourDate)
        {
            return HoaDonDAL.Instance.Count_BillByDate(yourDate);
        }

        public int Count_BillByDate(DateTime yourDate, bool trangthai)
        {
            return HoaDonDAL.Instance.Count_BillByDate(yourDate, trangthai);
        }

        public int Count_BillByDate(DateTime yourDate, bool trangthai, bool sudungban)
        {
            return HoaDonDAL.Instance.Count_BillByDate(yourDate, trangthai, sudungban);
        }

        public decimal Sum_BillByDate(DateTime yourDate)
        {
            return HoaDonDAL.Instance.Sum_BillByDate(yourDate);
        }

        public decimal Sum_BillByDate(DateTime yourDate, bool trangthai)
        {
            return HoaDonDAL.Instance.Sum_BillByDate(yourDate, trangthai);
        }
    }
}
