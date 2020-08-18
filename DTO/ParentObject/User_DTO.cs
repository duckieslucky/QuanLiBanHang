using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ParentObject
{
    public class User_DTO
    {
        private int id;
        private string ten;
        private string sdt;
        private string diachi;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
    }
}
