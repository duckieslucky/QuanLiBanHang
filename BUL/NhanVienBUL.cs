using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BUL.Methods;
using DAL;
using DTO;

namespace BUL
{
    public class NhanVienBUL
    {

        private static NhanVienBUL instance;

        public static NhanVienBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBUL();
                }
                return instance;
            }
            set => instance = value;
        }


        #region Checking
        private bool SecurityPassword(string matkhau)
        {
            //regex tool
            return false;
        }

        private string EncodePassword(string password)
        {
            using(MD5 encoder = MD5.Create())
            {
                byte[] bytePassword = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hash = encoder.ComputeHash(bytePassword);
                StringBuilder sb = new StringBuilder();
                for(int i =0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
            
        }

        #endregion

        public List<NhanVien_DTO> Retrieve()
        {
            return NhanVienDAL.Instance.Retrieve();
        }

        public bool Login(string username, string password)
        {
            var data = NhanVienDAL.Instance.Login(username.ToLower(), EncodePassword(password));
            if(data != null)
            {
                //lấy thông tin
                User.Info = data;
                User.Position = ChucVuDAL.Instance.Find(data.IdChucVu);

                return true;
            }
            return false;
        }

        public bool InsertNhanVien(NhanVien_DTO nhanvien)
        {
            //tránh trùng tài khoản
            //if (!Checking_Taikhoan(nhanvien.Taikhoan))
            //{
            //    throw new Exception("Lỗi: Trùng tài khoản đã có"); 
            //}

            //mã hóa mật khẩu
            nhanvien.Matkhau = EncodePassword(nhanvien.Matkhau);

            //tiến hành insert
            return NhanVienDAL.Instance.InsertNhanVien(nhanvien);
        }

        public bool Checking_Taikhoan(string taikhoan)
        {
            return NhanVienDAL.Instance.Checking_Taikhoan(taikhoan);
        }

        public bool DeleteNhanVien(NhanVien_DTO nhanvien)
        {
            return NhanVienDAL.Instance.DeleteNhanVien(nhanvien);
        }

        public bool UpdateChucVu(NhanVien_DTO nhanvien)
        {
            return NhanVienDAL.Instance.UpdateChucVu(nhanvien);
        }

        public bool UpdatePersonal(NhanVien_DTO nhanvien)
        {
            return NhanVienDAL.Instance.UpdatePersonal(nhanvien);

        }

        public bool UpdateAccount(NhanVien_DTO nhanvien)
        {
            nhanvien.Matkhau = EncodePassword(nhanvien.Matkhau);
            return NhanVienDAL.Instance.UpdateAccount(nhanvien);

        }

        public NhanVien_DTO Find(object id)
        {
            return NhanVienDAL.Instance.Find(id);
        }

    }
}
