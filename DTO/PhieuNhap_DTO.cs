using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap_DTO : PhieuGD_DTO
    {
        private DateTime thoigianLap;
        private DateTime? thoigianCapnhat;
        private decimal? tienno;
        private int idNhaCungCap;
        private int? idNhanVienKho;
        public int? IdNhanVienKho { get => idNhanVienKho; set => idNhanVienKho = value; }
        public DateTime ThoigianLap { get => thoigianLap; set => thoigianLap = value; }
        public DateTime? ThoigianCapnhat { get => thoigianCapnhat; set => thoigianCapnhat = value; }
        public decimal? Tienno { get => tienno; set => tienno = value; }
        public int IdNhaCungCap { get => idNhaCungCap; set => idNhaCungCap = value; }

        //view 
        private string tenNhanVien;
        private string tenNhaCungCap;
        private string tenNhanVienKho;
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
        public string TenNhanVienKho { get => tenNhanVienKho; set => tenNhanVienKho = value; }
        public decimal DaThanhtoan
        {
            get
            {
                if(Tongtien != null && Tienno != null)
                {
                    return (decimal)Tongtien - (decimal)tienno;
                }

                return 0;
            }
        }

        public PhieuNhap_DTO() : base()
        {

        }

        public static PhieuNhap_DTO Parse(DataRow dr, bool joinProperties = false)
        {
            var obj = new PhieuNhap_DTO()
            {
                Id = dr["id"].ToString(),
                thoigianLap = Convert.ToDateTime(dr["thoigianLap"]),
                thoigianCapnhat = dr.Field<DateTime?>("thoigianCapnhat"),
                Trangthai = Convert.ToBoolean(dr["trangthai"]),
                Tongtien = dr.Field<decimal?>("tongtien"),
                tienno = dr.Field<decimal?>("tienno"),
                Ghichu = dr["ghichu"].ToString(),
                Huydon = Convert.ToBoolean(dr["huydon"]),
                IdNhanVien = Convert.ToInt32(dr["idNhanVien"]),
                idNhaCungCap = Convert.ToInt32(dr["idNhaCungCap"]),
                IdNhanVienKho = dr.Field<int?>("idNhanVienKho"),
            };

            if (joinProperties)
            {
                obj.TenNhanVien = dr["tenNhanVien"].ToString();
                obj.TenNhanVienKho = dr["tenNhanVienKho"].ToString();
                obj.TenNhaCungCap = dr["tenNhaCungCap"].ToString();
            }
            return obj;
        }

        public static List<PhieuNhap_DTO> TableToList(DataTable dt)
        {
            bool joinProperties = false;
            if (dt.Columns.Contains("tenNhaCungCap"))
            {
                joinProperties = true;
            }

            List<PhieuNhap_DTO> lResult = new List<PhieuNhap_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr, joinProperties));
            }
            return lResult;
        }

    }
}