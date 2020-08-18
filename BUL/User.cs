using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUL
{
    public static class User
    {
        public static NhanVien_DTO Info;
        public static ChucVu_DTO Position;

        public static int Role
        {
            get
            {
                return Position.Nhomquyen;
            }
        }

        public static string FullName
        {
            get
            {
                return Info.Hoten;
            }
        }

        public static int UserId
        {
            get
            {
                return Info.Id;
            }
        }

        public static string Chucvu
        {
            get
            {
                return Position.Ten;
            }
        }
    }
}
