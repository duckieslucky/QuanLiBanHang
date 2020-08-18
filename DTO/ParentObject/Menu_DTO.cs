using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ParentObject
{
    public class Menu_DTO
    {
        private int? id;
        private string ten;

        public int? Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}
