using DTO.ParentObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO : User_DTO
    {
        private string ho;
        private DateTime ngaysinh;
        private string gioitinh;
        private string taikhoan;
        private string matkhau;
        private int? idChucVu;
        private string hoten;

        public NhanVien_DTO() : base()
        {

        }

        public string Ho { get => ho; set => ho = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int? IdChucVu { get => idChucVu; set => idChucVu = value; }
        public string Hoten 
        {
            get
            {
                return Ho + " " + Ten;
            } 
        }

        public bool IsMan { get { return gioitinh == "Nam"; } }
        public bool IsWoman { get { return gioitinh == "Nữ"; } }


        //view
        public static NhanVien_DTO Parse(DataRow r)
        {
            return new NhanVien_DTO()
            {
                Id = Convert.ToInt32(r["id"]),
                ho = r["ho"].ToString(),
                Ten = r["ten"].ToString(),
                ngaysinh = Convert.ToDateTime(r["ngaysinh"]),
                gioitinh = r["gioitinh"].ToString(),
                Sdt = r["sdt"].ToString(),
                Diachi = r["diachi"].ToString(),
                Email = r["email"].ToString(),
                taikhoan = r["taikhoan"].ToString(),
                matkhau = r["matkhau"].ToString(),
                idChucVu = r.Field<int?>("idChucVu")
            };
        }

        public static List<NhanVien_DTO> TableToList(DataTable dt)
        {
            List<NhanVien_DTO> lResult = new List<NhanVien_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                lResult.Add(Parse(dr));
            }
            return lResult;
        }
    }
}
