using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class SanPhamBUL
    {
        private static SanPhamBUL instance;

        public static SanPhamBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamBUL();
                }
                return instance;
            }
            private set => instance = value;
        }

        #region CRUD
        public List<SanPham_DTO> Retrieve()
        {
            return SanPhamDAL.Instance.Retrieve();
        }

        public List<SanPham_DTO> Retrieve(int? madm)
        {
            return SanPhamDAL.Instance.Retrieve(madm);
        }

        public List<SanPham_DTO> Retrieve_Deleted()
        {
            return SanPhamDAL.Instance.Retrieve_Deleted();
        }

        public bool InsertSanPham(SanPham_DTO sp)
        {
            return SanPhamDAL.Instance.InsertSanPham(sp);
        }

        public bool UpdateSanPham(SanPham_DTO sp)
        {
            return SanPhamDAL.Instance.UpdateSanPham(sp);
        }

        //viết sau
        public bool DeleteSanPham(SanPham_DTO sp)
        {
            return SanPhamDAL.Instance.DeleteSanPham(sp);
        }

        public SanPham_DTO Find(object id)
        {
            return SanPhamDAL.Instance.Find(id);
        }

        #endregion

        //more

        public List<SanPham_DTO> LaySanPham_YeuCau()
        {
            return SanPhamDAL.Instance.UPD_YeuCapNhap_ByTrangThai(false);
        }

        public List<SanPham_DTO> LaySanPham_YeuCauTheoNgay(DateTime start, DateTime end)
        {
            return SanPhamDAL.Instance.UPD_YeuCapNhap_ByRangeDate(false, start, end);
        }

        public List<SanPham_DTO> UPD_LayDanhSachSanPham_YeuCapNhap_TheoMaphieu(string idPhieu)
        {
            return SanPhamDAL.Instance.UPD_LayDanhSachSanPham_YeuCapNhap_TheoMaphieu(idPhieu);
        }
    }
}
