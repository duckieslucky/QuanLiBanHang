using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BanBUL
    {
        private static BanBUL instance;

        public static BanBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BanBUL();
                }
                return instance;
            }
            set => instance = value;
        }

        public List<Ban_DTO> Retrieve()
        {
            return BanDAL.Instance.Retrieve();
        }


        public bool InsertBan(Ban_DTO ban)
        {
            return BanDAL.Instance.InsertBan(ban);
        }

        public bool UpdateBan(Ban_DTO ban)
        {
            return BanDAL.Instance.UpdateBan(ban);
        }

        //viết sau
        public bool DeleteBan(Ban_DTO ban)
        {
            return BanDAL.Instance.DeleteBan(ban);
        }

        public Ban_DTO Find(object id)
        {
            return BanDAL.Instance.Find(id);
        }

    }
}
