using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUL
{
    public class ChucVuBUL
    {
        private static ChucVuBUL instance;

        public static ChucVuBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuBUL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<ChucVu_DTO> Retrieve()
        {
            return ChucVuDAL.Instance.Retrieve();

        }

        public bool InsertChucVu(ChucVu_DTO chucvu)
        {
            return ChucVuDAL.Instance.InsertChucVu(chucvu);

        }

        public bool UpdateChucVu(ChucVu_DTO chucvu)
        {
            return ChucVuDAL.Instance.UpdateChucVu(chucvu);

        }

        //viết sau
        public bool DeleteChucVu(ChucVu_DTO chucvu)
        {
            return ChucVuDAL.Instance.DeleteChucVu(chucvu);
        }

        public ChucVu_DTO Find(object id)
        {
            return ChucVuDAL.Instance.Find(id);
        }
    }
}
