using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO : PhieuGD_DTO
    {
        public HoaDon_DTO() : base()
        {

        }

        private DateTime checkin;
        private DateTime? checkout;
        private bool shipping;
        private bool sudungban;
        private int? idBan;
        private int giamgia;

        public DateTime Checkin { get => checkin; set => checkin = value; }
        public DateTime? Checkout { get => checkout; set => checkout = value; }
        public bool Shipping { get => shipping; set => shipping = value; }
        public bool Sudungban { get => sudungban; set => sudungban = value; }
        public int? IdBan { get => idBan; set => idBan = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }

        private string hinhthuc;
        public string Hinhthuc
        {
            get
            {
                if (shipping)
                {
                    return "Giao hàng";
                }
                else if (sudungban)
                {
                    return "Dùng tại quán";
                }

                return "Mua tại quầy";
            }
        }

        private decimal thanhtoan;
        public decimal Thanhtoan 
        {
            get
            {
                return (decimal)Tongtien * (100 - giamgia) / 100;
            }
        }


        //view
        private string tenban;
        private string tenNhanVien;

        public string Tenban { get => tenban; set => tenban = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }

        public static HoaDon_DTO Parse(DataRow dr, bool joinProperties = false)
        {
            var obj = new HoaDon_DTO()
            {
                Id = dr["id"].ToString(),
                Checkin = Convert.ToDateTime(dr["checkin"]),
                Checkout = dr.Field<DateTime?>("checkout"),
                Trangthai = Convert.ToBoolean(dr["trangthai"]),
                Giamgia = Convert.ToInt32(dr["giamgia"]),
                Tongtien = dr.Field<decimal?>("tongtien"),
                Huydon = Convert.ToBoolean(dr["huydon"]),
                Sudungban = Convert.ToBoolean(dr["sudungban"]),
                IdBan = dr.Field<int?>("idBan"),
                Shipping = Convert.ToBoolean(dr["shipping"]),
                Ghichu = dr["ghichu"].ToString(),
                IdNhanVien = Convert.ToInt32(dr["idNhanVien"]),
            };

            if (joinProperties)
            {
                obj.tenban = dr["tenBan"].ToString();
                obj.tenNhanVien = dr["tenNhanVien"].ToString();
            }
            return obj;
        }

        public static List<HoaDon_DTO> TableToList(DataTable dt)
        {
            bool joinProperties = false;
            if (dt.Columns.Contains("tenBan"))
            {
                joinProperties = true;
            }

            List<HoaDon_DTO> lResult = new List<HoaDon_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr, joinProperties));
            }
            return lResult;
        }

    }
}
