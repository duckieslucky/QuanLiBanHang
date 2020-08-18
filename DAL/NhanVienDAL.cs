using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        static NhanVienDAL instance;

        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAL();
                }
                return instance;
            }
            set => instance = value;
        }


        #region Nhân viên policy
        public NhanVien_DTO Login(string username, string encodePassword)
        {
            string query = $"select * from NhanVien where taikhoan = @taikhoan and matkhau = @matkhau and idChucVu is not NULL";
            var paras = HelperDAL.ExtractParameter(query, new object[] { username, encodePassword });
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, paras);

            if(dt.Rows.Count == 0)
            {
                return null;
            }

            return NhanVien_DTO.Parse(dt.Rows[0]);
        }


        #endregion
        public List<NhanVien_DTO> Retrieve()
        {
            string query = "select * from NhanVien";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            List<NhanVien_DTO> lResult = new List<NhanVien_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                lResult.Add(NhanVien_DTO.Parse(row));
            }

            return lResult;
        }

        public bool InsertNhanVien(NhanVien_DTO nv)
        {
            string query = "INSERT INTO NhanVien(ho, ten, ngaysinh, gioitinh, sdt, [diachi], [email], taikhoan, matkhau, [idChucvu]) values(@ho, @ten, @ngaysinh, @gioitinh, @sdt, @diachi, @email, @taikhoan, @matkhau, @idChucvu)";
            SqlParameter[] paras =
            {
                new SqlParameter("@ho", nv.Ho),
                new SqlParameter("@ten", nv.Ten),
                new SqlParameter("@ngaysinh", nv.Ngaysinh),
                new SqlParameter("@gioitinh", nv.Gioitinh),
                new SqlParameter("@sdt", nv.Sdt),
                new SqlParameter("@diachi", HelperDAL.HandleNull(nv.Diachi)),
                new SqlParameter("@email", HelperDAL.HandleNull(nv.Email)),
                new SqlParameter("@taikhoan", nv.Taikhoan),
                new SqlParameter("@matkhau", nv.Matkhau),
                new SqlParameter("@idChucvu", HelperDAL.HandleNull(nv.IdChucVu)),
            };

            return DataProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public bool DeleteNhanVien(NhanVien_DTO nv)
        {
            string query = $"update NhanVien set idChucVu = NULL where id = {nv.Id}";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool UpdateAccount(NhanVien_DTO nv)
        {
            string query = "update NhanVien set matkhau = @matkhau where id = @id";
            SqlParameter[] paras = 
            {
                new SqlParameter("@id", nv.Id),
                new SqlParameter("@matkhau", nv.Matkhau),
            };
            
            return DataProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public bool UpdatePersonal(NhanVien_DTO nv)
        {
            string query = "update NhanVien set ho = @ho, ten = @ten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, sdt = @sdt, diachi = @diachi, email = @email where id = @id";
            SqlParameter[] paras = 
            {
                new SqlParameter("@id", nv.Id),
                new SqlParameter("@ho", nv.Ho),
                new SqlParameter("@ten", nv.Ten),
                new SqlParameter("@ngaysinh", nv.Ngaysinh),
                new SqlParameter("@gioitinh", nv.Gioitinh),
                new SqlParameter("@sdt", nv.Sdt),
                new SqlParameter("@diachi", HelperDAL.HandleNull(nv.Diachi)),
                new SqlParameter("@email", HelperDAL.HandleNull(nv.Email)),
            };
            
            return DataProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public bool UpdateChucVu(NhanVien_DTO nv)
        {
            string query = "update into NhanVien set idChucVu = @idChucVu where id = @id ";
            SqlParameter[] paras =
            {
                new SqlParameter("@idChucvu", HelperDAL.HandleNull(nv.IdChucVu)),
                new SqlParameter("@id", nv.Id),
            };
            return DataProvider.Instance.ExecuteNonQuery(query, paras);
        }

        public bool Checking_Taikhoan(string taikhoan)
        {
            string query = $"select * from NhanVien where taikhoan = '{taikhoan}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows.Count > 0;
        }

        public NhanVien_DTO Find(object id)
        {
            string query = "select * from NhanVien where id = @id";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@id", id) });
            if (dt.Rows.Count > 0)
            {
                return NhanVien_DTO.Parse(dt.Rows[0]);
            }
            return null;
        }

    }
}
