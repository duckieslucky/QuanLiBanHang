using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class ThanhToanBUL
    {
        private static ThanhToanBUL instance;

        public static ThanhToanBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThanhToanBUL();
                }
                return instance;
            }
            private set => instance = value;
        }

        public ThanhToan_DTO Find(object id, object stt)
        {
            return ThanhToanDAL.Instance.Find(id, stt);
        }

        public List<ThanhToan_DTO> FindList(object idPhieu)
        {
            return ThanhToanDAL.Instance.FindList(idPhieu);
        }

        public bool InsertThanhToan(ThanhToan_DTO thanhtoan)
        {
            return ThanhToanDAL.Instance.InsertThanhToan(thanhtoan);
        }
    }
}
