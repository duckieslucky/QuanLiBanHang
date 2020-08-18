using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class CungCapBUL
    {
        private static CungCapBUL instance;

        public static CungCapBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CungCapBUL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<CungCap_DTO> Retrieve()
        {
            return CungCapDAL.Instance.Retrieve();
        }

        public bool InsertCungCap(CungCap_DTO cc)
        {
            return CungCapDAL.Instance.InsertCungCap(cc);

        }

        public bool UpdateCungCap(CungCap_DTO cc)
        {
            return CungCapDAL.Instance.UpdateCungCap(cc);
        }


        //viết sau
        public bool DeleteCungCap(CungCap_DTO cc)
        {
            return CungCapDAL.Instance.DeleteCungCap(cc);
        }

        public CungCap_DTO Find(object id)
        {
            return CungCapDAL.Instance.Find(id);
        }
    }
}
